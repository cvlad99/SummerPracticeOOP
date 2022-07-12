namespace LiskovSubstitutionPrinciple.Violation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Cat();

            lion.SetSize("big");

            lion.GetSize();
        }
    }
}
