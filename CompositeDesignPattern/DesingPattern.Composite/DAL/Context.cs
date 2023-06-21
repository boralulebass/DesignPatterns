using Microsoft.EntityFrameworkCore;

namespace DesingPattern.Composite.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-D0HPTG1\\SQLEXPRESS;initial Catalog=DesignPattern7;integrated security=true;");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
