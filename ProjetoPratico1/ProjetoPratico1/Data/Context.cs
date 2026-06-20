using Microsoft.EntityFrameworkCore;
using ProjetoPratico1.Models;

namespace ProjetoPratico1.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) 
            : base(options) 
        { }

        public DbSet<User> User { get; set; }
    }
}
