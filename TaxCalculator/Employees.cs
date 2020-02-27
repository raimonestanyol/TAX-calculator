namespace TaxCalculator
{
    class Employees : IEmployees
    {
        //properties
        public string Name { get; set; }
        public decimal DailyWage { get; set; }
        public int Age { get; set; }

        //constructor
        public Employees(string name, decimal dailyWage, int age)
        {
            Name = name;
            DailyWage = dailyWage;
            Age = age;
        }
        //metodo
        public decimal SalaryCalculator(int NumDays, decimal DailyWage)
        {
            decimal salario = DailyWage * NumDays * 12;
            return salario;
        }
        public decimal SalaryCalculator(int NumDays)
        {
            decimal salario = DailyWage * NumDays * 12;
            return salario;
        }
    }
}
