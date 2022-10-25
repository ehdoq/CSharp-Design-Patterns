using _20_DependencyInjection.Interfaces;

namespace _20_DependencyInjection.Classes
{
    public class NhProduct : IProduct
    {
        public void Save()
        {
            Console.WriteLine("Save with Nhibernate");
        }
    }
}