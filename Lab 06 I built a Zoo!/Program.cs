using System;
namespace Lab_06_I_built_a_Zoo_;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Spooner's Spootastic Zoo!!");
        Wolf wolf = new Wolf("Black");
        Tiger tiger = new Tiger("White");
        Stork stork = new Stork("Blue");
        ClownFish clownfish = new ClownFish("10 cm");
        Falcon falcon = new Falcon("240 mph");

        Console.WriteLine($"Stork Feathercolor: {stork.color}");
        Console.WriteLine($"Tiger Stripecolor: {tiger.color}");
        Console.WriteLine($"Clownfish Gillsize: {clownfish.gillsize}");
        Console.WriteLine($"Wolf Furcolor: {wolf.color}");
        Console.WriteLine($"Falcon Speed: {falcon.speed}");
    }
}

