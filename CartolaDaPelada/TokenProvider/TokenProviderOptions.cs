using Microsoft.IdentityModel.Tokens;
using System;

namespace CartolaDaPelada.TokenProvider
{
    public class TokenProviderOptions
    {
        public string Path { get; set; } = "/api/token";

        public string Issuer { get; set; }

        public string Audience { get; set; }

        public TimeSpan Expiration { get; set; } = TimeSpan.FromMinutes(30);

        public SigningCredentials SigningCredentials { get; set; }
    }
}
