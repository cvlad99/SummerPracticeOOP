using System;

namespace SingleResponsabilityPrinciple.Violation
{
    public class UserService
    {
        public void Register(string email, string password)
        {
            if (!ValidateEmail(email))
            {
                Console.WriteLine("Email is not an email");
                return;
            }

            var user = new User(email, password);

            AddUser(user);

            SendEmail(user.Email, "Hello world");
        }

        public bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }

        public void AddUser(User user)
        {
            Console.WriteLine($"Adding User: {user.Email}");
        }

        public void SendEmail(string email, string message)
        {
            Console.WriteLine($"Sending email to {email} for registration");
        }
    }
}
