namespace Academia.Api.Models;

public class Treino
{
    public int Id { get; set; }
    public int AlunoId { get; set; }
    public string DiaSemana { get; set; } = null!;

    public List<Exercicio> Exercicios { get; set; } = new();
}
