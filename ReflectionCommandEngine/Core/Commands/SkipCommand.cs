﻿namespace Empires.Core.Commands
{
    using Attributes;
    using Contracts.GameLogic;

    [Command]
    public class SkipCommand : Command
    {
        public SkipCommand(IEmpiresEngine empiresEngine) 
            : base(empiresEngine)
        {
        }

        public override void Execute(params string[] commandArgs)
        {
        }
    }
}