using _06_Adapter.Interfaces;

namespace _06_Adapter.Classes
{
    public class Log4NetAdapter : ILogging
    {
        public void Log(string mesaj)
        {
            Log4Net log4Net = new();
            log4Net.Log4NetLogging(mesaj);
        }
    }
}