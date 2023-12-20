namespace dailyquiz.Infrastructure.Authentication;

public class JwtOptions
{
    public JwtOptions()
    {
        Issuer = "";
        Audience = "";
        SecretKey = "";
    }

    public string Issuer { get; init; }

    public string Audience { get; init; }

    public string SecretKey { get; init; }
}
