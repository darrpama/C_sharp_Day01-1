public class Customer {
	private int id_;
	private string? name_;

	public int Id {
		get => id_;
		set => id_ = value;
	}

	public string? Name {
		get => name_;
		set => name_ = value;
	}

	public override string ToString() {
		return (Name != null) ? $"{Name} customer #{Id}" : "Unknown customer";
	}

	public static bool operator ==(Customer c1, Customer c2) {
		return ((c1.Id == c2.Id) && (c1.Name == c2.Name));
	}

	public static bool operator !=(Customer c1, Customer c2) {
		return ((c1.Id != c2.Id) || (c1.Name != c2.Name));
	}

	public bool Equals(Customer other) {
		return ((this.Id == other.Id) && (this.Name == other.Name));
	}

	public override bool Equals(object? obj) {
		if (obj == null || GetType() != obj.GetType()) {
			return false;
		}
		Customer other = (Customer)obj;
		return this.Equals(other);
	}

	public override int GetHashCode() {
		return HashCode.Combine(Id, Name);
	}

	public Customer(string name, int id) {
		Id = id;
		Name = name;
	}

}