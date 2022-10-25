using _04_Builder.Entities;

namespace _04_Builder.Builder
{
    public class OldCustomerProductBuilder : ProductBuilder
    {
        readonly Product product = new();

        public override void GetProductData()
        {
            product.ProductId = 1;
            product.CategoryName = "Elektronik";
            product.ProductName = "Laptop";
            product.UnitPrice = 1000;
        }

        public override void ApplyDiscount()
        {
            product.DiscountedPrice = product.UnitPrice;
            product.DiscountApplied = false;
        }

        public override Product GetProduct()
        {
            return product;
        }
    }
}