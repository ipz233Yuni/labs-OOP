using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ClassLibrary1
{
    public class Encryption
    {
        public static void Encrypt(string inputFile, string password)
        {
            string outputFile = inputFile + ".crypt";
            byte[] salt = Encoding.UTF8.GetBytes("SomeSaltValue1234"); 

            using (var keyDeriver = new Rfc2898DeriveBytes(password, salt, 100000))
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = keyDeriver.GetBytes(32);
                aesAlg.GenerateIV(); 

                using (FileStream outputStream = File.Create(outputFile))
                {
                    outputStream.Write(aesAlg.IV, 0, aesAlg.IV.Length); 

                    using (CryptoStream cryptoStream = new CryptoStream(outputStream, aesAlg.CreateEncryptor(), CryptoStreamMode.Write))
                    using (FileStream inputStream = File.OpenRead(inputFile))
                    {
                        inputStream.CopyTo(cryptoStream);
                    }
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
