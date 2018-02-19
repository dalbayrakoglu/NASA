namespace Pluto.Interfaces
{
    public interface ICompass
    {
        char GetDirection();
        void Turn(char steer);
    }
}
