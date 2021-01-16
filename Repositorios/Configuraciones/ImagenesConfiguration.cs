namespace Repositorios
{
    using ModeloDatos;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ImagenesConfiguration : IEntityTypeConfiguration<Imagenes>
    {
        public void Configure(EntityTypeBuilder<Imagenes> entity)
        {
            entity.HasKey(e => e.Idimageninfo)
                .HasName("PK_ImagenInfo");

            entity.Property(e => e.Idimageninfo).HasColumnName("idimageninfo");

            entity.Property(e => e.Idcarouselhome).HasColumnName("idcarouselhome");

            entity.Property(e => e.Idinformacion).HasColumnName("idinformacion");

            entity.Property(e => e.Idlenguaje).HasColumnName("idlenguaje");

            entity.Property(e => e.Idlogo).HasColumnName("idlogo");

            entity.Property(e => e.Rutaimagen)
                .IsRequired()
                .HasColumnName("rutaimagen")
                .IsUnicode(false);
            entity.ToTable("Imagenes");
        }
    }
}
