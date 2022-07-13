using System;

namespace OpenClosedPrinciple.Fix.Classes
{
    public class CashPayment : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("You will pay cash on delivery");
        }
    }
}
