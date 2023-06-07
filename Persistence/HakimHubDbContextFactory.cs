using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Persistence.Repositories
{
    public class HakimHubDbContextFactory : IDesignTimeDbContextFactory<HakimHubDbContext>
    {
        public HakimHubDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json")
                 .Build();

            var builder = new DbContextOptionsBuilder<HakimHubDbContext>();
            var connectionString = configuration.GetConnectionString("HakimConnectionString");

            builder.UseNpgsql(connectionString);

            return new HakimHubDbContext(builder.Options);
        }
    }
}