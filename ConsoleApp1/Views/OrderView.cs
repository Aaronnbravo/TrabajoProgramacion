using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Views
{
    public class OrderView
    {
        public static void ShowMag(string msg)
        {
            Console.WriteLine($"{msg}");
        }
        public static void setColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }

        public static void resetColor()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
