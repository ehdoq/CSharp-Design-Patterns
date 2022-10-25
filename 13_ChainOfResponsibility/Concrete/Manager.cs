using _13_ChainOfResponsibility.Abstract;
using _13_ChainOfResponsibility.Entities;

namespace _13_ChainOfResponsibility.Concrete
{
    public class Manager : ExpenseHandler
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Amount <= 100)
            {
                Console.WriteLine("Manager handled");
            }
            else if (Successor != null)
            {
                Successor.HandleExpense(expense);
            }
        }
    }
}