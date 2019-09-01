﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPartterns.Facade.Subsystem
{
    /// <summary>
    /// The 'Subsystem ClassB' class
    /// </summary>
    class Credit
    {
        public bool HasGoodCredit(Customer c)
        {
            Console.WriteLine("Check credit for " + c.Name);
            return true;
        }
    }
}