using System;
namespace Lab_06_I_built_a_Zoo_
{
    public class ClownFish : Fish, ISwims
    {
        public bool inWater { get; set; }

        public ClownFish(string gillSize)
        {
            gillsize = gillSize;
        }
    }

}

