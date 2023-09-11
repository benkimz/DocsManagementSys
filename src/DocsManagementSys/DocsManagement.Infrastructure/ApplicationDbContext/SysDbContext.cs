using Microsoft.EntityFrameworkCore;

namespace DocsManagement.Infrastructure.ApplicationDbContext
{
    public class SysDbContext : DbContext
    {
        public SysDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
