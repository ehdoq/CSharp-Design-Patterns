using _19_Visitor.Concrete;

Manager manager1 = new() { Name = "AAAAAAA", Salary = 1000 };
Manager manager2 = new() { Name = "BBBBBBB", Salary = 900 };

Worker worker1 = new() { Name = "CCCCCCC", Salary = 800 };
Worker worker2 = new() { Name = "DDDDDDD", Salary = 800 };

manager1.Subordinates.Add(manager2);
manager2.Subordinates.Add(worker1);
manager2.Subordinates.Add(worker2);

OrganisationalStructure oS = new(manager1);

PayrollVisitor payrollVisitor = new();
PayriseVisitor payriseVisitor = new();

oS.Accept(payrollVisitor);
oS.Accept(payriseVisitor);