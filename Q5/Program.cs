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

namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = Multiply(6,4);
        }
        static int Multiply(int a, int b)
        {
        int answer = a * b;
        return answer; 
        }
    }
}
