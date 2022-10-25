namespace _17_Command.Classes
{
    public class StockManager
    {
        private readonly string _name = "Laptop";
        private readonly int _quantity = 10;

        public void Buy()
        {
            Console.WriteLine($"Stock : {_name}, {_quantity} bought!");
        }

        public void Sell()
        {
            Console.WriteLine($"Stock : {_name}, {_quantity} sold!");
        }
    }
}