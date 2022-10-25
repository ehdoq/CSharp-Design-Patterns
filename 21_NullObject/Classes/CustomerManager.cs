using _21_NullObject.Interfaces;

namespace _21_NullObject.Classes
{
    public class CustomerManager
    {
        private ILogger _logger;

        public CustomerManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Save()
        {
            Console.WriteLine("Saved!");
            _logger.Log();
        }
    }
}