namespace Empires.Contracts.GameLogic
{
    using System.Collections.Generic;
    using Models;

    public interface IEmpiresDatabase
    {
        IEnumerable<IUnit> Units { get; }

        IEnumerable<IBuilding> Buildings { get; }

        IDictionary<string, int> Resources { get; }

        void AddUnit(IUnit unit);

        void AddBuilding(IBuilding building);

        void AddResources(IResource resource);
    }
}