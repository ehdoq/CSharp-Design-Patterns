using _01_SingletonOrnek.Classes;
using _01_SingletonOrnek.Classes.LoggerFactory;

CustomerManager cm1 = new(new EdLoggerFactory()); 
CustomerManager cm2 = new(new LogfNetLoggerFactory()); 
CustomerManager cm3 = new(new SerilogLoggerFactory());

cm1.Save();
cm2.Save();
cm3.Save();