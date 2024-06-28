using Microsoft.EntityFrameworkCore;
using MLSA.Domain.Entities.Interfaces.Repositories;
using MLSA.Domain.Entities.POCOs;
using MLSA.Infrastructure.Data.Contexts;
using System.Security.Cryptography;
using System.Text;

namespace MLSA.Infrastructure.Data.Repositories;
public class UserRepository(MlsaContext context) : IUserRepository
{
    public async Task<User?> GetByIdAsync(Guid id)
    {
        return await context.Users.FindAsync(id);
    }

    public async Task<User?> Login(string email, string password)
    {
        var user = await context.Users.FirstOrDefaultAsync(u => u.Email == email);
        if(user == null) return null;
        if(!VerifyPasswordHash(password, user.Password, user.Salt)) return null;
        return user;
    }

    private bool VerifyPasswordHash(string password, string passwordHash, string salt)
    {
        using var hmac = new HMACSHA512(Encoding.UTF8.GetBytes(salt));
        var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        for(int i = 0; i < computedHash.Length; i++)
        {
            if(computedHash[i] != passwordHash[i]) return false;
        }
        return true;
    }
}
