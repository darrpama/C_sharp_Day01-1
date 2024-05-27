public static class CustomerExtentions {
	public static CashRegister ChooseLeastCustomers(ref List<CashRegister> cashRegisters) {
		cashRegisters.Sort((l, r) => l.customers.Count().CompareTo(r.customers.Count()));
		return cashRegisters[0];
	}
	public static CashRegister ChooseLeastGoods(List<CashRegister> cashRegisters) {
		cashRegisters.Sort((l, r) => l.GoodsNumber().CompareTo(r.GoodsNumber()));
		return cashRegisters[0];
	}
}