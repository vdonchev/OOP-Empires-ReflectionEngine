namespace Empires.Models.Building
{
    using Attributes;

    [Building]
    public class Barracks : Building
    {
        private const string BarracksUnitToProduce = "Swordsman";
        private const int BarracksTurnsToProduceUnit = 4;
        private const string BarracksResourceToProduce = "Steel";
        private const int BarracksTurnsToProduceResource = 3;
        private const int BarracksResourceQuantity = 10;

        public Barracks() 
            : base(
                  BarracksUnitToProduce,
                  BarracksTurnsToProduceUnit,
                  BarracksResourceToProduce,
                  BarracksTurnsToProduceResource,
                  BarracksResourceQuantity)
        {
        }
    }
}