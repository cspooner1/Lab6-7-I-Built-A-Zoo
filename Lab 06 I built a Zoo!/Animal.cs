using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab_06_I_built_a_Zoo_
{
    public abstract class Animal
    {
        public string name;
        public int size;
        public abstract void Move();
        public abstract void Eat();

        public virtual void Drink()
        {
            Console.Write("Drink");
        }

    }
}

