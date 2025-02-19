using TechLibrary.Api.Domain.Entities;

namespace TechLibrary.Api.Infraestructure.Security.Cryptography
{
    public class BCryptAlgorithme
    {
        public string HashPassword(string password) => BCrypt.Net.BCrypt.HashPassword(password);

        public Boolean Verify(string password, User user) => BCrypt.Net.BCrypt.Verify(password, user.Password);
    }
}
