namespace IFToria.Data.Tutoria;

using Microsoft.EntityFrameworkCore;

public class TutoriaDbContext : DbContext
{
    public TutoriaDbContext(DbContextOptions<TutoriaDbContext> options) : base(options)
    {}
    public DbSet<Tutoria> Tutoria { get; set; }
}
