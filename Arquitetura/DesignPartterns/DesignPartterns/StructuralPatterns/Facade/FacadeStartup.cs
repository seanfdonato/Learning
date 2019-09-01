using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPartterns.Facade
{
    public class FacadeStartup
    {
        /// <summary>
        /// MainApp startup class for Real-World 
        /// Facade Design Pattern.
        /// </summary>
        public static void Start()
        {
            // Facade
            Mortgage mortgage = new Mortgage();

            // Evaluate mortgage eligibility for customer
            Customer customer = new Customer("Ann McKinsey");
            bool eligible = mortgage.IsEligible(customer, 125000);
            Console.WriteLine("\n" + customer.Name +
                " has been " + (eligible ? "Approved" : "Rejected"));

            // Wait for user

            Console.ReadKey();
        }
    }
}
