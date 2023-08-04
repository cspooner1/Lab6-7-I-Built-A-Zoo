using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab_06_I_built_a_Zoo_
{
    public class Wolf : Mammal, IWalks
    {
        public int legs { get; set; }
        public string furColor;

        public Wolf(string furColor)
        {
            color = furColor;
        }
    }
}

