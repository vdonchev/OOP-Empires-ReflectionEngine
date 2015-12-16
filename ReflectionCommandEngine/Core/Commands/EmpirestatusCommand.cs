namespace Empires.Core.Commands
{
    using System.Linq;
    using System.Text;
    using Attributes;
    using Contracts;

    [Command]
    public class EmpirestatusCommand : Command
    {
        public EmpirestatusCommand(IEmpiresEngine empiresEngine) 
            : base(empiresEngine)
        {
        }

        public override void Execute(params string[] commandArgs)
        {
            var result = new StringBuilder();

            result.AppendLine("Treasury:");
            foreach (var resource in this.EmpiresEngine.EmpiresDatabase.Resources)
            {
                result.AppendLine("--" + resource.Key + ": " + resource.Value);
            }

            result.AppendLine("Buildings:");
            if (!this.EmpiresEngine.EmpiresDatabase.Buildings.Any())
            {
                result.AppendLine("N/A");
            }
            else
            {
                foreach (var building in this.EmpiresEngine.EmpiresDatabase.Buildings)
                {
                    result.AppendLine(building.ToString());
                }
            }

            result.AppendLine("Units:");
            if (!this.EmpiresEngine.EmpiresDatabase.Units.Any())
            {
                result.AppendLine("N/A");
            }
            else
            {
                var groupedUnits = this.EmpiresEngine.EmpiresDatabase.Units
                    .GroupBy(u => u.GetType());

                foreach (var unit in groupedUnits)
                {
                    result.AppendLine("--" + unit.Key.Name + ": " + unit.Count());
                }
            }

            this.EmpiresEngine.Render(result.ToString().Trim());
        }
    }
}