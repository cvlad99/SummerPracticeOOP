using System;
using DependencyInversionPrinciple.Violation.Classes;

namespace DependencyInversionPrinciple.Violation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UserService userService = new UserService();
            User[] users = userService.GetAllUsers();
            foreach (User user in users)
            {
                Console.WriteLine($"Username: {user.Username}; Email: {user.Email};");
            }
        }
    }
}
