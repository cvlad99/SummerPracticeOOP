using System;

namespace SingleResponsabilityPrinciple.Fix
{
    public class UserService
    {
        private readonly EmailService _emailService;
        private readonly ValidatorService _validatorService;
        private readonly UserDatabase _userDatabase;

        public UserService()
        {
            _emailService = new EmailService();
            _validatorService = new ValidatorService();
            _userDatabase = new UserDatabase();
        }

        public void Register(string email, string password)
        {
            if (!_validatorService.ValidateEmail(email))
            {
                Console.WriteLine("Email is not a valid email");
                return;
            }

            var user = new User(email, password);
            _userDatabase.AddUser(user);

            _emailService.SendEmail(user.Email, "Hello world");
        }
    }
}
