using _19_Visitor.Abstract;

namespace _19_Visitor.Concrete
{
    public class PayrollVisitor : Visitor
    {
        public override void Visit(Worker worker)
        {
            Console.WriteLine($"{worker.Name} paid {worker.Salary}");
        }

        public override void Visit(Manager manager)
        {
            Console.WriteLine($"{manager.Name} paid {manager.Salary}");
        }
    }
}