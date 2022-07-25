namespace IntermediateII {
	public class ReferenceExample {
		public int Id { get; set; }
		public string Name { get; set; }
		public string Password { get; set; }
		
		public ReferenceExample(int id, string name, string pass) {
			Id = id;
			Name = name;
			Password = pass;
		}
	}
}