namespace Pluto.Interfaces
{
    public interface IRover
    {
        void ExecuteOrder(string message);
        char GetDirection();
        int GetX();
        int GetY();

    }
}
