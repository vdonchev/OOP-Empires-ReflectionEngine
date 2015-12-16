namespace Empires.Contracts.GameLogic
{
    public interface ICommand
    {
        IEmpiresEngine EmpiresEngine { get; }

        void Execute(params string[] commandArgs);
    }
}