using _03_Prototype.Concrete;

Customer customer1 = new()
{
    Id = 1,
    FirstName = "Mustafa",
    LastName = "Gedik",
    City = "İstanbul"
};

Customer customer2 = (Customer)customer1.Clone();
customer2.FirstName = "Ali";

Console.WriteLine($"{customer1.Id}-{customer1.FirstName}-{customer1.LastName}-{customer1.City}");
Console.WriteLine($"{customer2.Id}-{customer2.FirstName}-{customer2.LastName}-{customer2.City}");