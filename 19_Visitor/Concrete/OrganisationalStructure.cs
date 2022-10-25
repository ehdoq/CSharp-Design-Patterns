using _19_Visitor.Abstract;

namespace _19_Visitor.Concrete
{
    public class OrganisationalStructure
    {
        public Employee? _employee;

        public OrganisationalStructure(Employee? employee)
        {
            _employee = employee;
        }

        public void Accept(Visitor visitor)
        {
            _employee.Accept(visitor);
        }
    }
}