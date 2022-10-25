using _20_DependencyInjection.Interfaces;

namespace _20_DependencyInjection.Classes
{
    public class ProductManager
    {
        private IProduct _product;

        public ProductManager(IProduct product)
        {
            _product = product;
        }

        public void Save()
        {
            _product.Save();
        }
    }
}   