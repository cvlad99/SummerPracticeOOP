using System;

namespace InterfaceSegregationPrinciple.Violation
{
    public class AllInOnePrinter : ISmartDevice
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
