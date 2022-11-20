using static WebProje.Models.context;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebProje.Models
{
    public class context:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost; user=root; database=Category; password=GOKKAYA52.o; port=3306");
        }
        /// <summary>
        /// eren tetikk
        /// </summary>
        public DbSet<Category> Categories { get; set; }
        public DbSet<Urunler> Urunlers { get; set; }
        public DbSet<AdminUser> AdminUsers { get; set; }

    }
}
