﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Security.JWT;

public class TokenOptions
{
    public string Audience { get; set; }
    public string Issuer { get; set; }
    public int AccessTokenExpiration { get; set; }
    public string SecurityKey { get; set; }
    public int RefreshTokenTTL { get; set; }

    public TokenOptions(string audience, string issuer, string securityKey)
    {
        Audience = audience;
        Issuer = issuer;
        SecurityKey = securityKey;
    }

    public TokenOptions(string audience, string issuer, int accessTokenExpiration, string securityKey, int refreshTokenTTL)
    {
        Audience = audience;
        Issuer = issuer;
        AccessTokenExpiration = accessTokenExpiration;
        SecurityKey = securityKey;
        RefreshTokenTTL = refreshTokenTTL;
    }
}

