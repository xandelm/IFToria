namespace IFToria.Service;

using IFToria.Data;
using Microsoft.EntityFrameworkCore;

public class AlunoService
{
    private readonly AlunoDbContext _dbContext;

    public AlunoService(AlunoDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AdicionarAlunoAsync(Aluno aluno)
    {
        _dbContext.Alunos.Add(aluno);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<Aluno?> ObterAlunoPorIdAsync(int alunoId)
    {
        return await _dbContext.Alunos.FindAsync(alunoId);
    }

    public async Task<List<Aluno>> ObterAlunosAsync()
    {
        return await _dbContext.Alunos.ToListAsync();
    }

    public async Task AtualizarAlunoAsync(Aluno aluno)
    {
        _dbContext.Alunos.Update(aluno);
        await _dbContext.SaveChangesAsync();
    }

    public async Task RemoverAlunoAsync(Aluno aluno)
    {
        _dbContext.Alunos.Remove(aluno);
        await _dbContext.SaveChangesAsync();
    }
}
