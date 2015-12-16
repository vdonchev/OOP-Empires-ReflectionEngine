namespace Empires.Exceptions
{
    using System;

    public class EmpiresException : Exception
    {
        protected EmpiresException(string message) 
            : base(message)
        {
        }
    }
}