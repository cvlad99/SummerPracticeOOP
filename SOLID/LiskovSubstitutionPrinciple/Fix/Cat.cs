using System;

namespace LiskovSubstitutionPrinciple.Fix
{
    public class Cat : Feline
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
