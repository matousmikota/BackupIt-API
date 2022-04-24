using JWT.Algorithms;
using JWT.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class AuthenticationService
    {
        const string SECRET = "foo-bar";

        private MyContext context = new MyContext();

        public string Authenticate(Credentials credentials)
        {
            Admin admin = this.context.Admins.Where(x => x.login == credentials.Login && x.password == credentials.Password).FirstOrDefault();

            if (admin == null)
                throw new Exception("invalid admin");

            return JwtBuilder.Create()
                      .WithAlgorithm(new HMACSHA256Algorithm()) // symmetric
                      .WithSecret(SECRET)
                      .AddClaim("exp", DateTimeOffset.UtcNow.AddSeconds(30).ToUnixTimeSeconds())
                      .AddClaim("user_id", admin.Id)
                      .Encode();
        }

        public bool VerifyToken(string token)
        {
            try
            {
                string json = JwtBuilder.Create()
                             .WithAlgorithm(new HMACSHA256Algorithm()) // symmetric
                             .WithSecret(SECRET)
                             .MustVerifySignature()
                             .Decode(token);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
