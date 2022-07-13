using System;

namespace OpenClosedPrinciple.Violation.Classes
{
    public class PaymentService
    {
        public void ProcessPayment(object payment)
        {
            Console.WriteLine("Processing payment.");
            if (payment is CashPayment)
            {
                CashPayment cashPayment = (CashPayment)payment;
                cashPayment.PayCash();
            }
            else if (payment is PaypalPayment paypalPayment)
            {
                paypalPayment.PayWithPaypal();
            }
            else if (payment is CreditCardPayment creditCardPayment)
            {
                creditCardPayment.PayWithCreditCard();
            }
            else
            {
                Console.WriteLine($"Unsupported payment type: {payment.GetType()}");
            }
        }
    }
}
