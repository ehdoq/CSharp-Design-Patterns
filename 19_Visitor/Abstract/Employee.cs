namespace _19_Visitor.Abstract
{
    public abstract class Employee
    {
        public abstract void Accept(Visitor visitor);
        public string? Name { get; set; }
        public decimal Salary { get; set; }
    }
}