using System;

namespace DesignPartterns.Facade.Subsystem
{
    /// <summary>
    /// The 'Subsystem ClassA' class
    /// </summary>
    internal class Bank
    {
        public bool HasSufficientSavings(Customer c, int amount)
        {
            Console.WriteLine("Check bank for " + c.Name);
            return true;
        }
    }
}