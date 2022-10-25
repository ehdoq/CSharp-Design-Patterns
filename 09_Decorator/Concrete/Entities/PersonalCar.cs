using _09_Decorator.Abstract;

namespace _09_Decorator.Concrete.Entities
{
    public class PersonalCar : Car
    {
        public override string? Make { get; set; }
        public override string? Model { get; set; }
        public override decimal HirePrice { get; set; }
    }
}