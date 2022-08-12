using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Test0810
{
    internal class test2
    {
        static void Main(string[] args)
        {
            string[] dir = Directory.GetDirectories("C:\\_Temp");
            var finfoArr = new List<FileInfo>();
            foreach (var elem in dir)
            {
                string[] file = Directory.GetFiles(elem);
                
                foreach (var f in file)
                {
                    FileInfo filedetail = new FileInfo(f);
                    finfoArr.Add(filedetail);
                    
                }                
            }
            foreach (var item in finfoArr)
            {
                Console.WriteLine($"{item.CreationTime.ToString()}, {item.FullName}, {item.Extension}");
            }
            
        }
    }
}
