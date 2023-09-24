using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SecureLib
{
    public class DataHandler
    {
        public static byte[] Serialize<T>(T obj)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }

        public static T Deserialize<T>(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                BinaryFormatter bf = new BinaryFormatter();
                return (T)bf.Deserialize(ms);
            }
        }

        public static byte[] Decrypt(byte[] encryptedRSA, string privateXml)
        {
            var rsaPrivate = new RSACryptoServiceProvider();
            rsaPrivate.FromXmlString(privateXml);
            byte[] decryptedRSA = rsaPrivate.Decrypt(encryptedRSA, false);
            return decryptedRSA;
        }

        public static byte[] Encrypt(byte[] toEncryptData, string publicXml)
        {
            RSACryptoServiceProvider rsaPublic = new RSACryptoServiceProvider();
            rsaPublic.FromXmlString(publicXml);
            byte[] encryptedRSA = rsaPublic.Encrypt(toEncryptData, false);
            return encryptedRSA;
        }

        public static void GenerateKeys(ref string privateXml, ref string publicXml)
        {
            RSACryptoServiceProvider rsaGenKeys = new RSACryptoServiceProvider();
            privateXml = rsaGenKeys.ToXmlString(true);
            publicXml = rsaGenKeys.ToXmlString(false);
        }
    }
 
}
