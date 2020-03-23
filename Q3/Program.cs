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

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            double  Divide1 =  Divide(20, 3);
            Console.WriteLine(Divide1);
        }
        static double Divide(double a, double b)
        {
            double answer = Math.Round((a /  b), 3);
            return answer; 
        }
    }
}
