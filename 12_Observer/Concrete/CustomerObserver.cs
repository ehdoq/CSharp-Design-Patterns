using _12_Observer.Abstract;

namespace _12_Observer.Concrete
{
    public class CustomerObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Message to customer : Product price changed");
        }
    }
}