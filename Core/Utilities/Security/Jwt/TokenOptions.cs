using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Jwt
{
    public class TokenOptions
    {
        public string Audience { get; set; } //Tokenın kullanıcı kitlesi
        public string Issuer { get; set; } //İmzalayan
        public int AccessTokenExpiration { get; set; } //Dakika
        public string SecurityKey { get; set; } //Güvenlik anahtarı
    }
}
