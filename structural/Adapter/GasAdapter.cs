namespace Adapter
{
    public class GasAdapter: IGas
    {
        private AnotherGas _anotherGas;

        public double Volume {
            get
            {
                return _anotherGas.V;
            }
        }
        public double Moles => _anotherGas.M;
        public double Temperature => _anotherGas.T;

        public GasAdapter(AnotherGas anotherGas)
        {
            _anotherGas = anotherGas;
        }
        
    }
}