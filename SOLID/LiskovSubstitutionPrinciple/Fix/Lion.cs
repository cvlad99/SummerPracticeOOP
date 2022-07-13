using System;

namespace LiskovSubstitutionPrinciple.Fix
{
    public class Lion: Feline
    {
        public override void SetSize(string size)
        {
            Size = size;
        }

        public override void GetSize()
        {
            Console.WriteLine(Size);
        }
    }
}
