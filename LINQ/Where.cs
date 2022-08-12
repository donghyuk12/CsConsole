using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Where
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var output = from elem in list
                         select elem * elem;
            //foreach (var item in output)    
            //{
            //    Console.WriteLine(item);
            //}
            var temp2 = from elem in list
                        where elem % 2 == 0
                        select new { Evem = elem, Multi = elem * 2, Pow = elem * elem };
            foreach (var item in temp2)
            {
                Console.WriteLine(item.Pow);
            }
        }
    }
}
