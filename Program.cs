using System;
using sort_search_algorithm.decision;
using sort_search_algorithm.other;
using sort_search_algorithm.search;
using sort_search_algorithm.sort;

namespace sort_search_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new int[] {10, 2, 9, 1, 4, 5};
            
            Sort.Sellection(s).DebugLog();

            //Console.WriteLine("Hello World!");
        }
    }
}