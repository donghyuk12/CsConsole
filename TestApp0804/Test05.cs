using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp0804
{
    //internal class MyClass
    //{
    //    public int myField1;
    //    public int myField2;
    //}
    //class instance
    //{
    //    static void Main(string[] args)
    //    {
    //        MyClass source = new MyClass();
    //        source.myField1 = 10;
    //        source.myField2 = 20;
    //        Console.WriteLine($"{source.myField1}, {source.myField2}");
    //        MyClass target = source;
    //        target.myField2 = 30;

    //        Console.WriteLine($"{target.myField1}, {target.myField2}");
    //    }
    //}
    //    class MyClass
    //    {
    //        public int myField1;
    //        public int myField2;

    //        //public MyClass deepCopy()
    //        //{
    //        //    MyClass newCopy = new MyClass();
    //        //    newCopy.myField1 = myField1;
    //        //    newCopy.myField2 = myField2;
    //        //    return newCopy;
    //        //}
    //    public void Dcopy(MyClass s)
    //    {

    //        s.myField1 = 10;
    //        s.myField2 = 20;

    //    }
    //    public void ShowCopy()
    //        {
    //            Console.WriteLine($"{myField1}, {myField2}");
    //        }

    //    }

    //    internal class Test05
    //    {
    //        static void Main(string[] args)
    //        {
    //            MyClass rclass = new MyClass();
    //            rclass.Dcopy(rclass);
    //            rclass.ShowCopy();
    //            //MyClass source = new MyClass();
    //            //source.myField1 = 1;
    //            //source.myField2 = 20;
    //            //MyClass target = source.deepCopy();
    //            //target.myField2 = 30;
    //            //Console.WriteLine($"{source.myField1}, {source.myField2}");
    //            //Console.WriteLine($"{target.myField1}, {target.myField2}");
    //        }
}

//} 
//using System;

//namespace Chap9_6
//{
//    class MyClass
//    {
//        public int myField1;
//        public int myField2;

//        public MyClass DeepCopy()
//        {
//            MyClass dcopy = new MyClass(); //source;
//            dcopy.myField1 = myField1;
//            dcopy.myField2 = myField2;
//            return dcopy;
//        }
//    }

//    class Program
//    {
//        static MyClass DeepCopy(MyClass source)
//        {
//            MyClass dcopy = new MyClass(); //source;
//            dcopy.myField1 = source.myField1;
//            dcopy.myField2 = source.myField2;
//            return dcopy;
//        }
//        static void Main(string[] args)
//        {
//            MyClass source = new MyClass();
//            source.myField1 = 100;
//            source.myField2 = 20;

//            MyClass target = source.DeepCopy();
//            target.myField2 = 50;

//            MyClass third = source.DeepCopy();

//            Console.WriteLine($"{source.myField1}, {source.myField2}");
//            Console.WriteLine($"{target.myField1}, {target.myField2}");
//        }
//    }
//}