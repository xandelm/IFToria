namespace IFToria.Data.Usuario;

using IFToria.Data.Tutoria;

public class Usuario
{
    private string Nome { get; set; }
    private string NomeReal { get; set; }
    private string CPF { get; set; }
    private string Email { get; set; }
    private string Senha { get; set; }
    private List<Tutoria> TutoriasInscritas { get; set; }
}
