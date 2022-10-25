using _19_Visitor.Abstract;

namespace _19_Visitor.Concrete
{
    public class Worker : Employee
    {
        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}