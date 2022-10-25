using _21_NullObject.Interfaces;

namespace _21_NullObject.Classes
{
    public class StubLogger : ILogger
    {
        private static StubLogger _stubLogger;
        private static object _lock = new();

        private StubLogger() 
        { 

        }

        public static StubLogger GetLogger()
        {
            lock (_lock)
            {
                if (_stubLogger == null)
                {
                    _stubLogger = new();
                }
            }
            return _stubLogger;
        }

        public void Log()
        {
            
        }
    }
}