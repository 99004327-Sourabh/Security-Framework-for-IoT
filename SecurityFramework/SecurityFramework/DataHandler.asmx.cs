using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Web;
using System.Web.Services;

namespace SecurityFramework
{
    /// <summary>
    /// Summary description for DataHandler
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class DataHandler : System.Web.Services.WebService
    {
        [WebMethod]
        public static byte[] Serialize<T>(T obj)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }

        [WebMethod]
        public static T Deserialize<T>(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                BinaryFormatter bf = new BinaryFormatter();
                return (T)bf.Deserialize(ms);
            }
        }

        [WebMethod]
        public static byte[] Decrypt(byte[] encryptedRSA, string privateXml)
        {
            var rsaPrivate = new RSACryptoServiceProvider();
            rsaPrivate.FromXmlString(privateXml);
            byte[] decryptedRSA = rsaPrivate.Decrypt(encryptedRSA, false);
            return decryptedRSA;
        }

        [WebMethod]
        public static byte[] Encrypt(byte[] toEncryptData, string publicXml)
        {
            RSACryptoServiceProvider rsaPublic = new RSACryptoServiceProvider();
            rsaPublic.FromXmlString(publicXml);
            byte[] encryptedRSA = rsaPublic.Encrypt(toEncryptData, false);
            return encryptedRSA;
        }

        [WebMethod]
        public static void GenerateKeys(ref string privateXml, ref string publicXml)
        {
            RSACryptoServiceProvider rsaGenKeys = new RSACryptoServiceProvider();
            privateXml = rsaGenKeys.ToXmlString(true);
            publicXml = rsaGenKeys.ToXmlString(false);
        }
    }

}

