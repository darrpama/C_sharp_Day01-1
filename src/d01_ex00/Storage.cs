public class Storage {
	private int numberOfGoods;

	public Storage(int capacity) {
		numberOfGoods = capacity;
	}

	public bool IsEmpty() => numberOfGoods == 0;
}