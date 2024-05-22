var customer1 = new Customer("Andrew", 1);
customer1.FillCart(15);
var customer2 = new Customer("Aboba", 2);
customer2.FillCart(15);
var customer3 = new Customer("Ababa", 3);
customer3.FillCart(15);

Console.WriteLine(customer1.ToString());
Console.WriteLine(customer2.ToString());
Console.WriteLine(customer3.ToString());

CashRegister register = new CashRegister("Register #1");
register.customers.Enqueue(customer1);
register.customers.Enqueue(customer2);
register.customers.Enqueue(customer3);

Console.WriteLine(register.ToString());

foreach (var customer in register.customers) {
	Console.WriteLine(customer.ToString());
}