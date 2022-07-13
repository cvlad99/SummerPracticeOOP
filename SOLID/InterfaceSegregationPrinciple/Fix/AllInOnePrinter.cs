using System;

namespace InterfaceSegregationPrinciple.Fix
{
    public class AllInOnePrinter: IPrinter, IScanner, IFax
    {
        public void Print()
        {
            Console.WriteLine("print");
        }

        public void Scan()
        {
            Console.WriteLine("scan");
        }

        public void Fax()
        {
            Console.WriteLine("fax");
        }
    }
}
