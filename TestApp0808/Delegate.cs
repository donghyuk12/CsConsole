using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp0808
{
    internal class Delegate
    {
        delegate double p(double a, double b);
        delegate void print(string str);
        delegate string scan();
        delegate bool CondFunc(int num);
        
        static void Main(string[] args)
        {
            print printf = Console.Write;
            p pow = Math.Pow;
            scan scanf = Console.ReadLine;
            //printf("이름을 입력하세요: ");
            //scanf();
            CondFunc cond = (n) => { return n < 10; };
            Console.WriteLine(cond(14));
            
        }

        
      

        //    delegate int TypeF(int a, int b);
        //    static int Plus(int x, int y) { return x + y; }
        //    static int Minus(int x, int y) { return x - y; }
        //    static void Main(string[] args)
        //    {
        //        //TypeF delgateValue = new TypeF(Plus);
        //        //int result = delgateValue(20, 10);
        //        //Console.WriteLine(result);

        //        //TypeF delgateValue2 = Minus;
        //        //int result2 = delgateValue2(20, 10);
        //        //Console.WriteLine(result2);

        //        //delgateValue2 += Plus;
        //        //result2 += delgateValue2(20, 10);
        //        //Console.WriteLine(result2);

        //        TypeF delgateValue3 = Minus;
        //        int result3 = delgateValue3(20, 10);
        //       Console.WriteLine(result3);
        //        //delgateValue3 -= Minus;
        //        //delgateValue3 = Plus;
        //        //int result4 = delgateValue3(result3, 30);
        //        delgateValue3 += Plus;
        //        result3 += delgateValue3(20, 10);
        //        Console.WriteLine(result3);
        //    }
    
    }
}
