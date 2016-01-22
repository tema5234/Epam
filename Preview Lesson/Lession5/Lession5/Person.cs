namespace Lession5
{
	public class Person
	{
		#region Properties
		public int id { get; set; }
		public string surname { get; set; }
		public string name { get; set; }
		public int age { get; set; }
		public string phoneNumber { get; set; }

		#endregion

		#region Constructors
		public Person()
		{
			id = 0;
			surname = "Unknown";
			name = "Unknown";
			age = 0;
			phoneNumber = "000-00-00";
		}

		public Person(int id, string surname, string name, int age, string phoneNumber)
		{
			this.id = id;
			this.surname = surname;
			this.name = name;
			this.age = age;
			this.phoneNumber = phoneNumber;
		}
		#endregion

		#region Public methods
		public override string ToString()
		{
			string id_ = id.ToString();
			string age_ = age.ToString();
			return ("Worker " + id_ + ": " + surname + " " + name + " (" + age_ + " years old) /phone: " + phoneNumber);
		}
		#endregion
	}
}
