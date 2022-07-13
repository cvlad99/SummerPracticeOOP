using System;
using DependencyInversionPrinciple.Fix.Classes;

namespace DependencyInversionPrinciple.Fix
{
    //DIP respected
    public class Program
    {
        public static void Main(string[] args)
        {
            IUserDatabase userDatabase = new UserSqlDatabase();
            IUserService userService = new UserService(userDatabase);

            var users = userService.GetAllUsers();
            foreach (var user in users)
            {
                Console.WriteLine($"Username: {user.Username}; Email: {user.Email};");
            }
        }
    }
}
