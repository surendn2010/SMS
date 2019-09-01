using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Darray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myarray = new int[3, 4] { { 1, 2, 3, 4 }, { 8, 5, 6, 7 }, { 9, 10, 11, 12 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine(myarray[i,j]);
                }
            }
            Console.ReadLine();
        }
    }
}
