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

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = Maximum(6,9);
            Console.WriteLine(answer);
        }
        static int Maximum(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else 
            {
                return b;
            }
        }
    }
}
