using System;
using System.Collections.Generic;
using System.Text;

namespace PluralSightTest
{
    public class FileProcess
    {
        public bool FileExists(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return false;

            }

            return true;

        }
    }
}
