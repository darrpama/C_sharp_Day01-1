public class Storage {
	public int NumberOfGoods { get; set; }

	public Storage(int capacity) {
		NumberOfGoods = capacity;
	}

	public bool IsEmpty() => NumberOfGoods == 0;
}