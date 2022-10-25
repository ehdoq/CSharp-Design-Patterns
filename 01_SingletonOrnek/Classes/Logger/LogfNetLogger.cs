using _01_SingletonOrnek.Interfaces;

namespace _01_SingletonOrnek.Classes.Logger
{
    public class LogfNetLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("LogfNetLogger ile loglandı");
        }
    }
}