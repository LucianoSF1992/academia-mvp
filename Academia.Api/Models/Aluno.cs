namespace Academia.Api.Models;

public class Aluno
{
    public int Id { get; set; }
    public int UsuarioId { get; set; }
    public int? Idade { get; set; }
    public string Objetivo { get; set; } = null!;

    public Usuario Usuario { get; set; } = null!;
}
