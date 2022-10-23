using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _作業_Exec_While_Q1____21謝孟勳
{
    internal class Program
    {
        //1+ 2 + 3 + 4 + .... + N <105
        //請問N是多少?
        static void Main(string[] args)
        {
            int number = 1;
            int sum = 0;
            while (true)
            { 
                sum += number;
                if (sum >= 105 )
                    break;
                number++;
            }
            Console.WriteLine(number-1);
        }
    }
}
