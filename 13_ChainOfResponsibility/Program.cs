using _13_ChainOfResponsibility.Concrete;
using _13_ChainOfResponsibility.Entities;

Manager m = new();
VicePresident vp = new();
President p = new();

m.SetSuccessor(vp);
vp.SetSuccessor(p);

Console.WriteLine("Type the amount:");
int amount = Convert.ToInt32(Console.ReadLine());

Expense expense = new() { Detail = "Training", Amount = amount };
m.HandleExpense(expense);