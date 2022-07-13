using System;

namespace SingleResponsabilityPrinciple.Fix
{
    public class UserDatabase
    {
        public void AddUser(User user)
        {
            Console.WriteLine($"Adding User: {user.Email}");
        }
    }
}
