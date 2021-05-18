using Microsoft.EntityFrameworkCore;

namespace MusicApp
{
    class SqliteDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Db/music.db");
            base.OnConfiguring(optionsBuilder);
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artista>(a => {
                a.Property(p => p.AñoDeNacimiento).HasColumnName("AnioDeNacimiento");
            });

            modelBuilder.Entity<Album>(a => {
                a.Property(p => p.AñoDePublicacion).HasColumnName("AnioDePublicacion");
            });

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Artista> Artistas { get; set; }
        public DbSet<DatosDeContacto> DatosDeContactos { get; set; }
        public DbSet<Critica> Criticas { get; set; }
        public DbSet<Album> Albumes { get; set; }
    }
}