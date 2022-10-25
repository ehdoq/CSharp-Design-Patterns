using _11_Strategy;
using _11_Strategy.Concrete;

CustomerManager cm = new();

cm.CreditCalculator = new Before2010CreditCalculator();
cm.SaveCredit();

cm.CreditCalculator = new After2010CreditCalculator();
cm.SaveCredit();