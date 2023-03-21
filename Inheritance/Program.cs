using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var pigeon = new Bird()
            {
                CanFly = true,
                AverageAge = 6,
                IsLarge = false,
                Color = "Gray",

            };

            ///////////////////////////////////////////


            Console.WriteLine($"Today we'll be learning about the pigeon. \n" +
                $"What topic would you like to hear about first? \n" +
                $"\n" +
                $"Flight \n" +
                $"Lifespan \n" +
                $"Size \n" +
                $"Color \n" +
                $"");

            var userInput = Console.ReadLine();
            switch (userInput)
            {
                case "Flight":
                    Console.WriteLine($"The fact that the pigeon can fly is {pigeon.CanFly}.");
                    break;

                case "Lifespan":
                    Console.WriteLine($"The average age of a pigeon is {pigeon.AverageAge}.");
                    break;

                case "Color":
                    Console.WriteLine($"The color of an average pigeon is {pigeon.Color}.");
                    break;

                case "Size":
                    Console.WriteLine($"The average age of a pigeon is {pigeon.AverageAge} years of age.");
                    break;


            }
            //////////////////////////////////////////

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var rattlesnake = new Reptile()
            {

                IsVenomous = true,
                NumberOfScales = 600,
                MethodOfTransport = "Slithering around on the ground",
                HasEars = false,

            };

            Console.WriteLine("\n");

            Console.WriteLine($"We'll also be learning about the rattlesnake. \n" +
               $"What topic would you like to hear about first? \n" +
               $"\n" +
               $"Danger \n" +
               $"Average Scale count \n" +
               $"How do they get around \n" +
               $"Do they have ears \n" +
               $"");

            var userInput2 = Console.ReadLine();
            switch (userInput2)
            {
                case "Danger":
                    Console.WriteLine($"The fact that the rattlesnake is venomous is {rattlesnake.IsVenomous}, \n" +
                        $"and they should be given space so as not to startle them.");
                    break;

                case "Average Scale count":
                    Console.WriteLine($"The average scale count of a rattlesnake is {rattlesnake.NumberOfScales}.");
                    break;

                case "How do they get around":
                    Console.WriteLine($"The primary form of transportation for a rattlesnake is {rattlesnake.MethodOfTransport}.");
                    break;

                case "Do they have ears":
                    Console.WriteLine($"The myth that rattlesnakes have some kind of ear is {rattlesnake.HasEars}.");
                    break;


            }









        }
    }
}
