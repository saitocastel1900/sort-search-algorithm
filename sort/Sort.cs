using System.Threading;
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
        ////挿入ソート
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] InsertionSort(int[] array)
        {
            return array;
        }

        public static int[] HeapSort(int[] array)
        {
            return array;
        }

    }
}