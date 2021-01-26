namespace Repositorios
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using ModeloDatos;
    using System;
    using System.Collections.Generic;
    using System.Text;

    class RolesConfiguration : IEntityTypeConfiguration<Roles>
    {
        public void Configure(EntityTypeBuilder<Roles> entity)
        {
            entity.HasKey(e => e.Idrol)
                .HasName("PK_roles");

            entity.Property(e => e.Idrol).HasColumnName("idrol");

            entity.Property(e => e.Nombre)
                .IsRequired()
                .HasColumnName("nombre")
                .IsUnicode(false);
            entity.ToTable("Roles");
        }
    }
}
