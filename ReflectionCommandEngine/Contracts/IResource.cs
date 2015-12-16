namespace Empires.Contracts
{
    using Models;

    public interface IResource
    {
        ResourceType Type { get; }

        int Quantity { get; }
    }
}