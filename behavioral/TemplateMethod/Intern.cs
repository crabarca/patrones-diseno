namespace TemplateMethod
{
    public class Intern : Employee
    {
        protected override int HourlyRate()
        {
            return 15;
        }

        protected override int HoursInContract()
        {
            return 80;
        }

        protected override int ExtraHours()
        {
            return 0;
        }

        protected override int CommissionBonus()
        {
            return 0;
        }
    }
}