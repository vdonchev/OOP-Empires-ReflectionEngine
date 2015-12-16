namespace Empires.Core.Commands
{
    using System;
    using Attributes;
    using Contracts;

    [Command]
    public class ArmisticeCommand : Command
    {
        public ArmisticeCommand(IEmpiresEngine empiresEngine) 
            : base(empiresEngine)
        {
        }

        public override void Execute(params string[] commandArgs)
        {
            Environment.Exit(0);
        }
    }
}