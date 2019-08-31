using DesignPartterns.AbstractFactory.AbstractFactory;
using DesignPartterns.AbstractFactory.AbstractProduct;
using DesignPartterns.AbstractFactory.ConcretProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPartterns.AbstractFactory.ConcretFactory
{
    /// <summary>
    /// The 'ConcreteFactory1' class
    /// </summary>
    public class AfricaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }
    }
}
