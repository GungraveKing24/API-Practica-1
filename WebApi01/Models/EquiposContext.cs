using Microsoft.EntityFrameworkCore;

namespace WebApi01.Models
{
    public class EquiposContext : DbContext
    {
        public EquiposContext(DbContextOptions<EquiposContext> options) : base(options)
        {

        }

        public DbSet<Equipos> Equipos { get; set; }
    }
}
