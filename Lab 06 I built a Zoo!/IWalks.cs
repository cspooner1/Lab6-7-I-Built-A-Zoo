using System;
namespace Application
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

