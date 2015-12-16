namespace Empires.Contracts.GameLogic
{
    public interface IOutputWriter
    {
        void Print(string msg, params object[] msgArgs);
    }
}