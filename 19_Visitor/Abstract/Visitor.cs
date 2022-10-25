using _19_Visitor.Concrete;

namespace _19_Visitor.Abstract
{
    public abstract class Visitor
    {
        public abstract void Visit(Worker worker);
        public abstract void Visit(Manager manager);
    }
}