using System;

namespace LiskovSubstitutionPrinciple.Violation
{
    public class Lion
    {
        public string Size { get; set; }

        public virtual void SetSize(string size)
        {
            Size = size;
        }

        public virtual void GetSize()
        {
            Console.WriteLine(Size);
        }
    }
}
