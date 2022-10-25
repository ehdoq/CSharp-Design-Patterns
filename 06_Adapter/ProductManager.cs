using _06_Adapter.Interfaces;

namespace _06_Adapter
{
    public class ProductManager
    {
        private readonly ILogging _logging;

        public ProductManager(ILogging logging)
        {
            _logging = logging;
        }

        public void Save()
        {
            _logging.Log("User Data.");
            Console.WriteLine("Kaydedildi.");
        }
    }
}