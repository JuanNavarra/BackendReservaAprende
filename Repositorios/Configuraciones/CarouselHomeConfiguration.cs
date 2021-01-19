namespace Repositorios
{
    using ModeloDatos;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class CarouselHomeConfiguration : IEntityTypeConfiguration<CarouselHome>
    {
        public void Configure(EntityTypeBuilder<CarouselHome> entity)
        {
            entity.HasKey(e => e.Idcarouselhome);

            entity.Property(e => e.Idcarouselhome).HasColumnName("idcarouselhome");

            entity.Property(e => e.Estado).HasColumnName("estado");

            entity.Property(e => e.Prioridad)
                        .IsRequired()
                        .HasColumnName("prioridad");
            entity.ToTable("CarouselHome");
        }
    }
}
