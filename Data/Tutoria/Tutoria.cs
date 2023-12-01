namespace IFToria.Data.Tutoria;

using IFToria.Data.Usuario;

public class Tutoria {
    private string Nome { get; set; }
    private Usuario Tutor { get; set; }
    private DateTime Data { get; set; }
    private string Status { get; set; }
    private bool certificado { get; set; }
    private DateTime Duracao { get; set; }
    private string Disciplina { get; set; }
    private int VagasAtual { get; set; }
    private int VagasMaxima { get; set; }
}
