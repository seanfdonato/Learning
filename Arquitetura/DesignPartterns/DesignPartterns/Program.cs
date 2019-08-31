using DesignPartterns.AbstractFactory;
using DesignPartterns.FactoryMethod;
using System;

namespace DesignPartterns
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactoryStartup.Start();
            FactoryMethodStartup.Start();
            Console.WriteLine("Hello World!");
        }
    }
}
