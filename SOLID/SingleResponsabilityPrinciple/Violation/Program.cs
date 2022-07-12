namespace SingleResponsabilityPrinciple.Violation
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var userService = new UserService();

            userService.Register("andra@email.com", "password");
        }
    }
}
