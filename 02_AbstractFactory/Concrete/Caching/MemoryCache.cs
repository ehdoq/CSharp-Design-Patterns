using _02_AbstractFactory.Abstract;

namespace _02_AbstractFactory.Concrete.Caching
{
    public class MemoryCache : Cacher
    {
        public override void Cache(string mesaj)
        {
            Console.WriteLine("MemoryCache ile Cachelendi");
        }
    }
}