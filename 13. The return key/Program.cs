using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.The_return_key
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Cube(5));
            Cube(5);
            Console.ReadLine();
        }
        static int Cube(int number)
        {

            int result = number * number * number;
            return result;
        }
    }
}      
