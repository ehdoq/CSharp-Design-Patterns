using _13_ChainOfResponsibility.Abstract;
using _13_ChainOfResponsibility.Entities;

namespace _13_ChainOfResponsibility.Concrete
{
    public class President : ExpenseHandler
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Amount > 1000)
            {
                Console.WriteLine("President handled");
            }
        }
    }
}