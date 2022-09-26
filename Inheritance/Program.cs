using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var MyBird = new Bird();
            {
            MyBird.IsPredator = true;
            MyBird.CanFly = true;
            MyBird.DoesMigrate = false;
            MyBird.WingColor = "brown";
            }


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var MyReptile = new Reptile();
            {
            MyReptile.HasLimbs = true;
            MyReptile.CanSwim = true;
            MyReptile.Habitat = "land & water";
            MyReptile.HasScales = true;
            }
            var myAnimals = new Animal[] { MyBird, MyReptile };

            foreach (var animal in myAnimals)
            {
                Console.WriteLine($"CLue 1: This animal is alive: {animal.IsAlive}");
                Console.WriteLine($"CLue 2: This animal is: {animal.TypeOfFood}");
                Console.WriteLine($"CLue 3: This animal moves by: {animal.HowItMoves}");
                Console.WriteLine($"CLue 4: This animal has: {animal.SkinType}");
            }
        }
    }
}
