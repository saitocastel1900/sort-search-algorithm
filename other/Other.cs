using System;

namespace sort_search_algorithm.other
{
    public static class Other
    {
        /// <summary>
        /// FizzBuzzを求める
        /// </summary>
        public static  string FizzBuzz(int x)
        {
            if (x %15== 0) return "Fizz Buzz"; 
            else if (x % 3 == 0) return "Fizz";
            else if (x % 5 == 0) return "Buzz";
            
            return x.ToString();
        }
        

        /// <summary>
        /// 受け取った値をまとめて表示する
        /// </summary>
        /// <param name="x">コレクションな真偽値</param>
        public static void DebugLog(this bool[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i])    
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void DebugLog(this int x)
        {
            Console.Write(x);
        }
        public static void DebugLog(this int[] x)
        {
            foreach (var _x in x)
            {
                Console.WriteLine(_x);
            }
        }

        /// <summary>
        /// 互いの値を入れ替える
        /// </summary>
        /// <param name="a">入れ替えたい値</param>
        /// <param name="b">入れ替えたい値</param>
        public static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
        
    }
    /// <summary>
    /// 複素数
    /// </summary>
    public class Complex
    {
        private float re;
        private float im;
        static Complex Mul(Complex z0,Complex z1)
        {
            return new Complex()
            {

            };

        }
    }
}