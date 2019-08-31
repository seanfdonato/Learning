using DesignPartterns.AbstractFactory.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPartterns.AbstractFactory.AbstractFactory
{
    ///<sumary>
    ///The 'AbstractFactory' abstract class
    ///</sumary>
    public abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }
}
