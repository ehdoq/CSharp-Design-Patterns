using _12_Observer.Abstract;

namespace _12_Observer
{
    public class ProductManager
    {
        List<Observer> _observer = new();

        public void Add(Observer observer)
        {
            _observer.Add(observer);
        }

        public void Remove(Observer observer)
        {
            _observer.Remove(observer);
        }

        private void Notify()
        {
            foreach (var observer in _observer)
            {
                observer.Update();
            }
        }

        public void UpdatePrice()
        {
            Console.WriteLine("Product price changed");
            Notify();
        }
    }
}