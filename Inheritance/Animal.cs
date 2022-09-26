using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Animal
    {
        public Animal()
        {

        }
        // Create a class Animal
        // give this class 4 members that all Animals have in common
        public bool IsAlive { get; set; }
        public string TypeOfFood { get; set; }
        public string HowItMoves { get; set; }
        public string SkinType { get; set; }

    }
}
