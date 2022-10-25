namespace _01_Singleton
{
    public class CustomerManager
    {
        private static CustomerManager? _customerManager;

        static readonly object _lockObject = new();

        private CustomerManager()
        {

        }

        public static CustomerManager CreateSingleton()
        {
            lock (_lockObject)
            {
                _customerManager ??= new();
            }
            return _customerManager;
        }

        public void Save() => Console.WriteLine("Saved!");
    }
}