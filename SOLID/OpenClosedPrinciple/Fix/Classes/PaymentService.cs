using System;

namespace OpenClosedPrinciple.Fix.Classes
{
    public class PaymentService
    {
        public void ProcessPayment(IPayment payment)
        {
            Console.WriteLine("Processing payment...");
            payment.Pay();
        }
    }
}
