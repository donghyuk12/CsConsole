using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp0805
{
    internal class ArraySort
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 1, 3, 2, 5 };
            
            Array.Sort(arr);
            foreach (var elem in arr)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine();
            Array.Reverse(arr);
            foreach (var elem in arr)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine();
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            } 
        }
    }
}
