using _10_Bridge.Entities;

namespace _10_Bridge.Abstract
{
    public abstract class MessageManager
    {
        public void Save()
        {
            Console.WriteLine("Message saved!");
        }

        public abstract void Send(Body body);
    }
}