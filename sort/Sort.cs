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

        /// <summary>
        /// ヒープソート
        /// </summary>
        public static class Heap
        {
            public static int[] Sort(int[] array)
            {
                //ヒープに代入
                for (int i = 1; i < array.Length; i++) Push(array, i);

                //ヒープから持ってくる
                for (int i = array.Length - 1; i >= 0; i--) array[i] = Pop(array, i);

                return array;
            }

            /// <summary>
            /// コレクションをヒープに入れる(ヒープを作る)
            /// </summary>
            /// <param name="array"></param>
            /// <param name="n"></param>
            private static void Push(int[] array, int n)
            {
                while (n != 0)
                {
                    //親の要素数
                    int i = (n - 1) / 2;
                    //もじ親要素より大きい場合..
                    if (array[n].CompareTo(array[i]) > 0) Other.Swap(ref array[n], ref array[i]);
                    n = i;
                }
            }

            /// <summary>
            /// ヒープから最大値を順にコレクションへ出す
            /// </summary>
            /// <param name="array"></param>
            /// <param name="n"></param>
            /// <returns></returns>
            private static int Pop(int[] array, int n)
            {
                int max = array[0];
                array[0] = array[n];

                for (int i = 0, j; (j = 2 * i + 1) < n;)
                {
                    if ((j != n - 1) && (array[j].CompareTo(array[j + 1]) < 0)) j++;
                    if (array[i].CompareTo(array[j]) < 0) Other.Swap(ref array[i], ref array[j]);
                    i = j;
                }

                return max;
            }
        }
    }
}