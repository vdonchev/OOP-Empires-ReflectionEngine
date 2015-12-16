namespace Empires.Core.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Attributes;
    using Contracts;

    public class CommandFactory : ICommandFactory
    {
        public ICommand CreateCommand(string commandName, IEmpiresEngine empiresEngine)
        {
            var commandType = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(
                    type =>
                        type.CustomAttributes.Any(a => a.AttributeType == typeof(CommandAttribute)) &&
                        type.Name == commandName);

            if (commandType == null)
            {
                throw new ArgumentNullException(nameof(commandType), "Unknown command.");
            }

            var command = Activator.CreateInstance(commandType, empiresEngine) as ICommand;

            return command;
        }
    }
}