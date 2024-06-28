using MLSA.Domain.Entities.Interfaces.Repositories;

namespace MLSA.Domain.Entities.Interfaces;

public interface IUnitOfWork : IDisposable
{
    IUserRepository UserRepository { get; }

    Task SaveChangeAsync();

}
