using System;
namespace Inheritance
{
	public class Reptile : Animal
	{
		public Reptile()
		{
			HasHair = false;
			EatsMeat = true;
			NumberOfEyes = 2;
		}

		public bool IsVenomous { get; set; }
		public int NumberOfScales { get; set; }
		public bool HasEars { get; set; }
		public string MethodOfTransport { get; set; }

	}

}

