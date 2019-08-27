using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public interface IInterfaces
    {
        void Test();
        int TestInt(int y);
    }

    class ExtendsInterfaces : IInterfaces
    {
        public void Test()
        {
            throw new NotImplementedException();
        }

        public int TestInt(int x)
        {
            throw new NotImplementedException();
        }
    }
}
