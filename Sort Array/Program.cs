using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] { 0,100,20,30,4,65,60,63,80,90};



            Array.Sort(array);

            PrintArray(array);
        }


        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadLine(); 
        }
    }
}
