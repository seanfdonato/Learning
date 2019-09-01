using DesignPartterns.Adapter.Adapter;
using DesignPartterns.Adapter.Target;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPartterns.Adapter
{
    /// <summary>
    /// MainApp startup class for Real-World 
    /// Adapter Design Pattern.
    /// </summary>
    public static class AdapterStartup
    {
        public static void Start()
        {
            // Non-adapted chemical compound
            Compound unknown = new Compound("Unknown");
            unknown.Display();

            // Adapted chemical compounds
            Compound water = new RichCompound("Water");
            water.Display();

            Compound benzene = new RichCompound("Benzene");
            benzene.Display();

            Compound ethanol = new RichCompound("Ethanol");
            ethanol.Display();

            // Wait for user
            Console.ReadKey();
        }
    }

}
