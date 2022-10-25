using _10_Bridge;
using _10_Bridge.Concrete;

CustomerManager cm = new();

cm.MessageManager = new EmailSender();
cm.UpdateCustomer();

cm.MessageManager = new SmsSender();
cm.UpdateCustomer();