namespace Empires.Core.Commands
{
    using Contracts;

    public abstract class Command : ICommand
    {
        protected Command(IEmpiresEngine empiresEngine)
        {
            this.EmpiresEngine = empiresEngine;
        }

        public IEmpiresEngine EmpiresEngine { get; private set; }

        public abstract void Execute(params string[] commandArgs);
    }
}