namespace Empires.Contracts
{
    using System.Collections.Generic;

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