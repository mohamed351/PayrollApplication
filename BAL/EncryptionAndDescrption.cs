using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
   public class EncryptionAndDescrption:IDisposable
    {

        public string Encryption(string password)
        {
            TripleDESCryptoServiceProvider triple = new TripleDESCryptoServiceProvider();
            UTF8Encoding utf8 = new UTF8Encoding();
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            triple.Key = md5.ComputeHash(utf8.GetBytes("me2@helloWorld"));
            triple.Mode = CipherMode.ECB;
            triple.Padding = PaddingMode.PKCS7;
            ICryptoTransform Transform = triple.CreateEncryptor();
            return BitConverter.ToString(Transform.TransformFinalBlock(utf8.GetBytes(password), 0, utf8.GetBytes(password).Length));
        }


        static public string DecryptString(string hashstring)
        {
            List<byte> list = new List<byte>();
            UTF8Encoding utf8 = new UTF8Encoding();
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            TripleDESCryptoServiceProvider triple = new TripleDESCryptoServiceProvider();
            triple.Key = md5.ComputeHash(utf8.GetBytes("me2@helloWorld"));
            triple.Mode = CipherMode.ECB;
            triple.Padding = PaddingMode.PKCS7;
            ICryptoTransform transform = triple.CreateDecryptor();
            string s = hashstring;
            string[] ss = s.Split('-');
            for (int i = 0; i < ss.Length; i++)
            {
                list.Add(byte.Parse(ss[i], NumberStyles.HexNumber));

            }

            string word = utf8.GetString(transform.TransformFinalBlock(list.ToArray(), 0, list.ToArray().Length));
            return word;
        }

        public void Dispose()
        {
            GC.Collect();
        }
    }
}
