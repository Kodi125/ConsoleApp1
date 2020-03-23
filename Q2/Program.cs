/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date :
 * Description : basic C# math
 * 
 * ############################# */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            double AreaOfCircle = CircleArea(3.5);
            Console.WriteLine("The area of the circle is {0}", AreaOfCircle );

        }
        static double CircleArea(double radius)
        {
           double AreaOfCircle = ((Math.PI)*(radius)*(radius));
            double rounded = Math.Round(AreaOfCircle, 3);
            return rounded; 

        }
    }
}
