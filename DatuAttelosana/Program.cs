using DatuAttelosana.Models;
using Microsoft.EntityFrameworkCore;

namespace DatuAttelosana
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            
            ApplicationConfiguration.Initialize();

            AppDbContext db = new AppDbContext();
            db.Clients.ExecuteDelete();
            db.Invoices.ExecuteDelete();
            db.Payments.ExecuteDelete();

            db.Database.ExecuteSqlRaw(
                "DELETE FROM sqlite_sequence WHERE name = 'Clients'"
                );
            db.Database.ExecuteSqlRaw(
                "DELETE FROM sqlite_sequence WHERE name = 'Invoices'"
                );
            db.Database.ExecuteSqlRaw(
                "DELETE FROM sqlite_sequence WHERE name = 'Payments'"
                );

            Seeders.DataSeeder.SeedDataBase();
            Application.Run(new Form1());
        }
    }
}