using Microsoft.AspNetCore.Identity;

using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Web_API.Models
{
    public class JWTService
    {
        public String SecretKey { get; set; }
        public int TokenDuration { get; set; }

        private readonly IConfiguration config;
        public JWTService(IConfiguration _config)
        {
            config = _config;
            this.SecretKey = config.GetSection("jwtConfig").GetSection("key").Value;
            this.TokenDuration = Int32.Parse(config.GetSection("jwtConfig").GetSection("Duration").Value);

        }

        public String GenerateToken(String EmpId, String USER_NAME, String Position_Name, String Path, String NTitel, String NBody, String count)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this.SecretKey));
            var signature = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var Pay_Load = new[]
            {

                  new Claim("EmpId", EmpId),
                  new Claim("USER_NAME", USER_NAME),
                 
                  new Claim ("Position_Name", Position_Name),
                  new Claim ("Path" , Path),
                  new Claim("NTitel", NTitel),
                  new Claim("NBody", NBody),
                  new Claim("count",  count)


            };

            var jwtToken = new JwtSecurityToken(
                issuer: "localhost",
                audience: "localhost",
                claims: Pay_Load,

                expires: DateTime.Now.AddMinutes(TokenDuration),
                 signingCredentials: signature
                );
            return new JwtSecurityTokenHandler().WriteToken(jwtToken);
        }

        internal object GenerateToken()
        {
            throw new NotImplementedException();
        }


    }
}
