using System;

namespace TaxCalculator
{
    class ConsoleWriter
    {
        public void Printer(Employees Employee, decimal Salary, decimal TaxesPaid, (decimal, decimal) Remaining, decimal IRPF)
        {
            Console.WriteLine("Hi " + Employee.Name);
            Console.WriteLine("Your yearly salary is: {0:F2} $", Salary);
            Console.WriteLine("The IRPF is {0:F2}%", IRPF * 100);
            Console.WriteLine("The taxes amount to: {0:F2} $", TaxesPaid);
            Console.WriteLine("The remaining of your salary after taxes is {0:F2} $", Remaining.Item1);
            Console.WriteLine(" so {0:F2} % of your salary is paid in taxes (IVA and IRPF).", Remaining.Item2);
            Console.ReadKey();
        }
    }
}