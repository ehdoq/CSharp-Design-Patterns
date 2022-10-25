using _10_Bridge.Abstract;
using _10_Bridge.Entities;

namespace _10_Bridge.Concrete
{
    public class EmailSender : MessageManager
    {
        public override void Send(Body body)
        {
            Console.WriteLine($"{body.Title} EmailSender ile gönderildi.");
        }
    }
}