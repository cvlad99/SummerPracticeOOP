using System;

namespace OpenClosedPrinciple.Fix.Classes
{
    public class PaypalPayment : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Paying via Paypal..");
        }
    }
}
