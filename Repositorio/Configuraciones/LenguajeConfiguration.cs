namespace Repositorio
{
    using Datos;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class LenguajeConfiguration : IEntityTypeConfiguration<Lenguaje>
    {
        public void Configure(EntityTypeBuilder<Lenguaje> entity)
        {
            entity.HasKey(e => e.Idlenguaje);

            entity.Property(e => e.Idlenguaje).HasColumnName("idlenguaje");

            entity.Property(e => e.Estado).HasColumnName("estado");

            entity.Property(e => e.Nombre)
                .IsRequired()
                .HasColumnName("nombre")
                .IsUnicode(false);
            entity.ToTable("Lenguaje");
        }
    }
}