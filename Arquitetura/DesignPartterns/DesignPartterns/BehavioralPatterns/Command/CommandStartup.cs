using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPartterns.Command
{
    /// <summary>
    /// MainApp startup class for Real-World 
    /// Command Design Pattern.
    /// </summary>
    public class CommandStartup
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public static void Start()
        {
            // Create user and let her compute
            User user = new User();
            // User presses calculator buttons
            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);

            // Undo 4 commands
            user.Undo(4);

            // Redo 3 commands
            user.Redo(3);

            // Wait for user
            Console.ReadKey();
        }
    }
}
