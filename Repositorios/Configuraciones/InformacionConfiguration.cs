namespace Repositorios
{
    using ModeloDatos;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class InformacionConfiguration : IEntityTypeConfiguration<Informacion>
    {
        public void Configure(EntityTypeBuilder<Informacion> entity)
        {
            entity.HasKey(e => e.Idinformacion);

            entity.Property(e => e.Idinformacion).HasColumnName("idinformacion");

            entity.Property(e => e.Rutaimagen)
                .IsRequired()
                .HasColumnName("rutaimagen")
                .IsUnicode(false);

            entity.Property(e => e.Textogrande)
                .IsRequired()
                .HasColumnName("textogrande")
                .IsUnicode(false);

            entity.Property(e => e.Textopequeno)
                .IsRequired()
                .HasColumnName("textopequeno")
                .IsUnicode(false);

            entity.Property(e => e.Titulo)
                .IsRequired()
                .HasColumnName("titulo")
                .IsUnicode(false);
            entity.ToTable("Informacion");
        }
    }
}
