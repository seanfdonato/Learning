using DesignPartterns.AbstractFactory;
using DesignPartterns.Adapter;
using DesignPartterns.Command;
using DesignPartterns.Facade;
using DesignPartterns.FactoryMethod;
using DesignPartterns.Singleton;
using DesignPartterns.StructuralPatterns.Composite;
using System;

namespace DesignPartterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //AbstractFactoryStartup.Start();
            //FactoryMethodStartup.Start();
            //SingletonStartup.Start();
            //AdapterStartup.Start();
            //FacadeStartup.Start();
            CompositeStartup.Start();
            CommandStartup.Start();
            Console.WriteLine("Hello World!");
        }
    }
}
