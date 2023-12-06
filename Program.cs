using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_forLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lets make a traingle

            Console.Write("Enter a num:");
            int num=Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < num; i++) 
            {
                for (int j = 0; j <=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
