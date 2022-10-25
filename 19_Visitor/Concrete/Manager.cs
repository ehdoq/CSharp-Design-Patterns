using _19_Visitor.Abstract;

namespace _19_Visitor.Concrete
{
    public class Manager : Employee
    {
        public List<Employee> Subordinates { get; set; }

        public Manager()
        {
            Subordinates = new();
        }

        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);

            foreach (var employee in Subordinates)
            {
                employee.Accept(visitor);
            }
        }
    }
}