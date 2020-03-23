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

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal averageOfNums = Average(5, 6, 7, 9);
            Console.WriteLine("The average is {0}", averageOfNums);

        }
        static decimal Average(int one, int two, int three, int four)
        {
            decimal average = (decimal)(one + two + three + four) / 4;
            decimal averageRounded = Math.Round(average, 1);
            return averageRounded; 
        }
    }
}
