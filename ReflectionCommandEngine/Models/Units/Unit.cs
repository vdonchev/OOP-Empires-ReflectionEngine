namespace Empires.Models.Units
{
    using Contracts;
    using Core.Utils;

    public abstract class Unit : IUnit
    {
        private int health;
        private int attackDamage;

        protected Unit(
            int health,
            int attackDamage)
        {
            this.Health = health;
            this.AttackDamage = attackDamage;
        }

        public int Health
        {
            get
            {
                return this.health;
            }

            private set
            {
                this.health = this.RecalculateHealth(value);
            }
        }

        public int AttackDamage
        {
            get
            {
                return this.attackDamage;
            }

            private set
            {
                Validator.IfIsBiggerThan(value, 0, true);
                this.attackDamage = value;
            }
        }

        private int RecalculateHealth(int value)
        {
            if (value < 0)
            {
                return 0;
            }

            return value;
        }
    }
}