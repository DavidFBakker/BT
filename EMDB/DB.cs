using EMDB.Models;
using Microsoft.EntityFrameworkCore;

namespace EMDB
{
    public class DB
    {
        public EMContext GetContext()
        {
            var connection = @"Data Source=192.168.1.12,1433;Initial Catalog=EM;User ID=dev;Password=devR0xR0x;";
            var optionsBuilder = new DbContextOptionsBuilder<EMContext>();
            optionsBuilder.UseSqlServer(connection);

            return new EMContext(optionsBuilder.Options);
        }
    }
}