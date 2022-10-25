using _04_Builder.Entities;

namespace _04_Builder.Builder
{
    public abstract class ProductBuilder
    {
        public abstract void GetProductData();
        public abstract void ApplyDiscount();
        public abstract Product GetProduct();
    }
}