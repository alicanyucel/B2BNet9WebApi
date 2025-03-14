﻿

using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace B2B.Core.Extensions;

public static class ClaimExtensions
{
    public static void AddNameIdentifier(this ICollection<Claim> claims, string nameIdentifier)
    {
        claims.Add(new Claim(ClaimTypes.NameIdentifier, nameIdentifier));
    }
    public static void AddEmail(this ICollection<Claim> claims, string Email)
    {
        claims.Add(new Claim(JwtRegisteredClaimNames.Email, Email));
    }

    public static void AddCompany(this ICollection<Claim> claims, string Company)
    {
        claims.Add(new Claim(ClaimTypes.Anonymous, Company));
    }

    public static void AddName(this ICollection<Claim> claims, string Name)
    {
        claims.Add(new Claim(ClaimTypes.Name, Name));
    }


    public static void AddRoles(this ICollection<Claim> claims, string[] Roles)
    {
        Roles.ToList().ForEach(role => claims.Add(new Claim(ClaimTypes.Role, role)));
    }
}
