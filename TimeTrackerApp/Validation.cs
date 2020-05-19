using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TimeTrackerApp
{
    class Validation
    {
        public static void ValidateInsertion()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Activity Saved To The Database!");
            Console.ResetColor();
        }
    }
}
