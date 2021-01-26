namespace Repositorios
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using ModeloDatos;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class UsuariosConfiguration : IEntityTypeConfiguration<Usuarios>
    {
        public void Configure(EntityTypeBuilder<Usuarios> entity)
        {
            entity.HasKey(e => e.Idusuario)
                .HasName("PK_usuarios");

            entity.Property(e => e.Idusuario).HasColumnName("idusuario");

            entity.Property(e => e.Apellido)
                .IsRequired()
                .HasColumnName("apellido")
                .IsUnicode(false);

            entity.Property(e => e.Email)
                .IsRequired()
                .HasColumnName("email")
                .IsUnicode(false);

            entity.Property(e => e.Idioma).HasColumnName("idioma");

            entity.Property(e => e.Nombre)
                .IsRequired()
                .HasColumnName("nombre")
                .IsUnicode(false);

            entity.Property(e => e.Password)
                .IsRequired()
                .HasColumnName("password")
                .IsUnicode(false);

            entity.Property(e => e.Rol).HasColumnName("rol");

            entity.Property(e => e.Telefono)
                .IsRequired()
                .HasColumnName("telefono")
                .IsUnicode(false);
            entity.ToTable("Usuarios");
        }
    }
}
