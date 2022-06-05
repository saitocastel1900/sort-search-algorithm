using System;
using sort_search_algorithm.decision;
using sort_search_algorithm.other;
using sort_search_algorithm.search;

namespace sort_search_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new int[] { 1,2,3,4,5,6,7,8,9,10};
            Serch.BinarySearch(s,5,0,s.Length).DebugLog();

            //Console.WriteLine("Hello World!");
        }
    }
}