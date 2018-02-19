namespace Pluto.Helpers
{
    public static class MathHelper
    {
        //Ref: https://stackoverflow.com/questions/10065080/mod-explanation
        public static int Modulo(int a, int b)
        {
            return ((a % b) + b) % b;
        }
    }
}
