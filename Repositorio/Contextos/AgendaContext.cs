/// <summary>
/// Autor Juan Navarra
/// Fecha 16/01/2021
/// </summary>
namespace Repositorio
{
    using Datos;
    using Microsoft.EntityFrameworkCore;

    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {
        }
        public virtual DbSet<CarouselHome> CarouselHome { get; set; }
        public virtual DbSet<EnlaceFooter> EnlaceFooter { get; set; }
        public virtual DbSet<Footer> Footer { get; set; }
        public virtual DbSet<Imagenes> Imagenes { get; set; }
        public virtual DbSet<Informacion> Informacion { get; set; }
        public virtual DbSet<Lenguaje> Lenguaje { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CarouselHomeConfiguration());
            modelBuilder.ApplyConfiguration(new EnlaceFooterConfiguration());
            modelBuilder.ApplyConfiguration(new FooterConfiguration());
            modelBuilder.ApplyConfiguration(new ImagenesConfiguration());
            modelBuilder.ApplyConfiguration(new InformacionConfiguration());
            modelBuilder.ApplyConfiguration(new LenguajeConfiguration());
        }
    }
}
