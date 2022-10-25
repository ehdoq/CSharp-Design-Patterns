using _02_AbstractFactory.Abstract;
using _02_AbstractFactory.Concrete.Caching;
using _02_AbstractFactory.Concrete.Logging;

namespace _02_AbstractFactory.Concrete.Factory
{
    public class FactoryOne : CCCFactory
    {
        public override Cacher CreateCaching()
        {
            return new RedisCache();
        }

        public override Logger CreateLogger()
        {
            return new Log4NetLogger();
        }
    }
}