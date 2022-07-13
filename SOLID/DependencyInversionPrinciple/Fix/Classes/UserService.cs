using System;

namespace DependencyInversionPrinciple.Fix.Classes
{
    public class UserService : IUserService
    {
        private readonly IUserDatabase _userDatabase;

        public UserService(IUserDatabase userDatabase)
        {
            _userDatabase = userDatabase;
        }
        public User[] GetAllUsers()
        {
            Console.WriteLine("Retrieving users from database");
            return _userDatabase.GetUsers();
        }
    }
}
