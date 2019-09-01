using System;

namespace DesignPartterns.Facade.Subsystem
{
    internal class Loan
    {
        /// <summary>
        /// The 'Subsystem ClassC' class
        /// </summary>
        public bool HasNoBadLoans(Customer c)
        {
            Console.WriteLine("Check loans for " + c.Name);
            return true;
        }
    }
}