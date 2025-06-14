using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Encryption
    {
        public static void Encrypt(string inputFile)
        {
            string outputFile = inputFile + ".crypt";

            using (Aes aesAlg = Aes.Create())
            {
                byte[] key = aesAlg.Key;
                byte[] iv = aesAlg.IV;

                using (FileStream inputStream = File.OpenRead(inputFile))
                using (FileStream outputStream = File.Create(outputFile))
                using (CryptoStream cryptoStream = new CryptoStream(outputStream, aesAlg.CreateEncryptor(key, iv), CryptoStreamMode.Write))
                {
                    outputStream.Write(key, 0, key.Length);
                    outputStream.Write(iv, 0, iv.Length);

                    inputStream.CopyTo(cryptoStream);
                }
            }
        }
        public static void Decrypt(string inputFile)
        {
            string outputFile = Path.GetFileNameWithoutExtension(inputFile);
            byte[] key = new byte[32]; 
            byte[] iv = new byte[16]; 

            using (FileStream inputStream = File.OpenRead(inputFile))
            {
                inputStream.Read(key, 0, key.Length);
                inputStream.Read(iv, 0, iv.Length);

                using (Aes aesAlg = Aes.Create())
                using (CryptoStream cryptoStream = new CryptoStream(inputStream, aesAlg.CreateDecryptor(key, iv), CryptoStreamMode.Read))
                using (FileStream outputStream = File.Create(outputFile))
                {
                    cryptoStream.CopyTo(outputStream);
                }
            }
        }

    }
}
