namespace BuildingBlocks.Security.JWT;

public class JwtOptions
{
    public string Issuer { get; set; } = default!;
    public string Audience { get; set; } = default!;
    public string SigningKey { get; set; } = default!;
    public int ExpiryMinutes { get; set; }
    public List<string> TrustedKeys { get; set; } = new();
}
