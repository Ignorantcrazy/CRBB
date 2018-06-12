using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CRBICommonLib
{
    public class Utilities
    {
        public static string Encrypt(string encryptionText)
        {
            string result = string.Empty;
            if (encryptionText.Length > 0)
            {
                byte[] array = Encrypt(Encoding.Unicode.GetBytes(encryptionText));
                if (array.Length > 0)
                {
                    result = Convert.ToBase64String(array);
                }
            }
            return result;
        }

        private static byte[] Encrypt(byte[] bytesData)
        {
            byte[] result = new byte[0];
            using (MemoryStream memoryStream = new MemoryStream())
            {
                ICryptoTransform transform = CreateAlgorithm().CreateEncryptor();
                CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
                try
                {
                    cryptoStream.Write(bytesData, 0, bytesData.Length);
                    cryptoStream.FlushFinalBlock();
                    cryptoStream.Close();
                    result = memoryStream.ToArray();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error while writing decrypted data to the stream: \n" + ex.Message);
                }
                finally
                {
                    cryptoStream?.Dispose();
                }
                memoryStream.Close();
            }
            return result;
        }

        private static Rijndael CreateAlgorithm()
        {
            RijndaelManaged rijndaelManaged = new RijndaelManaged();
            rijndaelManaged.Mode = CipherMode.CBC;
            Rijndael rijndael = rijndaelManaged;
            byte[] bytes = Encoding.Unicode.GetBytes("Nesc.Oversea");
            byte[] bytes2 = Encoding.Unicode.GetBytes("Oversea3");
            rijndael.Key = bytes;
            rijndael.IV = bytes2;
            return rijndael;
        }
    }
}
