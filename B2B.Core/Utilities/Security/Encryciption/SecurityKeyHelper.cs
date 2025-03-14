﻿

using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace B2B.Core.Utilities.Security.Encryciption;

public class SecurityKeyHelper
{
    public static SecurityKey CreateSecurityKey(string securitykey)
    {
        return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securitykey));
    }
}