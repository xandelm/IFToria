namespace IFToria.Data;

using Microsoft.EntityFrameworkCore;

public class AlunoDbContext : DbContext
{
    public DbSet<Aluno>? Alunos { get; set; }

    public AlunoDbContext(DbContextOptions<AlunoDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aluno>()
            .HasMany(aluno => aluno.Tutorias)
            .WithOne(tutoria => tutoria.Tutor)
            .HasForeignKey(tutoria => tutoria.TutorId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
