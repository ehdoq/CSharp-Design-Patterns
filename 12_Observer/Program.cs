using _12_Observer;
using _12_Observer.Concrete;

var customerObserver = new CustomerObserver();
ProductManager pm = new();

pm.Add(customerObserver);
pm.UpdatePrice();
pm.Remove(customerObserver);

pm.Add(new EmployeeObserver());
pm.UpdatePrice();