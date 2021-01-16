namespace Repositorios
{
    using ModeloDatos;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class FooterConfiguration : IEntityTypeConfiguration<Footer>
    {
        public void Configure(EntityTypeBuilder<Footer> entity)
        {
            entity.HasKey(e => e.Idfooter);

            entity.Property(e => e.Idfooter).HasColumnName("idfooter");

            entity.Property(e => e.Descripcion)
                .IsRequired()
                .HasColumnName("descripcion")
                .IsUnicode(false);

            entity.Property(e => e.Version)
                .IsRequired()
                .HasColumnName("version")
                .IsUnicode(false);
            entity.ToTable("Footer");
        }
    }
}
