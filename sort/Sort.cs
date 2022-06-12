using System.Runtime.InteropServices;
using System.Threading;
using System;
using sort_search_algorithm.other;

namespace sort_search_algorithm.sort

{
    public static class Sort

    {
        /// <summary>
        /// 選択ソート
        /// </summary>
        /// <param name="array">ソートしたい配列</param>
        /// <returns>ソートした配列</returns>
        public static int[] Sellection(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    //全検索で最小値を見つける
                    if (array[min].CompareTo(array[j]) == 1) min = j;
                }

                Other.Swap(ref array[min], ref array[i]);
            }

            return array;
        }

        /// <summary>
        /// バブルソート
        /// </summary>
        /// <param name="array">ソートしたい配列</param>
        /// <returns>ソートした配列</returns>
        public static int[] Bubble(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        Other.Swap(ref array[i], ref array[j]);
                    }
                }
            }

            return array;
        }


        /// <summary>
        /// 挿入ソート
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] Insertion(int[] array)
        {
            // [0]<[i] ...
            for (int i = 1; i < array.Length; i++)
            {
                var a = array[i];
                var k = i;

                //後ろの値と比較して値が大きければ...(array[0]とは最初だけしか比較しない)
                while (k >= 1 && a < array[k - 1])
                {
                    Other.Swap(ref array[k], ref array[k - 1]);
                    k--;
                }
            }

            return array;
        }

        public static class Heap
        {
            public static int[] Sort(int[] array)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    Push(array, i);
                }
                Console.WriteLine(string.Join(",", array));

                for (int i = array.Length - 1; i >= 0; i--)
                {
                    array[i] = Pop(array, i);
                }
                Console.WriteLine(string.Join(",", array));
                
                return array;
            }

            /// <summary>
            /// コレクションをヒープに入れる(ヒープを作る)
            /// </summary>
            private static void Push(int[] array,int n)
            {
            }

            /// <summary>
            /// ヒープから最大値を順にコレクションへ出す
            /// </summary>
            private static int Pop(int[] array,int n)
            {

                return array[n];
            }
        }
    }
}