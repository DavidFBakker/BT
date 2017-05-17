using EMDB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EMDB
{
    public class DB
    {
        public EMContext GetContext()
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .Build();

            var connection = configuration.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<EMContext>();
            optionsBuilder.UseSqlServer(connection);

            return new EMContext(optionsBuilder.Options);
        }
    }
}