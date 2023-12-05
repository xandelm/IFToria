namespace IFToria.Data;

using Microsoft.EntityFrameworkCore;

public class TutoriaDbContext : DbContext
{
    public DbSet<Tutoria>? Tutorias { get; set; }

    public TutoriaDbContext(DbContextOptions<TutoriaDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Tutoria>()
            .HasMany(tutoria => tutoria.Inscritos)
            .WithMany(aluno => aluno.Tutorias)
            .UsingEntity(j => j.ToTable("InscritosTutoria"));
        base.OnModelCreating(modelBuilder);
    }
}
