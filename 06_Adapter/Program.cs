using _06_Adapter;
using _06_Adapter.Classes;

ProductManager pM1 = new(new EdLogger());
pM1.Save();

ProductManager pM2 = new(new Log4NetAdapter());
pM2.Save();