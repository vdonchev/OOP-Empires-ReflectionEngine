namespace Empires.Contracts
{
    public interface ICommandFactory
    {
        ICommand CreateCommand(string commandName, IEmpiresEngine empiresEngine);
    }
}