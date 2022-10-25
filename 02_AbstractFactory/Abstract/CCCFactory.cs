namespace _02_AbstractFactory.Abstract
{
    public abstract class CCCFactory
    {
        //CCC = Cross Cutting Concerns
        public abstract Logger CreateLogger();
        public abstract Cacher CreateCaching();
    }
}