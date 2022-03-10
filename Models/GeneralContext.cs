using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class GeneralContext : DbContext
    {
        public GeneralContext(DbContextOptions<GeneralContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Persona> Persona {get; set;}
        public DbSet<Ciudad> Ciudad {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
            .HasOne(b => b.Persona)
            .WithOne(i=>i.user)
            .HasForeignKey<Persona>(b => b.UserFK);
            modelBuilder.Entity<Persona>()
            .HasOne(p => p.Ciudad)
            .WithMany(b => b.Persona)
            .HasForeignKey(b => b.CiudadFK);
        }
    }
}