namespace SingleResponsabilityPrinciple.Fix
{
    public class ValidatorService
    {
        public bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }
    }
}
