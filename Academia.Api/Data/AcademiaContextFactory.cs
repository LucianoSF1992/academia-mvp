using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Academia.Api.Data;

public class AcademiaContextFactory : IDesignTimeDbContextFactory<AcademiaContext>
{
    public AcademiaContext CreateDbContext(string[] args)
    {
        // Carrega appsettings.json manualmente
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var optionsBuilder = new DbContextOptionsBuilder<AcademiaContext>();

        optionsBuilder.UseSqlServer(
            configuration.GetConnectionString("DefaultConnection")
        );

        return new AcademiaContext(optionsBuilder.Options);
    }
}
