using _15_TemplateMethod.Abstract;
using _15_TemplateMethod.Concrete;

ScoringAlgorithm algorithm;

Console.WriteLine("Men");
algorithm = new MenScoringAlgorithm();
Console.WriteLine(algorithm.GenerateScore(10, new TimeSpan(0, 2, 34)));

Console.WriteLine("Women");
algorithm = new WomenScoringAlgorithm();
Console.WriteLine(algorithm.GenerateScore(10, new TimeSpan(0, 2, 34)));

Console.WriteLine("Children");
algorithm = new ChildrenScoringAlgorithm();
Console.WriteLine(algorithm.GenerateScore(10, new TimeSpan(0, 2, 34)));