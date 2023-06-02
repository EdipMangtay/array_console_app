using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_console_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number :");
            int number = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[number + 1];
            array[0] = 0;
            array[1] = 1;
            for (int i = 2; i < number; i++)
            {
                array[i] = array[i - 1] + array[i - 2];

            }
            Console.WriteLine("Fibonacci calculation up to the entered value");
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();

        }
    }
}
