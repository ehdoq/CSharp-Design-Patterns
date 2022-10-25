using _07_Composite.Classes;
using _07_Composite.Interfaces;

Worker boss1 = new() { Name = "AAA AAA" }; 
Worker boss2 = new() { Name = "BBB BBB" };
Worker worker1 = new() { Name = "CCC CCC" };

boss1.AddSubWorker(boss2);
boss1.AddSubWorker(worker1);

Supplier supplier1 = new() { Name = "DDD DDD"};
worker1.AddSubWorker(supplier1);

Worker worker2 = new() { Name = "FFF FFF" };
boss2.AddSubWorker(worker2);

Console.WriteLine(boss1.Name);

foreach (Worker boss in boss1)
{
    Console.WriteLine($"    {boss.Name}");

    foreach (IPerson worker in boss)
	{
        Console.WriteLine($"        {worker.Name}");
    }
}