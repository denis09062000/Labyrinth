using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            double sum = 0;
            for (int y = 1; y <= n; y++)
            {
                sum += 1 / y;
            }

            //Console.Write(sum);

            Console.Write(sizeof(double));
        }
    }
}
