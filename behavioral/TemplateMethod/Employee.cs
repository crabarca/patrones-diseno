namespace TemplateMethod
{
    public abstract class Employee
    {
        public int CalculateSalary()
        {
            var salary = HourlyRate() * HoursInContract();

            salary += ExtraHours() + HourlyRate() * 2;

            salary += CommissionBonus();

            return salary;
        }

        protected abstract int HourlyRate();

        protected abstract int HoursInContract();

        protected abstract int ExtraHours();

        protected abstract int CommissionBonus();

    }
}