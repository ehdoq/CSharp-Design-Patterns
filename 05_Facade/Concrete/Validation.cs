using _05_Facade.Interfaces;

namespace _05_Facade.Concrete
{
    public class Validation : IValidation
    {
        public void Validate()
        {
            Console.WriteLine("Doğrulandı.");
        }
    }
}