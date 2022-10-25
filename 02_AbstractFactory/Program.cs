using _02_AbstractFactory;
using _02_AbstractFactory.Concrete.Factory;

ProductManager pM1 = new(new FactoryOne());
ProductManager pM2 = new(new FactoryTwo());

pM1.GetAll();
pM2.GetAll();