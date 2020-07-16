namespace Adapter
{
    public class AnotherGas
    {
        public double V { get; }
        public double M { get; }
        public double T { get; }

        public AnotherGas(double volume, double moles, double temperature)
        {
            V = volume;
            M = moles;
            T = temperature;
        }
    }
}