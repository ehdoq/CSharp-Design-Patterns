using _09_Decorator.Concrete;
using _09_Decorator.Concrete.Entities;

var personalCar = new PersonalCar() { Make = "BMW", Model = "3.20", HirePrice = 2500 };

SpecialOffer specialOffer = new(personalCar);
specialOffer.DiscountPercentage = 10;

Console.WriteLine($"Concrete = {personalCar.HirePrice}");
Console.WriteLine($"Special Offer = {specialOffer.HirePrice}");