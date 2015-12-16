namespace Empires.Core.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Attributes;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitTypeName)
        {
            var unitType = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(
                    type =>
                        type.CustomAttributes.Any(a => a.AttributeType == typeof(UnitAttribute)) &&
                        type.Name == unitTypeName);

            if (unitType == null)
            {
                throw new ArgumentNullException(nameof(unitType), "Unknown unit.");
            }

            var unit = Activator.CreateInstance(unitType) as IUnit;

            return unit;
        }
    }
}