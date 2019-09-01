using DesignPartterns.AbstractFactory;
using DesignPartterns.Adapter;
using DesignPartterns.Facade;
using DesignPartterns.FactoryMethod;
using DesignPartterns.Singleton;
using System;

namespace DesignPartterns
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactoryStartup.Start();
            FactoryMethodStartup.Start();
            SingletonStartup.Start();
            AdapterStartup.Start();
            FacadeStartup.Start();
            Console.WriteLine("Hello World!");
        }
    }
}
