using _12_Observer.Abstract;

namespace _12_Observer.Concrete
{
    public class EmployeeObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Message to employee : Product price changed");
        }
    }
}