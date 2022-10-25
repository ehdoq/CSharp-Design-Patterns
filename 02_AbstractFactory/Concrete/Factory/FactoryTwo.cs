using _02_AbstractFactory.Abstract;
using _02_AbstractFactory.Concrete.Caching;
using _02_AbstractFactory.Concrete.Logging;

namespace _02_AbstractFactory.Concrete.Factory
{
    public class FactoryTwo : CCCFactory
    {
        public override Cacher CreateCaching()
        {
            return new MemoryCache();
        }

        public override Logger CreateLogger()
        {
            return new FileLogger();
        }
    }
}