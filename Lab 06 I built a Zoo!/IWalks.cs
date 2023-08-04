using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab_06_I_built_a_Zoo_
{
    public interface IWalks
    {
        public int legs { get; set; }
        public void Walk()
        {
            Console.WriteLine("Walking...");
        }
    }
}

