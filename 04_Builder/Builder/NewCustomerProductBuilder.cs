using _04_Builder.Entities;

namespace _04_Builder.Builder
{
    public class NewCustomerProductBuilder : ProductBuilder
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
            product.DiscountedPrice = product.UnitPrice * (decimal)0.90;
            product.DiscountApplied = true;
        }

        public override Product GetProduct()
        {
            return product;
        }
    }
}