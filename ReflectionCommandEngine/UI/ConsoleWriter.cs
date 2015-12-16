namespace Empires.UI
{
    using System;
    using Contracts.GameLogic;

    public class ConsoleWriter : IOutputWriter
    {
        public void Print(string msg, params object[] msgArgs)
        {
            Console.WriteLine(msg, msgArgs);
        }
    }
}