namespace _18_Mediator.Concrete
{
    public class Mediator
    {
        public Teacher? Teacher { get; set; }
        public List<Student>? Student { get; set; }

        public void UpdateImage(string url)
        {
            foreach (var student in Student)
            {
                student.RecieveImage(url);
            }
        }

        public void SendQuestion(string question, Student student)
        {
            Teacher.RecieveQuestion(question, student);
        }

        public void SendAnswer(string answer, Student student)
        {
            student.ReceiveAnswer(answer);
        }
    }
}