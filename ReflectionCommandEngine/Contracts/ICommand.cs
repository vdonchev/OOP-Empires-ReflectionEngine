namespace Empires.Contracts
{
    public interface ICommand
    {
        IEmpiresEngine EmpiresEngine { get; }

        void Execute(params string[] commandArgs);
    }
}