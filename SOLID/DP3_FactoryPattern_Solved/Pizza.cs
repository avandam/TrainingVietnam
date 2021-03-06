﻿using System;

namespace DP3_FactoryPattern_Solved
{
    enum PizzaType
    {
        Cheese,
        Clam,
        Pepperoni, 
        Vegetarian
    }

    abstract class Pizza
    {
        public virtual void Prepare()
        {
            Console.WriteLine("Standard preparation technique.");
        }

        public virtual void Bake()
        {
            Console.WriteLine("Standard baking technique.");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Standard cutting technique.");
        }

        public virtual void Box()
        {
            Console.WriteLine("Standard boxing technique.");
        }
    }
}
