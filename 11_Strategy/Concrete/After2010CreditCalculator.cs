using _11_Strategy.Abstract;

namespace _11_Strategy.Concrete
{
    public class After2010CreditCalculator : CreditCalculator
    {
        public override void Calculate()
        {
            Console.WriteLine("Credit calculated using after 2010");
        }
    }
}