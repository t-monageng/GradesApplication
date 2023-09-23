using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GivLib
{
    public class Encryption
    {
        public string EncryptString(string plainText, string key)
        {
            using (AesCryptoServiceProvider aesAlg = new AesCryptoServiceProvider())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.GenerateIV();

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }

                    byte[] iv = aesAlg.IV;
                    byte[] encryptedBytes = msEncrypt.ToArray();

                    // Combine IV and encrypted data
                    byte[] combinedBytes = new byte[iv.Length + encryptedBytes.Length];
                    Array.Copy(iv, 0, combinedBytes, 0, iv.Length);
                    Array.Copy(encryptedBytes, 0, combinedBytes, iv.Length, encryptedBytes.Length);

                    return Convert.ToBase64String(combinedBytes);
                }
            }
        }

        static string DecryptString(string cipherText, string key)
        {
            byte[] combinedBytes = Convert.FromBase64String(cipherText);

            using (AesCryptoServiceProvider aesAlg = new AesCryptoServiceProvider())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                byte[] iv = new byte[16];
                Array.Copy(combinedBytes, 0, iv, 0, iv.Length);
                aesAlg.IV = iv;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream())
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Write))
                    {
                        csDecrypt.Write(combinedBytes, iv.Length, combinedBytes.Length - iv.Length);
                    }

                    byte[] decryptedBytes = msDecrypt.ToArray();
                    return Encoding.UTF8.GetString(decryptedBytes);
                }
            }
        }

      
    }
}
