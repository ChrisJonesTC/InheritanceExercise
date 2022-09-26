using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            IsAlive = true;
            TypeOfFood = "carnivore";
            HowItMoves = "flying";
            SkinType = "feathers";
        }
        // Create a class Bird
        // give this class 4 members that are specific to Bird
        // Set this class to inherit from your Animal Class
        public bool IsPredator { get; set; }
        public bool CanFly { get; set; }
        public bool DoesMigrate { get; set; }
        public string WingColor { get; set; }


    }


}
