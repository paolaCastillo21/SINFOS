using Microsoft.EntityFrameworkCore;
using Sinfos.Core.Domain;

namespace Sinfos.Infrastructure.Data
{
    public class SinfosDbContext : DbContext
    {
        public  SinfosDbContext(DbContextOptions<SinfosDbContext> options) : base(options)
        {

        }

        public DbSet<Agenda> Agendas  { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
