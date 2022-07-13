using System;

namespace SingleResponsabilityPrinciple.Fix
{
    public class EmailService
    {
        public void SendEmail(string email, string message)
        {
            Console.WriteLine($"Sending email to {email} for registration");
        }
    }
}
