using System;

namespace InterfaceSegregationPrinciple.Fix
{
    public class SimplePrinter: IPrinter
    {
        public void Print()
        {
            Console.WriteLine("print from simple");
        }
    }
}
