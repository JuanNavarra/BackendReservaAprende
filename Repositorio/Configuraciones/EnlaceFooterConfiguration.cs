namespace Repositorio
{
    using Datos;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System;
    using System.Collections.Generic;
    using System.Text;

    class EnlaceFooterConfiguration : IEntityTypeConfiguration<EnlaceFooter>
    {
        public void Configure(EntityTypeBuilder<EnlaceFooter> entity)
        {
            entity.HasKey(e => e.Idenlace);

            entity.Property(e => e.Idenlace).HasColumnName("idenlace");

            entity.Property(e => e.Enlance)
                .IsRequired()
                .HasColumnName("enlance")
                .IsUnicode(false);

            entity.Property(e => e.Idfooter).HasColumnName("idfooter");

            entity.Property(e => e.Nombre)
                .IsRequired()
                .HasColumnName("nombre")
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.ToTable("EnlaceFooter");
        }
    }
}
