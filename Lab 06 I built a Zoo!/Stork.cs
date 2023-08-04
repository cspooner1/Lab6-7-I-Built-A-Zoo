using System;
namespace Lab_06_I_built_a_Zoo_
{
    public class Stork : Bird
    {
        public int beakSize;
        public int legs { get; set; }

        public Stork(string feathercolor)
        {
            color = feathercolor;
        }

        public void fly()
        {
            Console.Write("Kawkaw");
        }
    }
}

