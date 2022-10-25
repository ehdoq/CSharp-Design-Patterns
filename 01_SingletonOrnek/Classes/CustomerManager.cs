using _01_SingletonOrnek.Interfaces;

namespace _01_SingletonOrnek.Classes
{
    public class CustomerManager
    {
        private readonly ILoggerFactory _loggerFactory;

        public CustomerManager(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
        }

        public void Save()
        {
            Console.WriteLine("Kaydedildi");

            ILogger logger = _loggerFactory.CreateLogger();
            logger.Log();
        }
    }
}