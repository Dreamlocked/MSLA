using MLSA.Domain.Entities.POCOs;

namespace MLSA.Domain.Entities.Interfaces.Repositories;
public interface IUserRepository
{
    Task<User?> Login(string email, string password);
    Task<User?> GetByIdAsync(Guid id);
}
