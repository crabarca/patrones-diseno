namespace Adapter
{
    public class Gas: IGas
    {
        public double Volume { get; }
        public double Moles { get; }
        public double Temperature { get; }

        public Gas(double volume, double moles, double temperature)
        {
            Volume = volume;
            Moles = moles;
            Temperature = temperature;
        }
    }
}