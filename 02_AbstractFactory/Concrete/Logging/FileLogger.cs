using _02_AbstractFactory.Abstract;

namespace _02_AbstractFactory.Concrete.Logging
{
    public class FileLogger : Logger
    {
        public override void Log(string mesaj)
        {
            Console.WriteLine("FileLogger ile loglandı");
        }
    }
}