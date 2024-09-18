using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Users.Service.Auth;

public static class AuthOptions
{
    private const string _key = "gnfgeutSDT32wqvj9024ngsfgojsgmsfopgo4j23rf0dsv";

    public const string Issuer = "UserService";
    public const string Audience = "SecureScape";

    public const string Salt = "2v042Sgaq1@%11t";

    public static SymmetricSecurityKey GetSymmetricSecurityKey() =>
        new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_key));
}