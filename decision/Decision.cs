namespace sort_search_algorithm.decision
{
    public class Decision
    {
        /// <summary>
        /// 素数探索
        /// </summary>
        public static bool IsPrimeInt(int x)
        {
            if (x < 2) return false;
            else if (x == 2) return true;
            else if (x % 2 == 0) return false;

            for (int i = 3; i <= x; i++)
            {
                if (x % i == 0) return false;
            }

            return true;
        }
    }
}