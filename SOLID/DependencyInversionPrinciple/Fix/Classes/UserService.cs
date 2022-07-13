using System;

namespace DependencyInversionPrinciple.Fix.Classes
{
    public class UserService : IUserService
    {
        private readonly IUserDatabase _database;

        public UserService(IUserDatabase database)
        {
            _database = database;
        }

        public User[] GetAllUsers()
        {
            Console.WriteLine("Retrieving users from database");
            return _database.GetUsers();
        }
    }
}
