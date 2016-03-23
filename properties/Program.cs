using System;

namespace properties
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Employee e = new Employee ();
			e.FirstName = "Leandro";
			e.LastName = "Cerencio";
			e.Title = "Mr.";

			Employee b = new Employee ("Tsushima", "Momoko")
			{ Title = "Mrs." };

			e.Manager = b;

			Console.WriteLine ("Hello World! " + e);
			Console.WriteLine (b);
		}
	}

	class Employee
	{
		public Employee () {
			Id = NextId++;
		}

		public Employee (string firstName, string lastName)
			: this ()
		{
			_FirstName = firstName;
			_LastName = lastName;
		}

		public string FirstName {
			get {
				return _FirstName;
			}
			set {
				_FirstName = value;
			}
		}
		private string _FirstName;

		public string LastName {
			get {
				return _LastName;
			}
			set {
				_LastName = value;
			}
		}
		private string _LastName;

		public uint Id { get; set; }

		public string Title { get; set; }

		public Employee Manager { get; set; }

		public String Salary { get; set; } = "Not Enough";

		public override string ToString() {
			return $"{ Id } - { Title } { _LastName }, { _FirstName }";
		}

		public static uint NextId = 1;
	}
}
