using _21_NullObject.Interfaces;

namespace _21_NullObject.Classes
{
    public class Log4NetLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged with Log4NetLogger");
        }
    }
}