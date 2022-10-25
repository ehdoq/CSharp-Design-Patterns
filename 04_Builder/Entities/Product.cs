﻿namespace _04_Builder.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? CategoryName { get; set; }
        public string? ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal DiscountedPrice { get; set; }
        public bool DiscountApplied { get; set; }
    }
}