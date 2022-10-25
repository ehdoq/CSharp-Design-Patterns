using _02_AbstractFactory.Abstract;

namespace _02_AbstractFactory.Concrete.Caching
{
    public class RedisCache : Cacher
    {
        public override void Cache(string mesaj)
        {
            Console.WriteLine("RedisCache ile Cachelendi");
        }
    }
}