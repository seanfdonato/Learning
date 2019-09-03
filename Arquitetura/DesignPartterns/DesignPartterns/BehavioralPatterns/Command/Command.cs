using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPartterns.Command
{
    /// <summary>
    /// The 'Command' abstract class
    /// </summary>
    abstract class Command
    {
        public abstract void Execute();
        public abstract void UnExecute();
    }
}