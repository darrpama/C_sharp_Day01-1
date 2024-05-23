var customer1 = new Customer("A", 1);
customer1.FillCart(15);
var customer2 = new Customer("B", 2);
customer2.FillCart(15);
var customer3 = new Customer("C", 3);
customer3.FillCart(15);
var customer4 = new Customer("D", 1);
customer4.FillCart(15);
var customer5 = new Customer("E", 2);
customer5.FillCart(15);
var customer6 = new Customer("F", 3);
customer6.FillCart(15);
var customer7 = new Customer("G", 1);
customer7.FillCart(15);
var customer8 = new Customer("H", 2);
customer8.FillCart(15);
var customer9 = new Customer("I", 3);
customer9.FillCart(15);
var customer10 = new Customer("J", 1);
customer10.FillCart(15);
var customer11 = new Customer("K", 2);
customer11.FillCart(15);
var customer12 = new Customer("L", 3);
customer12.FillCart(15);
var customer13 = new Customer("M", 1);
customer13.FillCart(15);
var customer14 = new Customer("N", 2);
customer14.FillCart(15);
var customer15 = new Customer("O", 3);
customer15.FillCart(15);

CashRegister register1 = new CashRegister("Register #1");
register1.customers.Enqueue(customer1);
register1.customers.Enqueue(customer2);
register1.customers.Enqueue(customer3);

CashRegister register2 = new CashRegister("Register #2");
register2.customers.Enqueue(customer4);
register2.customers.Enqueue(customer5);

CashRegister register3 = new CashRegister("Register #3");
register3.customers.Enqueue(customer6);
register3.customers.Enqueue(customer7);
register3.customers.Enqueue(customer8);
register3.customers.Enqueue(customer9);
register3.customers.Enqueue(customer10);
register3.customers.Enqueue(customer11);

CashRegister register4 = new CashRegister("Register #4");
register4.customers.Enqueue(customer12);
register4.customers.Enqueue(customer13);


// Console.WriteLine(register1.ToString());
// foreach (var customer in register1.customers) {
// 	Console.WriteLine(customer.ToString());
// }

// Console.WriteLine(register2.ToString());
// foreach (var customer in register2.customers) {
// 	Console.WriteLine(customer.ToString());
// }

Store store = new Store(30, 4);
store.CashRegisters[0] = register1;
store.CashRegisters[1] = register2;
store.CashRegisters[2] = register3;
store.CashRegisters[3] = register4;

// Console.WriteLine(store.CashRegisters[0].ToString());
// foreach (var customer in store.CashRegisters[0].customers) {
// 	Console.WriteLine(customer.ToString());
// }

CashRegister res = CustomerExtentions.ChooseLeastCustomers(store.CashRegisters);
foreach (var customer in res.customers) {
	Console.WriteLine(customer.ToString());
}
Console.WriteLine("");
CashRegister res2 = CustomerExtentions.ChooseLeastGoods(store.CashRegisters);
foreach (var customer in res2.customers) {
	Console.WriteLine(customer.ToString());
}