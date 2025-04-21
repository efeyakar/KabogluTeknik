using KabogluTeknik.Entities;
using Microsoft.EntityFrameworkCore;

namespace KabogluTeknik.Context
{
    public class GeneralContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=GRETHRAIN\\SQLEXPRESS;initial Catalog=KabogluTeknikSystemDb; integrated Security=true");
        }
        public DbSet<General> generals { get; set; }
        public DbSet<Header>  headers { get; set; }
        public DbSet<About>  abouts { get; set; }
        public DbSet<Category>  categories { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Contact>  contacts { get; set; }

    }
}
