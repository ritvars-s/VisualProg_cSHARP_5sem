using DatuAttelosana.Clases;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatuAttelosana.Models
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = Path.Combine(
                AppContext.BaseDirectory,
                "app.db"
                );
            optionsBuilder.UseSqlite($"Data Source={path}");



        }
    }
}
