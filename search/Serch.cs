using System.Collections.Generic;

namespace sort_search_algorithm.search
{
    public static class Serch
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="array">ソート済みの配列</param>
        /// <param name="target">探している値</param>
        /// <returns>一致していたIndexを返す(該当無の場合は-1)</returns>
        public static int Linear(int[] array,int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(target)) return i;
            }
            return -1;
        }

        /// <summary>
        /// 二分探索(自作)
        /// </summary>
        /// <param name="array">ソート済みの配列</param>
        /// <param name="target">探している値</param>
        /// <param name="min">最小値</param>
        /// <param name="max">最大値</param>
        /// <returns>一致していたIndexを返す(該当無の場合は-1)</returns>
        public static int BinarySearch(int[] array, int target, int min, int max)
        {
            if (min > max) return -1;

            while (min > max)
            {
                //(min+max)/2オーバーフローすることがあるので使用していない
                int mid = min + (max - min) / 2;

                switch (target.CompareTo(array[mid]))
                {
                    //目的の値が中央値より小さい
                    case -1:
                        max = mid - 1;
                        break;
                    //目的の値が中央値と合致
                    case 0:
                        return mid;
                    //目的の値が中央値より大きい
                    case 1:
                        min = mid + 1;
                        break;
                }
            }

            return -1;
        }
        
    }
}