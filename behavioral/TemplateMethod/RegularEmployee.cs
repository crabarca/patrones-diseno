namespace TemplateMethod
{
    public class RegularEmployee : Employee
    {
        public enum ContractType {FullTime, PartTime}
        
        private int _hourlyRate;
        private ContractType _contractType;
        
        public int ExtraHoursWorked { get; set; }
        
        public int Commissions { get; set; }

        public RegularEmployee(int hourlyRate, ContractType contractType)
        {
            _hourlyRate = hourlyRate;
            _contractType = contractType;
        }

        protected override int HourlyRate()
        {
            return _hourlyRate;
        }

        protected override int HoursInContract()
        {
            return _contractType == ContractType.FullTime ? 160 : 80;
        }

        protected override int ExtraHours()
        {
            return ExtraHoursWorked;
        }

        protected override int CommissionBonus()
        {
            return Commissions;
        }
    }
}