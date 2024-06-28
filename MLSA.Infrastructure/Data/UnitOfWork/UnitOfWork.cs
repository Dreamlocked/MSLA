using MLSA.Domain.Entities.Interfaces;
using MLSA.Domain.Entities.Interfaces.Repositories;
using MLSA.Infrastructure.Data.Contexts;
using MLSA.Infrastructure.Data.Repositories;

namespace MLSA.Infrastructure.Data.UnitOfWork;

public class UnitOfWork(MlsaContext context) : IUnitOfWork
{
    private bool _disposed = false;
    private IUserRepository? _userRepository;

    public IUserRepository UserRepository => _userRepository ??= new UserRepository(context);

    public async Task SaveChangeAsync() => await context.SaveChangesAsync();

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if(!this._disposed) if(disposing) context.Dispose();
        this._disposed = true;
    }
}
