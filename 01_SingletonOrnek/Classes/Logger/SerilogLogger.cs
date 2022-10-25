using _01_SingletonOrnek.Interfaces;

namespace _01_SingletonOrnek.Classes.Logger
{
    public class SerilogLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("SerilogLogger ile loglandı");
        }
    }
}