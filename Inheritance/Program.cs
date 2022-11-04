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
            var NewAnimal = new Animal();
            NewAnimal.IsNocturnal = true;
            NewAnimal.NumberOfLegs =4;
            NewAnimal.LivesOnLand = true;
            NewAnimal.IsSmall = true;

            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class
            var NewBird = new Bird();
            NewBird.CanFLy = true;
            NewBird.Color = "BLue";
            NewBird.BeakSize = 5;
            NewBird.IsSmall = true;

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class
            var NewReptile = new Reptile();
            NewReptile.IsNocturnal = false;
            NewReptile.IsSmall = false;
            NewReptile.LivesOnLand = true;
            NewReptile.CanSwim = true;



            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Console.WriteLine($"This new bird has a beak of {NewBird.BeakSize} inch. It is {NewBird.IsSmall} that it lives on land is {NewBird.Color}");
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Console.WriteLine($"Is this new repile nocturnal {NewReptile.IsNocturnal}. And it also {NewReptile.CanSwim} can swim well, its also {NewReptile.IsSmall} is small when its bigget than most");
        }
    }
}
