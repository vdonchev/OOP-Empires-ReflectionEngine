namespace Empires.Models
{
    using Contracts;
    using Core.Utils;

    public class Resources : IResource
    {
        private ResourceType type;
        private int quantity;

        public Resources(
            ResourceType type, 
            int quantity)
        {
            this.Type = type;
            this.Quantity = quantity;
        }

        public ResourceType Type
        {
            get
            {
                return this.type;
            }

            private set
            {
                Validator.IfIsNull(value);
                this.type = value;
            }
        }

        public int Quantity
        {
            get
            {
                return this.quantity;
            }

            private set
            {
                Validator.IfIsBiggerThan(value, 0, true);
                this.quantity = value;
            }
        }
    }
}