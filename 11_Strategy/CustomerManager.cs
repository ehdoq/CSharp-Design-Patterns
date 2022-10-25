using _11_Strategy.Abstract;

namespace _11_Strategy
{
    public class CustomerManager
    {
        public CreditCalculator CreditCalculator { get; set; }

        public void SaveCredit()
        {
            Console.WriteLine("Customer manager business");
            CreditCalculator.Calculate();
        }
    }
}