namespace Empires.Contracts.GameLogic
{
    public interface IEmpiresEngine : IUpdatable
    {
        ICommandFactory CommandFactory { get; }

        IEmpiresDatabase EmpiresDatabase { get; }

        IUnitFactory UnitFactory { get; }

        IBuildingFactory BuildingFactory { get; }

        IResourceFactory ResourceFactory { get; }

        void Run();

        void Render(string msg, params object[] msgArgs);
    }
}