using System;
namespace Lab_06_I_built_a_Zoo_
{
    public abstract class Bird : Animal
    {
        public int wingSpan;
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

