using DesignPartterns.AbstractFactory.AbstractFactory;
using DesignPartterns.AbstractFactory.AbstractProduct;
using DesignPartterns.AbstractFactory.ConcretProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPartterns.AbstractFactory.ConcretFactory
{
    /// <summary>
    /// The 'ConcreteFactory2' class
    /// </summary>
    public class AmericaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }
    }
}
