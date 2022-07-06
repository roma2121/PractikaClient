using System;
using System.Text;
using System.IO;

using System.Security.Cryptography;
using System.Xml.Serialization;

namespace ClientS
{
    class RSA
    {
        private static RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048);

        private byte[] privateKey;
        private byte[] publicKey;

        public RSA()
        {
            privateKey = rsa.ExportCspBlob(false);
            publicKey = rsa.ExportCspBlob(true);
        }

        public byte[] GetPublicKey()
        {
            return privateKey;
        }

        public string Encrypt(string plainText, string pubKey)
        {
            rsa = new RSACryptoServiceProvider();

            rsa.ImportCspBlob(publicKey);

            var data = Encoding.Unicode.GetBytes(plainText);
            var cypher = rsa.Encrypt(data, false);

            return Convert.ToBase64String(cypher);
        }

        public byte[] Decrypt(string cypherText)
        {
            var dataBytes = Convert.FromBase64String(cypherText);

            rsa.ImportCspBlob(publicKey);

            var plainText = rsa.Decrypt(dataBytes, false);

            return plainText;
        }
    }
}