namespace Empires.Contracts
{
    public interface IBuildingFactory
    {
        IBuilding CreateBuilding(string buildingTypeName);
    }
}