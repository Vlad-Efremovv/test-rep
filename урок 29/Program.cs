using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace урок_29
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] data = { { 1, 2, 3, 4, 5 }
                , { 1, 2, 3, 4, 5}
                , { 1, 2, 3, 4, 5}};




            Console.WriteLine(data[1,3]);
        }
    }
}
