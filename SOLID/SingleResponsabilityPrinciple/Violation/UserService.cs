using System;
using System.ComponentModel.DataAnnotations;

namespace SingleResponsabilityPrinciple.Violation
{
    public class UserService
    {
        public void Register(string email, string password)
        {
            if (!ValidateEmail(email))
                throw new ValidationException("Email is not an email");

            var user = new User(email, password);



            SendEmail("random@email.com", "Hello world");
        }

        public bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }

        public void AddUser(User user)
        {
            Console.WriteLine($"Adding {user}");
        }

        public void SendEmail(string email, string message)
        {
            Console.WriteLine("Sending email");
        }
    }
}
