using Microsoft.EntityFrameworkCore;
using SavManagementApp.Models;

namespace SavManagementApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Reclamation> Reclamations { get; set; }
        public DbSet<Intervention> Interventions { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Technicien> Techniciens { get; set; }
    }
}
