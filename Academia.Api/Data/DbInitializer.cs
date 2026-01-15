using Academia.Api.Models;

namespace Academia.Api.Data;

public static class DbInitializer
{
    public static void Seed(AcademiaContext context)
    {
        if (context.Usuarios.Any())
            return;

        context.Usuarios.AddRange(
            new Usuario
            {
                Nome = "Admin",
                Email = "admin@academia.com",
                Senha = "admin",
                Tipo = "Admin"
            },
            new Usuario
            {
                Nome = "Aluno Teste",
                Email = "aluno@academia.com",
                Senha = "aluno",
                Tipo = "Aluno"
            }
        );

        context.SaveChanges();
    }
}
