using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var pressureCalculator = new PressureCalculator();
            var gas = new Gas(10, 10 ,10);
            var pressure = pressureCalculator.CalculateGasPressure(gas);
            
            var anotherGas = new AnotherGas(10, 10, 10);
            var adapter = new GasAdapter(anotherGas);
            var pressure2 = pressureCalculator.CalculateGasPressure(adapter);
        }
    }
}