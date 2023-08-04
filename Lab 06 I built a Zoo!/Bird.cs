﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06_I_built_a_Zoo_
{
    public abstract class Bird : Animal
    {
        public int wingSpan;
        public string speed;
        public string color;
        public override void Move()
        {
            Console.Write("Fly");
        }

        public override void Eat()
        {
            Console.Write("Bird eats worm");
        }

        public override void Drink()
        {
            Console.Write("Sip sip through beak;");
        }
    }
}

