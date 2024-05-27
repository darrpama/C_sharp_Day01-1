public class CashRegister
{
	public CashRegister(string name) {
		Name = name;
	}

	public string? Name
	{
		get;
		set;
	}

	public override string ToString() {
		return (Name != null) ? $"{Name}" : "Unknown cash register";
	}

	public Queue<Customer> customers = new Queue<Customer>();

	public int GoodsNumber() {
		int goodsInRegister = 0;
		foreach (var customer in customers) {
			goodsInRegister += customer.NumberOfGoods;
		}
		return goodsInRegister;
	}

	public static bool operator ==(CashRegister cr1, CashRegister cr2) {
		return (cr1.Name == cr2.Name);
	}

	public static bool operator !=(CashRegister cr1, CashRegister cr2) {
		return (cr1.Name != cr2.Name);
	}

	public bool Equals(CashRegister other) {
		if (other == null!) {
			return false;
		}
		return (this.Name == other.Name);
	}

	public override bool Equals(object? obj) {
		if (obj == null || GetType() != obj.GetType()) {
			return false;
		}
		CashRegister other = (CashRegister)obj;
		return this.Equals(other);
	}

	public override int GetHashCode() {
		return Name?.GetHashCode() ?? 0;
	}
}