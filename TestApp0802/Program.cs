namespace TestApp0802
{
    public struct MyStruct
    {
        public const float PI = 3.14159f;
        public static int age = 27;
        public int val;
        public MyStruct()
        {
            val = 30;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("{0}, {1}", MyStruct.PI, MyStruct.age);
            //MyStruct s = new MyStruct();
            //s.val = 30;
            //MyStruct my1 = s;
            //Console.WriteLine(my1.val);
            //my1.val = 99;
            //Console.WriteLine(my1.val);
            //Console.WriteLine(s.val);
            Console.ReadKey();
        }

  
    }
}