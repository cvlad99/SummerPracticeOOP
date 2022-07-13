namespace OpenClosedPrinciple.Fix.Classes
{
    public class PaymentService
    {
        public void ProcessPayment(IPayment payment)
        {
            payment.Pay();
        }
    }
}
