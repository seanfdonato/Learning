using OOP;
using System;
using System.Collections.Generic;
using System.Text;


namespace Encapsulation
{
    class PrivateProtected : Public
    {
        public PrivateProtected()
        {
            // Is accessible because is inherited. The protected access level allow it
            MethodProtectedInternal();
            //Can not be invoqued because is restricted to assembly
            //MethodProtectedPrivate();
        }
    }
}
