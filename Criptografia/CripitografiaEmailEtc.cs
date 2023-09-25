﻿using System.Security.Cryptography;
using System.Text;

namespace LoginAPI.Criptografia
{
    public class CripitografiaEmailEtc
    {
        /// <summary>
        /// Vetor de bytes utilizados para a criptografia (Chave Externa)
        /// </summary>
        private static byte[] bIV = { 0x50, 0x08, 0xF1, 0xDD, 0xDE, 0x3C, 0xF2, 0x18, 0x44, 0x74,
            0x19, 0x2C, 0x53, 0x49, 0xAB, 0xBC };

        /// <summary>     
        /// Representação de valor em base 64 (Chave Interna), o valor representa a transformação para base64
        /// Conjunto de 32 caracteres (8 * 32 = 256bits)
        /// A chave é: "Criptografias com Rijndael / AES"
        /// </summary>     
        private const string cryptoKey = "Q3JpcHRvZ3JhZmlhcyBjb20gUmluamRhZWwgLyBBRVM=";

        public static string Criptografar(string text)
        {
            try
            {
                if (string.IsNullOrEmpty(text))
                    return null;

                byte[] bKey = Convert.FromBase64String(cryptoKey);
                byte[] bText = new UTF8Encoding().GetBytes(text);

                Rijndael rijndael = new RijndaelManaged();
                rijndael.KeySize = 128;

                MemoryStream mStream = new MemoryStream();
                CryptoStream encryptor = new CryptoStream(mStream, rijndael.CreateEncryptor(bKey, bIV), CryptoStreamMode.Write);
                encryptor.Write(bText, 0, bText.Length);
                encryptor.FlushFinalBlock();
                return Convert.ToBase64String(mStream.ToArray()).Replace("/", "-").Replace("+", "_");
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erro ao criptografar", ex);
            }
        }

        public static string Descriptografar(string text)
        {
            try
            {
                if (string.IsNullOrEmpty(text))
                    return null;

                text = text.Replace("-", "/").Replace("_", "+");

                byte[] bKey = Convert.FromBase64String(cryptoKey);
                byte[] bText = Convert.FromBase64String(text);

                Rijndael rijndael = new RijndaelManaged();
                rijndael.KeySize = 128;

                MemoryStream mStream = new MemoryStream();
                CryptoStream decryptor = new CryptoStream(mStream, rijndael.CreateDecryptor(bKey, bIV), CryptoStreamMode.Write);
                decryptor.Write(bText, 0, bText.Length);
                decryptor.FlushFinalBlock();
                return new UTF8Encoding().GetString(mStream.ToArray());
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erro ao descriptografar", ex);
            }
        }
    }
}
