using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace System
{
public static partial class Extensions
    {
        public static byte[] ToBytes(this string @this)
        {
            var bytes = new byte[@this.Length * sizeof(char)];
            Buffer.BlockCopy(@this.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        public static string ToHashSha512(string @this)
        {
            if (@this.IsNullOrEmpty())
                return @this;

            var sb = new StringBuilder();
            using (SHA512 hash = SHA512.Create())
            {
                byte[] data = hash.ComputeHash(@this.ToBytes());
                foreach (byte b in data)
                {
                    sb.Append(b.ToString("x2"));
                }
            }
            return sb.ToString();
        }

        public static string ToHashSha256(string @this)
        {
            if (@this.IsNullOrEmpty())
                return @this;

            var sb = new StringBuilder();
            using (SHA256 hash = SHA256.Create())
            {
                byte[] data = hash.ComputeHash(@this.ToBytes());
                foreach (byte b in data)
                {
                    sb.Append(b.ToString("x2"));
                }
            }
            return sb.ToString();
        }
    }
}
