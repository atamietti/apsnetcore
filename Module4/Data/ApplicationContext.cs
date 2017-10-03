using Microsoft.EntityFrameworkCore;
using Module4.Domain;

namespace Module4.Data
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext>  options): base(options)
        {

        }
        
        public DbSet<Product>  Products {get;set;}
        public DbSet<Category> Categories { get; set; }

      protected  override void OnModelCreating(ModelBuilder modelBuilder) 
      {

            // modelBuilder.Entity<Product>().ToTable("Prod");
            // modelBuilder.Entity<Product>().Property(p=> p.Name ).HasMaxLength(100);
            // modelBuilder.Entity<Category>().ToTable("Cat");
            // modelBuilder.Entity<Category>().Property(p=> p.Name ).HasMaxLength(50);
        }
    }
}