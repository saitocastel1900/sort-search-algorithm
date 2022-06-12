using System;
using System.Security.Cryptography;
using System.Text;
using sort_search_algorithm.decision;
using sort_search_algorithm.other;
using sort_search_algorithm.search;
using sort_search_algorithm.sort;
using sort_search_algorithm.encryption;
using Byte = sort_search_algorithm.encryption.Encryption;

namespace sort_search_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var s = new int[] {10, 2, 9, 1, 4, 5};
            //var n = new other.Complex();
            
            Sort.Heap.Sort(s).DebugLog();
            

            var test = "aaaasawdwasdwadwadasds";
            var key = "22562226";

            var data = Encryption.Byte.Encode(test);
            var bytekey = Encryption.Byte.Encode(key);
            data = Encryption.Xor(data,bytekey);
            
            foreach (var VARIABLE in data)
            {
                Console.WriteLine(VARIABLE);
            }
            
            data = Encryption.Xor(data,bytekey);
            Console.Write(Encryption.Byte.Decode(data));
            */
            var data = "uyrdyjctdrjc";
            var src = System.Text.Encoding.UTF8.GetBytes(data);
            
            RijndaelManaged rijndaelManaged = new RijndaelManaged();
            rijndaelManaged.KeySize = 128;
            rijndaelManaged.BlockSize = 128;
            
            string pw = "saito1011";
            string sait = "sait";

            byte[] bsait = Encoding.UTF8.GetBytes(sait);
            Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(pw, bsait);
            rfc2898DeriveBytes.IterationCount = 1000;

            rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
            rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);

            ICryptoTransform enCryptoTransform = rijndaelManaged.CreateEncryptor();
            byte[] encrBytes = enCryptoTransform.TransformFinalBlock(src,0,src.Length);
            foreach (var VARIABLE in encrBytes)
            {
                Console.Write(VARIABLE);
            }
            

            //Console.WriteLine("Hello World!");
        }
    }
}