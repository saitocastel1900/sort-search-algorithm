using System;

namespace sort_search_algorithm.other
{
    public static class Other
    {
        /// <summary>
        /// 
        /// </summary>
        public static  void FizzBuzz(int x)
        {
        
        }
        public static  void FizzBuzz(double x)
        {
        
        }


        /// <summary>
        /// 受け取った値をまとめて表示する
        /// </summary>
        /// <param name="x"></param>
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
        
        
    }
}