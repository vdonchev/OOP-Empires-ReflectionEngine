namespace Empires.Contracts.GameLogic
{
    public interface ICommandFactory
    {
        ICommand CreateCommand(string commandName, IEmpiresEngine empiresEngine);
    }
}