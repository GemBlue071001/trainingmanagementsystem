using Domain.Entities;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Application.Utils
{
    public static class GenerateJsonWebTokenString
    {
        public static string GenerateJsonWebToken(this User user, string secretKey, DateTime now)
        {
            //var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
            //var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            //var claims = new[]
            //{
            //    new Claim(ClaimTypes.NameIdentifier ,user.Id.ToString()),
            //    new Claim(ClaimTypes.Role ,user.Role.RoleType.ToString()),
            //};
            //var token = new JwtSecurityToken(
            //    claims: claims,
            //    expires: now.AddMinutes(60),
            //    signingCredentials: credentials);


            //return new JwtSecurityTokenHandler().WriteToken(token);
            //
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(secretKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier,user.Id.ToString()),
                    new Claim(ClaimTypes.Role,user.Role.ToString())
                }),
                Expires = now.AddMinutes(60),
                SigningCredentials = new(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

    }
}
