namespace DependencyInversionPrinciple.Fix.Classes
{
    public class UserSqlDatabase : IUserDatabase
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
