namespace IFToria.Service;

using IFToria.Data;
using Microsoft.EntityFrameworkCore;

public class TutoriaService
{
    private readonly TutoriaDbContext _dbContext;

    public TutoriaService(TutoriaDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AdicionarTutoriaAsync(Tutoria Tutoria)
    {
        _dbContext.Tutorias.Add(Tutoria);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<Tutoria?> ObterTutoriaPorIdAsync(int TutoriaId)
    {
        return await _dbContext.Tutorias.FindAsync(TutoriaId);
    }

    public async Task<List<Tutoria>> ObterTutoriasAsync(int TutoriaId)
    {
        return await _dbContext.Tutorias.ToListAsync();
    }

    public async Task AtualizarTutoriaAsync(Tutoria Tutoria)
    {
        _dbContext.Tutorias.Update(Tutoria);
        await _dbContext.SaveChangesAsync();
    }

    public async Task RemoverTutoriaAsync(Tutoria Tutoria)
    {
        _dbContext.Tutorias.Remove(Tutoria);
        await _dbContext.SaveChangesAsync();
    }
}
