namespace _04_Builder.Builder
{
    public class ProductDirector
    {
        public void GenerateProduct(ProductBuilder pB)
        {
            pB.GetProductData();
            pB.ApplyDiscount();
        }
    }
}