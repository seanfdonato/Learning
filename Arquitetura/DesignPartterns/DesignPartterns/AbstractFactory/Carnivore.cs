using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPartterns.AbstractFactory
{
    abstract class Carnivore
    {
        public abstract void Eat(Herbivore h);
    }
}
