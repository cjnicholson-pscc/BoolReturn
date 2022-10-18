using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolReturn
{
    internal class Program
    {
        // demostrates what I was talking about in class
        // just return the condition
        static bool IsEven(int x, int y)
        {
            return x % 2 == 0 && y % 2 == 0;
        }

        static void Main(string[] args)
        {
            // prompt user for two integers
            // assume correct input for user, can crash on non-ints
            Console.Write("Enter a value for x: ");
            int x = Convert.ToInt32(Console.ReadLine());    

            Console.Write("Enter a value for y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            // print out the result
            Console.WriteLine("Is is " + IsEven(x, y).ToString().ToLower() +
                              " that x and y are both even.");

            // kludge to keep the window open because I don't
            // feel like explaining keeping consoles open by
            // using debug mode etc.
            Console.ReadLine();

        }
    }
}
