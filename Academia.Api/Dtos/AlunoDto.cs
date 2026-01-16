namespace Academia.Api.Dtos;

public class AlunoDto
{
    public int Id { get; set; }
    public string Nome { get; set; } = null!;
    public string Email { get; set; } = null!;
    public int? Idade { get; set; }
    public string Objetivo { get; set; } = null!;
}
