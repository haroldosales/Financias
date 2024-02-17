using Microsoft.EntityFrameworkCore;

namespace Financias.Models
{
    public class PeopleContext : DbContext
    {
        public PeopleContext( DbContextOptions<PeopleContext> options) : base(options) { }

        public DbSet<People> People { get; set; } = null!;
    }
}
