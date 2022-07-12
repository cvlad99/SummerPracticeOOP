namespace DependencyInversionPrinciple.Violation.Classes
{
    public class UserSqlDatabase
    {
        public User[] GetUsers()
        {
            return new User[]
            {
                new User
                {
                    Username = "user1",
                    Email = "email1"
                },
                new User
                {
                    Username = "user2",
                    Email = "email2"
                }
            };
        }
    }
}
