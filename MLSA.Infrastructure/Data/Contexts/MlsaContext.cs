using Microsoft.EntityFrameworkCore;
using MLSA.Domain.Entities.POCOs;

namespace MLSA.Infrastructure.Data.Contexts;
public class MlsaContext : DbContext
{
    public MlsaContext(DbContextOptions<MlsaContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }

}
