public static class CustomerExtentions {
	public static CashRegister ChooseLeastCustomers(Customer customer, List<CashRegister> cashRegisters) {
		cashRegisters.Sort();
		return cashRegisters.FirstOrDefault();
	}
}