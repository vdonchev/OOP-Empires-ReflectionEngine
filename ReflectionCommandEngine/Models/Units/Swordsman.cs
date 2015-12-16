namespace Empires.Models.Units
{
    using Attributes;

    [Unit]
    public class Swordsman : Unit
    {
        private const int SwordsmanDefaultHealth = 40;
        private const int SwordsmanDefaultAttackDamage = 13;

        public Swordsman() 
            : base(
                  SwordsmanDefaultHealth,
                  SwordsmanDefaultAttackDamage)
        {
        }
    }
}