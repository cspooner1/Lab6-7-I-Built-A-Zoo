using System;
namespace Lab_06_I_built_a_Zoo_
{
    public interface ISwims
    {
        public bool inWater { get; set; }
        public void Swim()
        {
            Console.WriteLine("Just keep swimming..");
        }
    }
}

