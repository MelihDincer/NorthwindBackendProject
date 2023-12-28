using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        //Password hash oluşturma
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt) //out keywordü, parametreyi gönderdiğimizde değişen nesne aynı zamanda bizim byte arrayimize aktarılmasını sağlayacaktır.
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512()) //Hashing algoritmamız
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        //Password hashin doğrulanması
        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512()) //Hashing algoritmamız
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
