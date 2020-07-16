namespace Observer
{
    public class Payroll : Employee.IEmployeeListener
    {
        public int TotalIncome { get; set; }

        public Payroll()
        {
            TotalIncome = 0;
        }

        public void OnIncomeChanged(int oldIncome, int newIncome)
        {
            TotalIncome = TotalIncome - oldIncome + newIncome;
        }
    }
}