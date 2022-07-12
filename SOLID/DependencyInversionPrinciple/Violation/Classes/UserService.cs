using System;

namespace DependencyInversionPrinciple.Violation.Classes
{
    public class UserService
    {
        private readonly UserSqlDatabase _sqlDatabase;

        public UserService()
        {
            _sqlDatabase = new UserSqlDatabase();
        }

        public User[] GetAllUsers()
        {
            Console.WriteLine("Retrieving users from database");
            return _sqlDatabase.GetUsers();
        }
    }
}
