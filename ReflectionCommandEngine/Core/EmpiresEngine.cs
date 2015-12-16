namespace Empires.Core
{
    using System;
    using System.Globalization;
    using System.Linq;
    using Contracts;
    using Contracts.GameLogic;
    using Exceptions;

    public class EmpiresEngine : IEmpiresEngine
    {
        private const string CommandSuffix = "Command";

        private IInputReader reader;
        private IOutputWriter writer;

        public EmpiresEngine(
            IInputReader reader,
            IOutputWriter writer,
            ICommandFactory commandFactory,
            IEmpiresDatabase empiresDatabase,
            IUnitFactory unitFactory,
            IBuildingFactory buildingFactory,
            IResourceFactory resourceFactory)
        {
            this.reader = reader;
            this.writer = writer;
            this.CommandFactory = commandFactory;
            this.EmpiresDatabase = empiresDatabase;
            this.UnitFactory = unitFactory;
            this.BuildingFactory = buildingFactory;
            this.ResourceFactory = resourceFactory;
        }

        public ICommandFactory CommandFactory { get; private set; }

        public IEmpiresDatabase EmpiresDatabase { get; private set; }

        public IUnitFactory UnitFactory { get; private set; }

        public IBuildingFactory BuildingFactory { get; private set; }

        public IResourceFactory ResourceFactory { get; private set; }

        public void Run()
        {
            while (true)
            {
                var commandArgs = this.reader.Read().Split();

                try
                {
                    this.ExecuteCommand(commandArgs);
                }
                catch (EmpiresException ex)
                {
                    this.Render(ex.Message);
                }
                catch (Exception ex)
                {
                    this.Render(ex.Message);
                }

                this.Update();
            }
        }

        public void Render(string msg, params object[] msgArgs)
        {
            this.writer.Print(msg, msgArgs);
        }

        public void Update()
        {
            foreach (var building in this.EmpiresDatabase.Buildings)
            {
                building.Update();

                if (building.CanProduceUnit())
                {
                    var unit = this.UnitFactory.CreateUnit(building.UnitToProduce);
                    this.EmpiresDatabase.AddUnit(unit);
                }

                if (building.CanProduseResource())
                {
                    var resource = this.ResourceFactory
                        .CreateReource(building.ResourceToProduce, building.ResourceQuantity);

                    this.EmpiresDatabase.AddResources(resource);
                }
            }
        }

        private void ExecuteCommand(string[] commandArgs)
        {
            var commandName = this.FormatCommand(commandArgs);

            var commandParams = commandArgs.Skip(1).ToArray();

            var command = this.CommandFactory.CreateCommand(commandName, this);

            command.Execute(commandParams);
        }

        private string FormatCommand(string[] commandArgs)
        {
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            var commandName = commandArgs[0].Replace("-", string.Empty);
            commandName = textInfo.ToTitleCase(commandName) + CommandSuffix;

            return commandName;
        }
    }
}