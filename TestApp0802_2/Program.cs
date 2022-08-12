namespace TestApp0802_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int kor, eng, math;
            //a=int.Parse(Console.ReadLine());
            //Console.Write(a);
            //Console.Write(Convert.ToInt32(kor));
            Console.Write("국어 점수를 입력해주세요. >");
            kor = Convert.ToInt32(Console.ReadLine());

            Console.Write("영어 점수를 입력해주세요. >");
            eng = Convert.ToInt32(Console.ReadLine());

            Console.Write("수학 점수를 입력해주세요. >");
            math = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("국어 : {0}, 영어 : {1}, 수학 : {2}", kor, eng, math);
            int result = kor + eng + math;
            double avg = (double)result / 3;
            Console.WriteLine("총점 : {0}, 평균 : {1:f1}", result, avg);
        }
    }
}