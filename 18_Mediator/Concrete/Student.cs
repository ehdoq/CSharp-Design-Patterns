using _18_Mediator.Abstract;

namespace _18_Mediator.Concrete
{
    public class Student : CourseMember
    {
        public string? Name { get; set; }

        public Student(Mediator mediator) : base(mediator)
        {

        }

        public void RecieveImage(string url)
        {
            Console.WriteLine($"{Name} received image : {url}");
        }

        public void ReceiveAnswer(string answer)
        {
            Console.WriteLine($"Student received answer : {answer}");
        }
    }
}