using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Reflection.Emit;
using System.Xml;

namespace LazyArtCore.Data
{
    public class DBContext<T> : DbContext where T : class
    {
        public DbSet<T> Entities { get; set; }

        public DBContext(DbContextOptions<DBContext<T>> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
  
        }
    }

    public class GenericDbDbContextFactory<T> : IDesignTimeDbContextFactory<DBContext<T>> where T : class
    {
        public DBContext<T> CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DBContext<T>>();
            //待优化配置
            optionsBuilder.UseSqlServer("Server=81.71.44.247;Database=TestQAQ_QAQService;User Id=sa;Password=Rw$510th%v;TrustServerCertificate=True;");
            var context = new DBContext<T>(optionsBuilder.Options);
            //context.Database.EnsureDeleted();
            //context.Database.EnsureCreated();
            return context;
        }
    }
}