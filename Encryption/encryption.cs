using System.Dynamic;
using System.Text;
using System.Security.Cryptography;

namespace sort_search_algorithm.encryption
{
    /// <summary>
    /// 暗号化
    /// </summary>
    public static class Encryption
    {
        public class Data
        {
            public string value { get; } 
            public string key { get; }
            public string pw { get; } 
            public string salt { get; } 
            /// <summary>
            /// バイト変換済みデータ
            /// </summary>
            public byte[] src { get; }

            public Data(string _value="Hello World!",string _key="hoge",string _pw="Hoge",string _salt = "HogeHogeHogeHoge")
            {
                this.value = _value;
                this.key = _key;
                this.pw = _pw;
                this.salt = _salt;
                this.src = Byte.Encode(value);
            }
        }

        public  static class Byte
        {
            /// <summary>
            /// Byteに変換
            /// </summary>
            /// <param name="text">Byteに変換したい文</param>
            /// <returns></returns>
            public static byte[] Encode(string text)
            {
                var result = System.Text.Encoding.UTF8.GetBytes(text);
                return result;
            }
            public static byte[] Encode(char text)
            {
                var result = System.Text.Encoding.UTF8.GetBytes(text.ToString());
                return result;
            }

            /// <summary>
            /// Byteを文字列に変換
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
        public static byte[] Xor(string _data, string _key)
        {
            byte[] data = Byte.Encode(_data);
            byte[] key = Byte.Encode(_key);
                
            int j = 0;
            for (int i = 0; i < data.Length; i++)
            {
                //Keyの要素数を上回るなら、0にしてKey[0]から再度XOR
                if (j >= key.Length)
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
        public static byte[] Xor(byte[] data, string _key)
        {
            byte[] key = Byte.Encode(_key);
                
            int j = 0;
            for (int i = 0; i < data.Length; i++)
            {
                //Keyの要素数を上回るなら、0にしてKey[0]から再度XOR
                if (j >= key.Length)
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

        
        /// <summary>
        /// AES暗号化を行う
        /// </summary>
        public static class Aes
        {
            /// <summary>
            /// AESで暗号化する
            /// </summary>
            /// <param name="text">暗号化したい文</param>
            /// <param name="KeySize">鍵長さ(128.192,256のいづれか)</param>
            /// <param name="BlockSize">ブロック長さ(128で固定)</param>
            /// <param name="salt">パスワードと混ぜてハッシュ化されるソルト</param>
            /// <param name="pw">ソルトと混ぜてハッシュ化されるパスワード</param>
            /// <param name="count">ハッシュ化する回数</param>
            /// <returns>暗号文</returns>
            public static  byte[] Encryption(string text, int KeySize, int BlockSize,string salt,string pw,int count=1000)
            {
                using(RijndaelManaged _rijndael = new RijndaelManaged())
                {
                    var src = Byte.Encode(text);
                    
                    _rijndael.KeySize = KeySize;
                    _rijndael.BlockSize = BlockSize;
                    
                    //ハッシュ
                    byte[] bSalt = Encoding.UTF8.GetBytes (salt);
                    Rfc2898DeriveBytes deriveBytes = new Rfc2898DeriveBytes (pw, bSalt);
                    deriveBytes.IterationCount = 1000;  
                    
                    _rijndael.Key = deriveBytes.GetBytes (_rijndael.KeySize / 8);
                    _rijndael.IV = deriveBytes.GetBytes (_rijndael.BlockSize / 8);
                    
                    ICryptoTransform encryptor = _rijndael.CreateEncryptor ();
                    byte[] encrypted = encryptor.TransformFinalBlock (src, 0, src.Length);
                    return encrypted;
                }
            }

            /// <summary>
            /// AES方式の暗号文を平文にする
            /// </summary>
            /// <param name="text">暗号化したい文</param>
            /// <param name="KeySize">鍵長さ(128.192,256のいづれか)</param>
            /// <param name="BlockSize">ブロック長さ(128で固定)</param>
            /// <param name="salt">パスワードと混ぜてハッシュ化されるソルト</param>
            /// <param name="pw">ソルトと混ぜてハッシュ化されるパスワード</param>
            /// <param name="count">ハッシュ化する回数</param>
            /// <param name="encrypted">平文</param>
            /// <returns></returns>
            public static byte[] Decrypt(string text, int KeySize, int BlockSize,string salt,string pw,byte[] encrypted,int count=1000)
            {
                using (RijndaelManaged _rijndael = new RijndaelManaged())
                {
                    var src = Byte.Encode(text);
                    
                    _rijndael.KeySize = KeySize;
                    _rijndael.BlockSize = BlockSize;

                    //ハッシュ
                    byte[] bSalt = Encoding.UTF8.GetBytes(salt);
                    Rfc2898DeriveBytes deriveBytes = new Rfc2898DeriveBytes(pw, bSalt);
                    deriveBytes.IterationCount = 1000;

                    _rijndael.Key = deriveBytes.GetBytes(_rijndael.KeySize / 8);
                    _rijndael.IV = deriveBytes.GetBytes(_rijndael.BlockSize / 8);
                    
                    ICryptoTransform decrypt = _rijndael.CreateDecryptor();
                    byte[] plain = decrypt.TransformFinalBlock(encrypted, 0, encrypted.Length);
                    return plain;
                }
            }
            
            

        }
        

       
      
    }
}