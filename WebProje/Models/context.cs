using static WebProje.Models.Context;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebProje.Models
{
    public class Context:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-AQGNSHA;Initial Catalog=WebProjeDb;Integrated Security=True");
        }

        public DbSet<Duyuru> Duyurus { get; set; }
        public DbSet<AdminUser> AdminUsers { get; set; }

    }
}
