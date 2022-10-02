using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using APIDiaristas.Data.Helpers;
using APIDiaristas.Domain.DTOs;
using APIDiaristas.Domain.Entities;
using Microsoft.IdentityModel.Tokens;

namespace APIDiaristas.Data.Services;

public class TokenService
{
    public string GenerateToken(LoginDto login)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes("ZmVkYWY3ZDg4NjNiNDhlMTk3YjkyODdkNDkyYjcwOGU=");
        var claims = login.GetClaims();
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims),
            Expires = DateTime.UtcNow.AddHours(8),
            SigningCredentials = new SigningCredentials(
                new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }
}