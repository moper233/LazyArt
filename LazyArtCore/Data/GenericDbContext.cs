using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Reflection.Emit;
using System.Xml;

namespace LazyArtCore.Data
{
    public class GenericDbContext<T> : DbContext where T : class
    {
        public DbSet<T> Entities { get; set; }

        public GenericDbContext(DbContextOptions<GenericDbContext<T>> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
  
        }

 
    }

    public class GenericDbDbContextFactory<T> : IDesignTimeDbContextFactory<GenericDbContext<T>> where T : class
    {
        public GenericDbContext<T> CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<GenericDbContext<T>>();
            //待优化配置
            optionsBuilder.UseOracle("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=172.26.153.107)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=KFDBZDPC)));User Id=PT;Password=PT;");

            var context = new GenericDbContext<T>(optionsBuilder.Options);
            //context.Database.EnsureCreated();
            //context.Database.Migrate();
            return context;
        }
    }
}