using System;
using System.Text;
using System.Security.Cryptography;

namespace Helper
{

    public static class Help
    {

        public static string Sha256(this string password)
        {
            SHA256Managed crypt = new SHA256Managed();
            string hash = String.Empty;
            Encoding enc = Encoding.GetEncoding(1252);
            byte[] crypto = crypt.ComputeHash(enc.GetBytes(password), 0, enc.GetByteCount(password));
            foreach (byte bit in crypto)
            {
                hash += bit.ToString("x2");
            }
            return hash;
        }
    }
}