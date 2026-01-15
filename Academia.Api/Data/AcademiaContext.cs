using Microsoft.EntityFrameworkCore;
using Academia.Api.Models;

namespace Academia.Api.Data;

public class AcademiaContext : DbContext
{
    public AcademiaContext(DbContextOptions<AcademiaContext> options)
        : base(options)
    {
    }

    public DbSet<Usuario> Usuarios => Set<Usuario>();
    public DbSet<Aluno> Alunos => Set<Aluno>();
    public DbSet<Treino> Treinos => Set<Treino>();
    public DbSet<Exercicio> Exercicios => Set<Exercicio>();
}
