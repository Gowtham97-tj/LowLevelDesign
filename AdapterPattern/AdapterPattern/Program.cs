﻿using System;

namespace AdapterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sparrow sparrow = new Sparrow();
            IToyDuck toyDuck = new PlasticToyDuck();

            IToyDuck birdAdapter = new BirdAdapter(sparrow);

            Console.WriteLine("Sparrow...");
            sparrow.fly();
            sparrow.makeSound();

            Console.WriteLine("ToyDuck...");
            toyDuck.squeak();

            // toy duck behaving like a bird
            Console.WriteLine("BirdAdapter...");
            birdAdapter.squeak();
        }
    }
}
