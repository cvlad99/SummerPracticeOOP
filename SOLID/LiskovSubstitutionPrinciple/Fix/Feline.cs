namespace LiskovSubstitutionPrinciple.Fix
{
    public abstract class Feline
    {
        public string Size { get; set; }

        public abstract void SetSize(string size);

        public abstract void GetSize();
    }
}
