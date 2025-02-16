using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using userAuthentication_module.data;

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        optionsBuilder.UseNpgsql(configuration.GetConnectionString("ConnectionStrings:Default"));

        return new AppDbContext(optionsBuilder.Options);
    }
}
