using System;
namespace Lab_06_I_built_a_Zoo_
{
    public abstract class Fish : Animal
    {
        public string gillsize;
        public string stripeColor;
        public override void Move()
        {
            Console.Write("Walk");
        }

        public override void Eat()
        {
            Console.Write("Mammal eats meat");
        }
    }
}

