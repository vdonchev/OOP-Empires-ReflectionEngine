namespace Empires.Core.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Attributes;
    using Contracts;

    public class BuildingFactory : IBuildingFactory
    {
        public IBuilding CreateBuilding(string buildingTypeName)
        {
            var buildingType = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(
                    type =>
                        type.CustomAttributes.Any(a => a.AttributeType == typeof(BuildingAttribute)) &&
                        type.Name == buildingTypeName);

            if (buildingType == null)
            {
                throw new ArgumentNullException(nameof(buildingType), "Unknown building.");
            }

            var building = Activator.CreateInstance(buildingType) as IBuilding;

            return building;
        }
    }
}