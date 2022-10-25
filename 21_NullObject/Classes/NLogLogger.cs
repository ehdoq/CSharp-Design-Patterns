using _21_NullObject.Interfaces;

namespace _21_NullObject.Classes
{
    public class NLogLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged with NLogLogger");
        }
    }
}