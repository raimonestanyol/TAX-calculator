using System;

namespace TaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees Employee = new Employees("Viktoriia", 60M, 40);
            var Salary = Employee.SalaryCalculator(20);
            Taxes Taxation = new Taxes();
            var IRPF = Taxation.TaxCalculator(Salary);
            var TaxesPaid = Taxation.TaxesPaid(Salary, IRPF);
            var Remaining = Taxation.Remaining(Salary, TaxesPaid);
            ConsoleWriter consoleWriter = new ConsoleWriter();
            consoleWriter.Printer(Employee, Salary, TaxesPaid, Remaining, IRPF);
        }
    }
}
