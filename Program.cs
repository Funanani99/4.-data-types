using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.data_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaration
            string name = "John";
            int age = 35;
            bool isTall = false;
            double weight = 80.2;

            Console.WriteLine(name  + " is " + age + " he weights " + weight);
            Console.WriteLine("it is " + isTall + " that he is tall.");

            //freeze console
            Console.ReadLine(); 
        }
    }
}
