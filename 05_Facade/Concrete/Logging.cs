using _05_Facade.Interfaces;

namespace _05_Facade.Concrete
{
    public class Logging : ILogging
    {
        public void Log()
        {
            Console.WriteLine("Loglandı.");
        }
    }
}