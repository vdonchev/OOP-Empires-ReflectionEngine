namespace Empires.Contracts
{
    public interface IOutputWriter
    {
        void Print(string msg, params object[] msgArgs);
    }
}