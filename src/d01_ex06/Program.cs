int maxCapacity = 10;

Store store = new(40, 3);

List<Customer> listOfCustomers = new()
{
  new("A", 1),
	new("B", 2),
	new("C", 3),
	new("D", 4),
	new("E", 5),
	new("F", 6),
	new("G", 7),
	new("H", 8),
	new("I", 9),
	new("J", 10),
};

Queue<Customer> q = new(10);
foreach (var customer in listOfCustomers) {
	q.Enqueue(customer);
}

while (store.IsOpen() && (q.Count > 0)) {
	Customer customer =	q.Dequeue();
	customer.FillCart(maxCapacity);
	var register = CustomerExtentions.ChooseLeastCustomers(ref store.CashRegisters);
	int tmp = store.Storage.NumberOfGoods - customer.NumberOfGoods;
	if (tmp < 0) {
		customer.NumberOfGoods -= tmp;
		store.Storage.NumberOfGoods = 0;
		Console.WriteLine($"{customer.Name}, customer #{customer.Id} ({customer.NumberOfGoods} items left in cart)");
	} else {
		store.Storage.NumberOfGoods -= customer.NumberOfGoods;
		register.customers.Append(customer);
		Console.WriteLine(customer.ToString() + " " + register.ToString());
	}
}

