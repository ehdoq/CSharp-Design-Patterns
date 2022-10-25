using _18_Mediator.Abstract;

namespace _18_Mediator.Concrete
{
    public class Teacher : CourseMember
    {
        public string? Name { get; set; }

        public Teacher(Mediator mediator) : base(mediator)
        {

        }

        public void RecieveQuestion(string question, Student student)
        {
            Console.WriteLine($"Teacher received a question from {student.Name}, {question}");
        }

        public void SendNewImageUrl(string url)
        {
            Console.WriteLine($"Teacher changed slide : {url}");
            Mediator.UpdateImage(url);
        }

        public void AnswerQuestion(string question, Student student)
        {
            Console.WriteLine($"Teacher answered question : {student.Name}, {question}");
        }
    }
}