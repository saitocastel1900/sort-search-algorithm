using System;
using sort_search_algorithm.decision;
using sort_search_algorithm.other;
using sort_search_algorithm.search;
using sort_search_algorithm.sort;
using sort_search_algorithm.Encryption;

namespace sort_search_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new int[] {10, 2, 9, 1, 4, 5};
            //var n = new other.Complex();
            
            Sort.Heap.Sort(s).DebugLog();
            

            var test = "aaaa";
            var data =encryption.Xor.Encode(test);
            foreach (var VARIABLE in data)
            {
                Console.WriteLine(VARIABLE);
            }
            Console.Write(encryption.Xor.Decode(data));


            //Console.WriteLine("Hello World!");
        }
    }
}