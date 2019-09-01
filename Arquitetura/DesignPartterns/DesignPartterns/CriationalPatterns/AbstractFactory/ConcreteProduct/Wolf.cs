using DesignPartterns.AbstractFactory.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPartterns.AbstractFactory.ConcretProduct
{
    /// <summary>
    /// The 'ProductB2' class
    /// </summary>
    public class Wolf : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            Console.WriteLine(this.GetType().Name +
                   " eats " + h.GetType().Name);
        }
    }
}
