namespace Empires.UI
{
    using System;
    using Contracts.GameLogic;

    public class ConsoleReader : IInputReader
    {
        public string Read()
        {
            var input = Console.ReadLine();

            return input;
        }
    }
}