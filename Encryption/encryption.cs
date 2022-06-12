using System.Security.Cryptography.X509Certificates;

namespace sort_search_algorithm.Encryption
{
    public static class encryption
    {
        public static class Xor
        {
            /// <summary>
            /// 暗号化
            /// </summary>
            /// <param name="text"></param>
            /// <returns></returns>
            public static byte[] Encode(string text)
             {
                 var result = System.Text.Encoding.UTF8.GetBytes(text);
                 return result;
             }
            
            /// <summary>
            /// 復号化
            /// </summary>
            /// <param name="textBytes"></param>
            /// <returns></returns>
            public static string Decode(byte[] textBytes)
            {
                var result = System.Text.Encoding.UTF8.GetString(textBytes);
                return result;
            }
            
        }
    }
    
    
}