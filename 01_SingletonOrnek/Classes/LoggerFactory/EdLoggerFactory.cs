using _01_SingletonOrnek.Classes.Logger;
using _01_SingletonOrnek.Interfaces;

namespace _01_SingletonOrnek.Classes.LoggerFactory
{
    public class EdLoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            return new EdLogger();
        }
    }
}