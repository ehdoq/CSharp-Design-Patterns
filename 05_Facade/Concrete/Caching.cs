using _05_Facade.Interfaces;

namespace _05_Facade.Concrete
{
    public class Caching : ICaching
    {
        public void Cache()
        {
            Console.WriteLine("Cachelendi.");
        }
    }
}