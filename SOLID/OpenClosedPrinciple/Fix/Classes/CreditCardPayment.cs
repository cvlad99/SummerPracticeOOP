using System;

namespace OpenClosedPrinciple.Fix.Classes
{
    public class CreditCardPayment : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Paying via credit card..");
        }
    }
}
