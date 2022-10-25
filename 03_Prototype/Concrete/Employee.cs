using _03_Prototype.Abstract;

namespace _03_Prototype.Concrete
{
    public class Employee : Person
    {
        public decimal Salary { get; set; }

        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }
    }
}