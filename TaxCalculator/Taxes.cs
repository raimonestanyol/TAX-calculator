namespace TaxCalculator
{
    class Taxes
    {
        //propiedades
        public decimal IVA;
        public decimal IRPF;
        //constructor
        public Taxes()
        {
            IVA = 0.21M;
            IRPF = 0.24M;
        }
        //metodo
        public decimal TaxCalculator(decimal Salary)
        {
            switch (Salary)
            {
                case decimal d when d >= 12450 && d <= 20200:
                    IRPF = 0.24M;
                    break;
                case decimal d when d >= 20200 && d <= 35200:
                    IRPF = 0.3M;
                    break;
                case decimal d when d >= 20200 && d <= 35200:
                    IRPF = 0.37M;
                    break;
                default:
                    IRPF = 0.45M;
                    break;
            }
            return IRPF;
        }
        public decimal TaxesPaid(decimal Salary, decimal IRPF)
        {
            return Salary * IRPF + Salary * (1 - IRPF) * IVA;
        }
        public (decimal,decimal) Remaining(decimal Salary, decimal Taxes)
        {
            var tuple = (Salary - Taxes, 100 * (Taxes / Salary));
            return tuple;
        }
    }
}
