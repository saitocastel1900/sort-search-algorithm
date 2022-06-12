using System.Text;
using System.Security.Cryptography;

namespace sort_search_algorithm.encryption
{
    /// <summary>
    /// 暗号化
    /// </summary>
    public static class Encryption
    {
        public static void Aes()
        {
            
        }

        public static class Byte
        {
            /// <summary>
            /// Byteに変換
            /// </summary>
            /// <param name="text"></param>
            /// <returns></returns>
            public static byte[] Encode(string text)
            {
                var result = System.Text.Encoding.UTF8.GetBytes(text);
                return result;
            }

            /// <summary>
            /// Byetを文字列に変換
            /// </summary>
            /// <param name="textBytes"></param>
            /// <returns></returns>
            public static string Decode(byte[] textBytes)
            {
                var result = System.Text.Encoding.UTF8.GetString(textBytes);
                return result;
            }
        }

        /// <summary>
        /// XORでdataを暗号化
        /// </summary>
        /// <param name="data">暗号化したい値</param>
        /// <param name="key">鍵</param>
        /// <returns></returns>
        public static byte[] Xor(byte[] data, byte[] key)
        {
            int j = 0;
            for (int i = 0; i < data.Length; i++)
            {
                //Keyの要素数を上回るなら、0にしてKey[0]から再度XOR
                if (j > key.Length)
                {
                    j = 1;
                }
                else
                {
                    j++;
                }

                //xor
                data[i] = (byte) (data[i] ^ key[j - 1]);
            }

            return data;
        }
    }
}