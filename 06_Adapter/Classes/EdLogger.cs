using _06_Adapter.Interfaces;

namespace _06_Adapter.Classes
{
    public class EdLogger : ILogging
    {
        public void Log(string mesaj)
        {
            Console.WriteLine($"Loglandı, EdLogger, {mesaj}");
        }
    }
}