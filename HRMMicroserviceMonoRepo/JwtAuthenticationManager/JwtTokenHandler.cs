using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using JwtAuthenticationManager.Model;
using Microsoft.IdentityModel.Tokens;

namespace JwtAuthenticationManager
{
    public class JwtTokenHandler
    {
        public const string JWT_Secret_Key = "IamUsingThisKeyAsJWTSecretKeyForSecurityin2023YearMonth03";
        public const int JWT_Token_Valid_Mins = 20;

        private readonly List<UserAccount> accounts;
        public JwtTokenHandler()
        {
            accounts = new List<UserAccount> {

            new UserAccount(){ Username="admin", Password="admin@1234", Role="Admin"},
            new UserAccount(){ Username="yitong", Password="yitong@1234", Role="User"},

            new UserAccount(){ Username="scott", Password="scott@1234", Role="Manager"}
            };
        }
        public AuthenticationResponseModel GenerateJwtToken(AuthenticationRequestModel authenticationRequestModel)
        {
            if (authenticationRequestModel == null)
                return null;
            if (string.IsNullOrEmpty(authenticationRequestModel.Username) || string.IsNullOrEmpty(authenticationRequestModel.Password))
                return null;

            var accountInfo = accounts.Where(X => X.Username == authenticationRequestModel.Username && X.Password == authenticationRequestModel.Password).FirstOrDefault();
            if (accountInfo == null)
                return null;

            /* code for jwt token generation */

            var tokenExpiryTimeStamp = DateTime.Now.AddMinutes(JWT_Token_Valid_Mins);
            var tokenKey = Encoding.ASCII.GetBytes(JWT_Secret_Key);

            var claimsUserIdentity = new ClaimsIdentity(
                new List<Claim>
                {
                    new Claim(System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames.Name,authenticationRequestModel.Username),
                    new Claim(ClaimTypes.Role,accountInfo.Role)
                });
            var signInCredentials = new SigningCredentials(
                new SymmetricSecurityKey(tokenKey),
                SecurityAlgorithms.HmacSha256Signature
                );

            var securityTokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = claimsUserIdentity,
                Expires = tokenExpiryTimeStamp,
                SigningCredentials = signInCredentials
            };

            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var securityToken = jwtSecurityTokenHandler.CreateToken(securityTokenDescriptor);
            var tokenString = jwtSecurityTokenHandler.WriteToken(securityToken);

            return new AuthenticationResponseModel
            {
                Username = authenticationRequestModel.Username,
                ExpiresIn = (int)tokenExpiryTimeStamp.Subtract(DateTime.Now).TotalSeconds,
                Token = tokenString

            };



        }
    }
}
