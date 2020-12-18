using Microsoft.EntityFrameworkCore;
namespace WebApiHeroes.Models {
    public class ApiContext : DbContext {
        public ApiContext (DbContextOptions options) : base (options) {

        }

        public DbSet<Hero> Heroes { get; set; }
    }
}