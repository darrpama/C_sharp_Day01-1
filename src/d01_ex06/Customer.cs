using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

public class Customer
{
	public Customer(string name, int id) {
		Id = id;
		Name = name;
	}

	public int Id
	{
		get;
		set;
	}

	public string? Name
	{
		get;
		set;
	}

	public void FillCart(int max_capacity) {
		Random rnd = new();
		NumberOfGoods = rnd.Next(1, max_capacity);
	}

    public override string ToString() {
		return (Name != null) ? $"{Name}, customer #{Id} ({NumberOfGoods} items in cart)" : "Unknown customer";
	}

	public static bool operator ==(Customer c1, Customer c2) {
		return ((c1.Id == c2.Id) && (c1.Name == c2.Name));
	}

	public static bool operator !=(Customer c1, Customer c2) {
		return ((c1.Id != c2.Id) || (c1.Name != c2.Name));
	}

	public bool Equals(Customer other) {
		if (other == null!) {
			return false;
		}
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

	public int NumberOfGoods { get; set; }
}