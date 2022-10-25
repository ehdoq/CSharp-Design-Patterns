using _10_Bridge.Abstract;
using _10_Bridge.Entities;

namespace _10_Bridge
{
    public class CustomerManager
    {
        public MessageManager MessageManager { get; set; }

        public void UpdateCustomer()
        {
            MessageManager.Send(new Body { Title = "Konu" });
            Console.WriteLine("Customer updated.");
        }
    }
}