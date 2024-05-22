var customer1 = new Customer("Andrew", 1);
customer1.FillCart(15);
var customer2 = new Customer("Aboba", 2);
customer2.FillCart(15);
var customer3 = new Customer("Ababa", 3);
customer3.FillCart(15);

var customer4 = new Customer("Babab", 1);
customer4.FillCart(15);
var customer5 = new Customer("basse", 2);
customer5.FillCart(15);
var customer6 = new Customer("baefae", 3);
customer6.FillCart(15);

CashRegister register1 = new CashRegister("Register #1");
register1.customers.Enqueue(customer1);
register1.customers.Enqueue(customer2);
register1.customers.Enqueue(customer3);

CashRegister register2 = new CashRegister("Register #2");
register2.customers.Enqueue(customer4);
register2.customers.Enqueue(customer5);

Console.WriteLine(register1.ToString());
foreach (var customer in register1.customers) {
	Console.WriteLine(customer.ToString());
}

Console.WriteLine(register2.ToString());
foreach (var customer in register2.customers) {
	Console.WriteLine(customer.ToString());
}

Store store = new Store(30, 2);
store.CashRegisters.Add(register1);
store.CashRegisters.Add(register2);

Console.WriteLine(store.CashRegisters[0].ToString());
foreach (var customer in store.CashRegisters[0].customers) {
	Console.WriteLine(customer.ToString());
}

Console.WriteLine(store.CashRegisters[1].ToString());
foreach (var customer in store.CashRegisters[1].customers) {
	Console.WriteLine(customer.ToString());
}

CashRegister res = CustomerExtentions.ChooseLeastCustomers(store.CashRegisters);
Console.WriteLine(res.customers.Count());
foreach (var customer in res.customers) {
	Console.WriteLine(customer.ToString());
}
