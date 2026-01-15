namespace Academia.Api.Models;

public class Exercicio
{
    public int Id { get; set; }
    public int TreinoId { get; set; }
    public string Nome { get; set; } = null!;
    public string GrupoMuscular { get; set; } = null!;
    public int Series { get; set; }
    public int Repeticoes { get; set; }
    public int Descanso { get; set; }
    public string? Observacoes { get; set; }

    public Treino Treino { get; set; } = null!;
}
