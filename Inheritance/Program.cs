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
            Bird b = new Bird("roof", 3, "hello polly", "red");
            Console.WriteLine($"{b.Name},{b.Sound},{b.FavoriteRoostingPlace},{b.BeakSize},{b.FavoriteWord},{b.FavoriteFood},{b.FeatherColor},{b.NumberOfLegs},{b.Name}");
            Reptile r = new Reptile("1000", "roach", "dish", 4);
            Console.WriteLine($"{r.Sound},{r.Name},{r.NumberOfLegs},{r.NumberOfEyes},{r.NumberOfScales},{r.FavoriteBug},{r.FavoriteFood},{r.FavoriteSpot}");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
