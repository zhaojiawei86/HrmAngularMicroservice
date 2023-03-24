using System;
namespace JwtAuthenticationManager.Model
{
	public class AuthenticationResponseModel
	{
		public string Username { get; set; }
		public string Token { get; set; }
		public int ExpiresIn { get; set; }
	}
}

