namespace IFToria.Data;

using Microsoft.EntityFrameworkCore;

public class CoordenadorDbContext : DbContext
{
    public DbSet<Coordenador> Coordenadores { get; set; }
    public CoordenadorDbContext(DbContextOptions<CoordenadorDbContext> options) : base(options) { }
}
