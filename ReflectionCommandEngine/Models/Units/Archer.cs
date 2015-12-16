namespace Empires.Models.Units
{
    using Attributes;

    [Unit]
    public class Archer : Unit
    {
        private const int ArcherDefaultHealth = 25;
        private const int ArcherDefaultAttackDamage = 7;

        public Archer() 
            : base(
                  ArcherDefaultHealth,
                  ArcherDefaultAttackDamage)
        {
        }
    }
}