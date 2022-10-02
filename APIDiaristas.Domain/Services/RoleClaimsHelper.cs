using System.Security.Claims;
using APIDiaristas.Domain.DTOs;

namespace APIDiaristas.Data.Helpers;

public static class RoleClaimsHelper
{
    public static IEnumerable<Claim> GetClaims(this LoginDto login)
    {
        var result = new List<Claim>
        {
            new(ClaimTypes.Name, login.Email),
            new(ClaimTypes.Role, "DayWorker")
        };
        return result;
    }
}