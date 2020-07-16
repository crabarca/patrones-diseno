namespace Adapter
{
    public class PressureCalculator
    {
        public const double IdealGasConstant = 8.3134;
        public double CalculateGasPressure(IGas gas)
        {
            return (gas.Moles * IdealGasConstant * gas.Temperature) / gas.Volume;
        }
    }
}