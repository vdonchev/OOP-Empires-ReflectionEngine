namespace Empires.Core.Commands
{
    using System.Globalization;
    using Attributes;
    using Contracts.GameLogic;

    [Command]
    public class BuildCommand : Command
    {
        public BuildCommand(IEmpiresEngine empiresEngine) 
            : base(empiresEngine)
        {
        }

        public override void Execute(params string[] commandArgs)
        {
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

            var buildingType = textInfo.ToTitleCase(commandArgs[0]);

            var building = this.EmpiresEngine.BuildingFactory.CreateBuilding(buildingType);

            this.EmpiresEngine.EmpiresDatabase.AddBuilding(building);
        }
    }
}