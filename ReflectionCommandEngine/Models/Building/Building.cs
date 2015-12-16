namespace Empires.Models.Building
{
    using Contracts;
    using Core.Utils;

    public class Building : IBuilding
    {
        private const int TurnDelay = 1;

        private string unitToProduce;
        private int turnsToProduceUnit;
        private string resourceToProduce;
        private int resourceQuantity;
        private int turnsToProduceResource;

        protected Building(
            string unitToProduce,
            int turnsToProduceUnit,
            string resourceToProduce,
            int turnsToProduceResource,
            int resourceQuantity)
        {
            this.TurnsSinceBuild = 0 - TurnDelay;
            this.UnitToProduce = unitToProduce;
            this.TurnsToProduceUnit = turnsToProduceUnit;
            this.ResourceToProduce = resourceToProduce;
            this.TurnsToProduceResource = turnsToProduceResource;
            this.ResourceQuantity = resourceQuantity;
        }

        public int TurnsSinceBuild { get; private set; }

        public string UnitToProduce
        {
            get
            {
                return this.unitToProduce;
            }

            private set
            {
                Validator.IfStringIsNullOrEmpty(value);
                this.unitToProduce = value;
            }
        }

        public int TurnsToProduceUnit
        {
            get
            {
                return this.turnsToProduceUnit;
            }

            private set
            {
                Validator.IfIsBiggerThan(value, 0, true);
                this.turnsToProduceUnit = value;
            }
        }

        public string ResourceToProduce
        {
            get
            {
                return this.resourceToProduce;
            }

            private set
            {
                Validator.IfStringIsNullOrEmpty(value);
                this.resourceToProduce = value;
            }
        }

        public int ResourceQuantity
        {
            get
            {
                return this.resourceQuantity;
            }

            private set
            {
                Validator.IfIsBiggerThan(value, 0, true);
                this.resourceQuantity = value;
            }
        }

        public int TurnsToProduceResource
        {
            get
            {
                return this.turnsToProduceResource;
            }

            private set
            {
                Validator.IfIsBiggerThan(value, 0, true);
                this.turnsToProduceResource = value;
            }
        }

        public void Update()
        {
            this.TurnsSinceBuild++;
        }

        public bool CanProduceUnit()
        {
            var result = this.TurnsSinceBuild > 0 &&
                         this.TurnsSinceBuild % this.TurnsToProduceUnit == 0;

            return result;
        }

        public bool CanProduseResource()
        {
            var result = this.TurnsSinceBuild > 0 &&
                         this.TurnsSinceBuild % this.TurnsToProduceResource == 0;

            return result;
        }

        public override string ToString()
        {
            var turnsLeftToProduceResource = 
                this.TurnsToProduceResource - (this.TurnsSinceBuild % this.TurnsToProduceResource);
            var turnsLeftToProduceUnit = 
                this.TurnsToProduceUnit - (this.TurnsSinceBuild % this.TurnsToProduceUnit);

            return
                $"--{this.GetType().Name}: {this.TurnsSinceBuild} turns ({turnsLeftToProduceUnit} turns until {this.UnitToProduce}, {turnsLeftToProduceResource} turns until {this.ResourceToProduce})";
        }
    }
}