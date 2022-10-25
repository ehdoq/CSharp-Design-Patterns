using _19_Visitor.Abstract;

namespace _19_Visitor.Concrete
{
    public class PayriseVisitor : Visitor
    {
        public override void Visit(Worker worker)
        {
            Console.WriteLine($"{worker.Name} salary increased to {worker.Salary * (decimal)1.1}");
        }

        public override void Visit(Manager manager)
        {
            Console.WriteLine($"{manager.Name} salary increased to {manager.Salary * (decimal)1.2}");
        }
    }
}