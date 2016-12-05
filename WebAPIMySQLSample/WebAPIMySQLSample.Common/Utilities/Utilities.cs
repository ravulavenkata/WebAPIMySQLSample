using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIMySQLSample.Common.Utilities
{
    public static class Utilities
    {
        public static string CreateSHAHash(string PasswordSHA512, string securityCode)
        {
            System.Security.Cryptography.SHA512Managed sha512 = new System.Security.Cryptography.SHA512Managed();
            Byte[] EncryptedSHA512 = sha512.ComputeHash(System.Text.Encoding.UTF8.GetBytes(string.Concat(PasswordSHA512, securityCode)));
            sha512.Clear();
            return Convert.ToBase64String(EncryptedSHA512);
        }

        /// <summary>
        /// Encrypt text string
        /// </summary>
        /// <param name="toEncryptorDecrypt"> data to encryptorDecrypt</param>
        /// <param name="encrypt">Weather encrypt or decrypt</param>
        /// <returns>An encrypted or decrypted string</returns>

        public static string EncryptorDecrypt(string key, bool encrypt, string securityCode)
        {
            byte[] toEncryptorDecryptArray;
            ICryptoTransform cTransform;
            // Transform the specified region of bytes array to resultArray
            MD5CryptoServiceProvider md5Hasing = new MD5CryptoServiceProvider();
            byte[] keyArrays = md5Hasing.ComputeHash(UTF8Encoding.UTF8.GetBytes(securityCode));
            md5Hasing.Clear();
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider()
            { Key = keyArrays, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 };
            if (encrypt == true)
            {
                toEncryptorDecryptArray = UTF8Encoding.UTF8.GetBytes(key);
                cTransform = tdes.CreateEncryptor();
            }
            else
            {
                toEncryptorDecryptArray = Convert.FromBase64String(key.Replace(' ', '+'));
                cTransform = tdes.CreateDecryptor();
            }
            byte[] resultsArray = cTransform.TransformFinalBlock(toEncryptorDecryptArray, 0, toEncryptorDecryptArray.Length);
            tdes.Clear();
            if (encrypt == true)
            { //if encrypt we need to return encrypted string
                return Convert.ToBase64String(resultsArray, 0, resultsArray.Length);
            }
            //else we need to return decrypted string
            return UTF8Encoding.UTF8.GetString(resultsArray);
        }


        public static string MD5HashEncrypt(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits
                //for each byte
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }
    }
}
