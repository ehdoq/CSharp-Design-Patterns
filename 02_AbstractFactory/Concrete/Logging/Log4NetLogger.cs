using _02_AbstractFactory.Abstract;

namespace _02_AbstractFactory.Concrete.Logging
{
    public class Log4NetLogger : Logger
    {
        public override void Log(string mesaj)
        {
            Console.WriteLine("Log4NetLogger ile loglandı");
        }
    }
}