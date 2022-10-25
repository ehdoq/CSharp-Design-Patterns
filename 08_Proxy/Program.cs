using _08_Proxy.Abstract;
using _08_Proxy.Concrete;

Credit credit = new CreditManagerProxy();

Console.WriteLine(credit.Calculate());
Console.WriteLine(credit.Calculate());