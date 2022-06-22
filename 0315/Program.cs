using System;

namespace _0329
{
    class Program
    {
        static void SumAvg(int[] abc)
        {
            int sum = 0;
            for(int i = 0; i < abc.Length; i++)
            {
                sum += abc[i];
            }
            Console.WriteLine("합 : " + sum);
            Console.WriteLine("평균 : " + sum / abc.Length);
        }
        static void Main(string[] args)
        {
            int[] abc = { 1, 2, 3, 4, 5 };
            SumAvg(abc);
        }
    }
}
