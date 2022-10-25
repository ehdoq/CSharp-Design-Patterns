using _20_DependencyInjection.Classes;
using _20_DependencyInjection.Interfaces;
using Ninject;

IKernel k1 = new StandardKernel();
k1.Bind<IProduct>().To<EfProduct>().InSingletonScope();

IKernel k2 = new StandardKernel();
k2.Bind<IProduct>().To<NhProduct>().InSingletonScope();

ProductManager pM1 = new(k1.Get<IProduct>());
ProductManager pM2 = new(k2.Get<IProduct>());

pM1.Save();
pM2.Save();