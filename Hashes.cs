using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace File_Checksum_Calculator
{
    class Hashes
    {
        public static string calculateMD5(string pathToFile)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(pathToFile))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        public static string calculateSHA1(string pathToFile)
        {
            using (FileStream fs = new FileStream(pathToFile, FileMode.Open))
            using (BufferedStream bs = new BufferedStream(fs))
            {
                using (SHA1Managed sha1 = new SHA1Managed())
                {
                    byte[] hash = sha1.ComputeHash(bs);
                    StringBuilder formatted = new StringBuilder(2 * hash.Length);
                    foreach (byte b in hash)
                    {
                        formatted.AppendFormat("{0:X2}", b);
                    }

                    return formatted.ToString();
                }
            }
        }

        public static string calculateSHA256(string pathToFile)
        {
            using (FileStream stream = File.OpenRead(pathToFile))
            {
                var sha = new SHA256Managed();
                byte[] checksum = sha.ComputeHash(stream);
                return BitConverter.ToString(checksum).Replace("-", String.Empty);
            }
        }

        public static string calculateSHA384(string pathToFile)
        {
            using (FileStream stream = File.OpenRead(pathToFile))
            {
                var sha = new SHA384Managed();
                byte[] checksum = sha.ComputeHash(stream);
                return BitConverter.ToString(checksum).Replace("-", String.Empty);
            }
        }

        public static string calculateSHA512(string pathToFile)
        {
            using (FileStream stream = File.OpenRead(pathToFile))
            {
                var sha = new SHA512Managed();
                byte[] checksum = sha.ComputeHash(stream);
                return BitConverter.ToString(checksum).Replace("-", String.Empty);
            }
        }

    }
    
}
