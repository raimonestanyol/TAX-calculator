namespace TaxCalculator
{
    interface IEmployees
    {
        int Age { get; set; }
        decimal DailyWage { get; set; }
        string Name { get; set; }

        decimal SalaryCalculator(int NumDays);
        decimal SalaryCalculator(int NumDays, decimal DailyWage);
    }
}