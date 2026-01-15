namespace Academia.Api.Models;

public class Usuario
{
    public int Id { get; set; }
    public string Nome { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Senha { get; set; } = null!;
    public string Tipo { get; set; } = null!; // Admin ou Aluno
}
