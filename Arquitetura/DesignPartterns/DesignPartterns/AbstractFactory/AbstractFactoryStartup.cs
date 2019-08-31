using DesignPartterns.AbstractFactory.AbstractFactory;
using DesignPartterns.AbstractFactory.Client;
using DesignPartterns.AbstractFactory.ConcretFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPartterns.AbstractFactory
{
    /// <summary>
    /// MainApp startup class for Real-World
    /// Abstract Factory Design Pattern.
    /// </summary>

    public static class AbstractFactoryStartup
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>

        public static void Start()
        {
            // Create and run the African animal world
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            world.RunFoodChain();

            // Create and run the American animal world
            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();

            // Wait for user input
            Console.ReadKey();
        }
    }
}
