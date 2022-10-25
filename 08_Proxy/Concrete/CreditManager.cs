using _08_Proxy.Abstract;

namespace _08_Proxy.Concrete
{
    public class CreditManager : Credit
    {
        public override int Calculate()
        {
            int result = 1;

            for (int i = 1; i < 5; i++)
            {
                result *= i;
                Thread.Sleep(1000);
            }

            return result;
        }
    }
}