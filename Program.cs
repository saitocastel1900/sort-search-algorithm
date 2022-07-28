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
            #region XOR

            var test1 = new Encryption.Data("hello","22562226");
            
            var _data = Encryption.Xor(test1.value,test1.key);
            
            Console.WriteLine(Encryption.Byte.Decode(_data));
            
            _data = Encryption.Xor(_data,test1.key);
            Console.WriteLine(Encryption.Byte.Decode(_data));
            
            #endregion

            #region AES
            /*
            var Data = new Encryption.Data("Hello World!","1011010111","hogehogehoge");
                        //暗号文
                        var encrypted = Encryption.Aes.Encryption(Data.data,192,128,Data.salt,Data.pw);
                        //64種類の英数字で表現
                        Console.WriteLine(System.Convert.ToBase64String(encrypted));
                        Console.WriteLine(encryption.Encryption.Byte.Decode(encrypted));
                        
                        var dencrypted = Encryption.Aes.Decrypt(Data.data,192,128,Data.salt,Data.pw,encrypted);
                        //平文
                        Console.WriteLine(System.Convert.ToBase64String(dencrypted));
                        Console.WriteLine(encryption.Encryption.Byte.Decode(dencrypted));
            */
            #endregion
            
            
        }
    }
}