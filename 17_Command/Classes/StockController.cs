using _17_Command.Interfaces;

namespace _17_Command.Classes
{
    public class StockController
    {
        List<IOrder> _order = new();

        public void TakeOrder(IOrder order)
        {
            _order.Add(order);
        }

        public void PlaceOrders()
        {
            foreach (var order in _order)
            {
                order.Execute();
            }

            _order.Clear();
        }
    }
}