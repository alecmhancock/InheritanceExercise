using System;
namespace Inheritance
{
	public class Bird : Animal
	{
		public Bird()
		{
			HasHair = false;
			EatsMeat = true;
			NumberOfEyes = 2;
			NumberOfLegs = 2;
		}

		public bool CanFly { get; set; }
		public bool IsLarge { get; set; }
		public string Color { get; set; }
		public int AverageAge { get; set; }


	}
}

