using System.ComponentModel.DataAnnotations.Schema;

namespace IFToria.Data;

public class Aluno : Usuario
{
    public string? CursoMatriculado { get; set; }
    public ICollection<Tutoria> Tutorias { get; set; }
}
