using System.Security.Claims;
using System.Text;

namespace BuildingBlocks.Security.JWT;

public class KeyRotationManager
{
    private readonly List<string> _trustedKeys;

    public KeyRotationManager(List<string> trustedKeys)
    {
        _trustedKeys = trustedKeys;
    }

    public bool ValidateToken(string token, out ClaimsPrincipal principal)
    {
        foreach (var key in _trustedKeys)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var validationParams = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key)),
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateLifetime = true,
                ClockSkew = TimeSpan.FromSeconds(10)
            };

            try
            {
                principal = tokenHandler.ValidateToken(token, validationParams, out _);
                return true;
            }
            catch { continue; }
        }

        principal = null!;
        return false;
    }
}
