namespace Empires.Contracts
{
    using Models;

    public interface IResourceFactory
    {
        IResource CreateReource(string resourceTypeName, int quantity);
    }
}