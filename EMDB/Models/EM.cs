using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace EMDB.Models
{
    public class TemporaryDbContextFactory : IDbContextFactory<EMContext>
    {
        public EMContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<EMContext>();
            builder.UseSqlServer(@"Data Source=192.168.1.12,1433;Initial Catalog=EM;User ID=dev;Password=devR0xR0x;");
            return new EMContext(builder.Options);
        }
    }

    public class EMContext : DbContext
    {
        public EMContext(DbContextOptions<EMContext> options)
            : base(options)
        {
        }

     
        public DbSet<EmToName> EmToNames { get; set; }
        public DbSet<Packet> Packets { get; set; }

        public DbSet<InputNames> InputNames { get; set; }

        public DbSet<Channels> Channels { get; set; }

        public DbSet<Plot> Plots { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Packet>()
                .HasKey(c => new {c.DT, c.Node});
        }
    }
}