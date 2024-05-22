public static class CustomerExtentions {
	public static CashRegister ChooseLeastCustomers(List<CashRegister> cashRegisters) {
		cashRegisters.Sort();
		return cashRegisters[0];
	}
}