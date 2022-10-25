using _13_ChainOfResponsibility.Abstract;
using _13_ChainOfResponsibility.Entities;

namespace _13_ChainOfResponsibility.Concrete
{
    public class VicePresident : ExpenseHandler
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Amount > 100 && expense.Amount <= 1000)
            {
                Console.WriteLine("VicePresident handled");
            }
            else if (Successor != null)
            {
                Successor.HandleExpense(expense);
            }
        }
    }
}