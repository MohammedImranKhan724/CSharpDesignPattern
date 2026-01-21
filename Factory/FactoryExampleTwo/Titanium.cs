namespace Factory.FactoryExampleTwo
{
    public class Titanium : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 1000;
        }
        public string GetCardType()
        {
            return "Titanium Edge";
        }
        public int GetCreditLimit()
        {
            return 25000;
        }
    }
}
