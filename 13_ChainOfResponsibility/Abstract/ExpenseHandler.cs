using _13_ChainOfResponsibility.Entities;

namespace _13_ChainOfResponsibility.Abstract
{
    public abstract class ExpenseHandler
    {
        protected ExpenseHandler Successor;
        public abstract void HandleExpense(Expense expense);
        public void SetSuccessor(ExpenseHandler successor)
        {
            Successor = successor;
        }
    }
}