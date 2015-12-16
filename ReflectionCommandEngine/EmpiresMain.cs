namespace Empires
{
    using Contracts;
    using Core;
    using Core.Factories;
    using Models.Building;
    using UI;

    public static class Program
    {
        public static void Main()
        {
            IInputReader reader = new ConsoleReader();
            IOutputWriter writer = new ConsoleWriter();
            ICommandFactory commandFactory = new CommandFactory();
            IEmpiresDatabase database = new EmpiresDatabase();
            IUnitFactory unitFactory = new UnitFactory();
            IBuildingFactory buildingFactory = new BuildingFactory();
            IResourceFactory resourceFactory = new ResourceFactory();

            var engine = new EmpiresEngine(
                reader, 
                writer,
                commandFactory,
                database,
                unitFactory,
                buildingFactory,
                resourceFactory);

            engine.Run();
        }
    }
}