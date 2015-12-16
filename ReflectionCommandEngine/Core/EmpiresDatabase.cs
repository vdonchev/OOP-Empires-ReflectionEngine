namespace Empires.Core
{
    using System;
    using System.Collections.Generic;
    using Contracts;
    using Contracts.GameLogic;
    using Models;

    public class EmpiresDatabase : IEmpiresDatabase
    {
        private readonly ICollection<IUnit> units = new List<IUnit>(); 
        private readonly ICollection<IBuilding> buildings = new List<IBuilding>();
        private readonly IDictionary<string, int> resources = new Dictionary<string, int>();

        public EmpiresDatabase()
        {
            this.InitializeResources();
        }

        public IEnumerable<IUnit> Units
        {
            get
            {
                return this.units;
            }
        }

        public IEnumerable<IBuilding> Buildings
        {
            get
            {
                return this.buildings;
            }
        }

        public IDictionary<string, int> Resources
        {
            get
            {
                return this.resources;
            }
        }

        public void AddUnit(IUnit unit)
        {
            this.units.Add(unit);
        }

        public void AddBuilding(IBuilding building)
        {
            this.buildings.Add(building);
        }

        public void AddResources(IResource resource)
        {
            this.resources[resource.Type.ToString()] += resource.Quantity;
        }

        private void InitializeResources()
        {
            foreach (ResourceType resourceName in Enum.GetValues(typeof(ResourceType)))
            {
                this.Resources[resourceName.ToString()] = 0;
            }
        }
    }
}