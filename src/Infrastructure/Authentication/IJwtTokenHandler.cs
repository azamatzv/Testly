using Core.DTOs;
using System.IdentityModel.Tokens.Jwt;

namespace Infrastructure.Authentication;

public interface IJwtTokenHandler
{
    JwtSecurityToken GenerateAccessToken(ParticipantDto participant);
    string GenerateRefreshToken();
}