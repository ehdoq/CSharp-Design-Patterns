using _03_Prototype.Abstract;

namespace _03_Prototype.Concrete
{
    public class Customer : Person
    {
        public string? City { get; set; }

        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }
    }
}