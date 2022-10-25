using _01_SingletonOrnek.Interfaces;

namespace _01_SingletonOrnek.Classes.Logger
{
    public class EdLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("EdLogger ile loglandı");
        }
    }
}