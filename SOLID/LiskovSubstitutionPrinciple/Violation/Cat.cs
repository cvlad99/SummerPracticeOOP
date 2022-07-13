using System;

namespace LiskovSubstitutionPrinciple.Violation
{
    public class Cat : Lion
    {
        public override void SetSize(string size)
        {
            Size = "small";
        }

        public override void GetSize()
        {
            Console.WriteLine(Size);
        }
    }
}
