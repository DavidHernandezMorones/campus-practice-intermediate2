namespace IntermediateII {
	public struct ValueExample {
		public int Id { get; set; }
		public string Name { get; set; }
		public string Password { get; set; }

		public ValueExample(int id, string name, string pass) {
			Id = id;
			Name = name;
			Password = pass;
		}
	}
}