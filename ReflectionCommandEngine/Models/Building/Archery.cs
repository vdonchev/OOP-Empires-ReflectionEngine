namespace Empires.Models.Building
{
    using Attributes;

    [Building]
    public class Archery : Building
    {
        private const string ArcheryUnitToProduce = "Archer";
        private const int ArcheryTurnsToProduceUnit = 3;
        private const string ArcheryResourceToProduce = "Gold";
        private const int ArcheryTurnsToProduceResource = 2;
        private const int ArcheryResourceQuantity = 5;

        public Archery() 
            : base(
                  ArcheryUnitToProduce,
                  ArcheryTurnsToProduceUnit,
                  ArcheryResourceToProduce,
                  ArcheryTurnsToProduceResource,
                  ArcheryResourceQuantity)
        {
        }
    }
}