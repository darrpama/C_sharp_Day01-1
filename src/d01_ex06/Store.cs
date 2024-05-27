public class Store {
	public Store(int capacity, int numberOfRegisters) {
		Storage = new Storage(capacity);
		CashRegisters = new List<CashRegister>(numberOfRegisters);
		for (int i = 1; i < numberOfRegisters + 1; i++) {
			CashRegisters.Add(new CashRegister($"Cash Register #{i}"));
		}
	}
	public Storage Storage;
	public List<CashRegister> CashRegisters;

	public bool IsOpen() {
		return !Storage.IsEmpty();
	}
}