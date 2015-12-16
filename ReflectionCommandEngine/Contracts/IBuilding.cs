namespace Empires.Contracts
{
    public interface IBuilding : IUpdatable
    {
        int TurnsSinceBuild { get; }

        string UnitToProduce { get; }

        int TurnsToProduceUnit { get; }

        string ResourceToProduce { get; }

        int ResourceQuantity { get; }

        int TurnsToProduceResource { get; }

        bool CanProduceUnit();

        bool CanProduseResource();
    }
}