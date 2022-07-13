using OpenClosedPrinciple.Fix.Classes;

namespace OpenClosedPrinciple.Fix
{
    //LSP Respected
    public class Program
    {
        public static void Main(string[] args)
        {
            PaymentService paymentService = new PaymentService();
            IPayment payment = new CashPayment();
            
            paymentService.ProcessPayment(payment);
        }
    }
}
