namespace IFToria.Service;

using IFToria.Data;
using Microsoft.EntityFrameworkCore;

public class CoordenadorService
{
    private readonly CoordenadorDbContext _dbContext;

    public CoordenadorService(CoordenadorDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AdicionarCoordenadorAsync(Coordenador Coordenador)
    {
        _dbContext.Coordenadores.Add(Coordenador);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<Coordenador?> ObterCoordenadorPorIdAsync(int CoordenadorId)
    {
        return await _dbContext.Coordenadores.FindAsync(CoordenadorId);
    }

    public async Task<List<Coordenador>> ObterCoordenadorsAsync(int CoordenadorId)
    {
        return await _dbContext.Coordenadores.ToListAsync();
    }

    public async Task AtualizarCoordenadorAsync(Coordenador Coordenador)
    {
        _dbContext.Coordenadores.Update(Coordenador);
        await _dbContext.SaveChangesAsync();
    }

    public async Task RemoverCoordenadorAsync(Coordenador Coordenador)
    {
        _dbContext.Coordenadores.Remove(Coordenador);
        await _dbContext.SaveChangesAsync();
    }
}
