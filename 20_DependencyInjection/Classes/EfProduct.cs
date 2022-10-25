using _20_DependencyInjection.Interfaces;

namespace _20_DependencyInjection.Classes
{
    public class EfProduct : IProduct
    {
        public void Save()
        {
            Console.WriteLine("Save with Entity Framework Core");
        }
    }
}