namespace _09_Decorator.Abstract
{
    public abstract class CarDecorator : Car
    {
        private readonly Car _car;

        protected CarDecorator(Car car)
        {
            _car = car;
        }
    }
}