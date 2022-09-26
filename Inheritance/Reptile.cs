using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            IsAlive = true;
            TypeOfFood = "carnivore";
            HowItMoves = "swimming";
            SkinType = "scales";
        }
        // Create a class Reptile
        // give this class 4 members that are specific to Reptile
        // Set this class to inherit from your Animal Class
        public bool HasLimbs { get; set; }
        public bool CanSwim { get; set; }
        public string Habitat { get; set; }
        public bool HasScales { get; set; }

        
    }
}
