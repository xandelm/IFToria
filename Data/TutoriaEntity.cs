namespace IFToria.Data;

public class Tutoria
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int TutorId { get; set; }
    public Aluno Tutor { get; set; }
    public DateTime Data { get; set; }
    public string Status { get; set; }
    public bool Certificado { get; set; }
    public int Duracao { get; set; }
    public string? Disciplina { get; set; }
    public int Vagas { get; set; }
    public ICollection<Aluno> Inscritos { get; set; }
}
