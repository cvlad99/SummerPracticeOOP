using System;

namespace InterfaceSegregationPrinciple.Violation
{
    // I only need this class for printing
    public class SimplePrinter : ISmartDevice
    {
        public void Print()
        {
            Console.WriteLine("simple print");
        }

        public void Scan()
        {
            Console.WriteLine("not supported");
        }

        public void Fax()
        {
            Console.WriteLine("not supported");
        }
    }
}
