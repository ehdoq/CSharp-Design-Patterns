using _09_Decorator.Abstract;

namespace _09_Decorator.Concrete
{
    public class SpecialOffer : CarDecorator
    {
        private readonly Car _car;

        public SpecialOffer(Car car) : base(car)
        {
            _car = car;
        }

        public int DiscountPercentage { get; set; }
        public override string? Make { get; set; }
        public override string? Model { get; set; }
        public override decimal HirePrice { get { return _car.HirePrice - _car.HirePrice * DiscountPercentage / 100; } set { } }
    }
}