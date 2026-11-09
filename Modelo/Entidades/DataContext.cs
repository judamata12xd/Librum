using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Modelo.Entidades;

public partial class DataContext : DbContext
{
    public DataContext()
    {
    }

    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Autore> Autores { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Lectore> Lectores { get; set; }

    public virtual DbSet<Libro> Libros { get; set; }

    public virtual DbSet<Multum> Multa { get; set; }

    public virtual DbSet<Prestamo> Prestamos { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<VwHistorialPrestamo> VwHistorialPrestamos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=Biblioteca;Integrated Security=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Autore>(entity =>
        {
            entity.HasKey(e => e.Idautor).HasName("PK__Autores__6FC41E3CB5C88337");

            entity.Property(e => e.Idautor).HasColumnName("idautor");
            entity.Property(e => e.Nombre)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.IdEmpleado).HasName("PK__Empleado__5295297C18153939");

            entity.ToTable("Empleado");

            entity.HasIndex(e => e.Usuario, "UQ__Empleado__9AFF8FC6D3B4EEB2").IsUnique();

            entity.HasIndex(e => e.Documento, "UQ__Empleado__A25B3E6164FE9ECD").IsUnique();

            entity.Property(e => e.IdEmpleado).HasColumnName("idEmpleado");
            entity.Property(e => e.Clave)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Documento)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("documento");
            entity.Property(e => e.Idrol).HasColumnName("idrol");
            entity.Property(e => e.Nombre)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Usuario)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("usuario");

            entity.HasOne(d => d.IdrolNavigation).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.Idrol)
                .HasConstraintName("FK__Empleado__idrol__4E88ABD4");
        });

        modelBuilder.Entity<Lectore>(entity =>
        {
            entity.HasKey(e => e.Idlector).HasName("PK__Lectores__B7BB5B95850E2808");

            entity.HasIndex(e => e.Usuario, "UQ__Lectores__9AFF8FC6AE33F6D7").IsUnique();

            entity.HasIndex(e => e.Documento, "UQ__Lectores__A25B3E615A2EAFF8").IsUnique();

            entity.Property(e => e.Idlector).HasColumnName("idlector");
            entity.Property(e => e.Clave)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Documento)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("documento");
            entity.Property(e => e.Idrol).HasColumnName("idrol");
            entity.Property(e => e.Nombre)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.TipoLector)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tipoLector");
            entity.Property(e => e.Usuario)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("usuario");

            entity.HasOne(d => d.IdrolNavigation).WithMany(p => p.Lectores)
                .HasForeignKey(d => d.Idrol)
                .HasConstraintName("FK__Lectores__idrol__59063A47");
        });

        modelBuilder.Entity<Libro>(entity =>
        {
            entity.HasKey(e => e.Codlibro).HasName("PK__Libro__E6A5973A19D8793E");

            entity.ToTable("Libro");

            entity.Property(e => e.Codlibro)
                .ValueGeneratedNever()
                .HasColumnName("codlibro");
            entity.Property(e => e.Disponible)
                .HasDefaultValue(0)
                .HasColumnName("disponible");
            entity.Property(e => e.Idautor).HasColumnName("idautor");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdautorNavigation).WithMany(p => p.Libros)
                .HasForeignKey(d => d.Idautor)
                .HasConstraintName("FK__Libro__idautor__5441852A");
        });

        modelBuilder.Entity<Multum>(entity =>
        {
            entity.HasKey(e => e.Idmulta).HasName("PK__Multa__4E89655DDCAF91C5");

            entity.Property(e => e.Idmulta).HasColumnName("idmulta");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("P")
                .IsFixedLength()
                .HasColumnName("estado");
            entity.Property(e => e.IdPrestamo).HasColumnName("idPrestamo");
            entity.Property(e => e.Valor)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("valor");

            entity.HasOne(d => d.IdPrestamoNavigation).WithMany(p => p.Multa)
                .HasForeignKey(d => d.IdPrestamo)
                .HasConstraintName("FK__Multa__idPrestam__6477ECF3");
        });

        modelBuilder.Entity<Prestamo>(entity =>
        {
            entity.HasKey(e => e.IdPrestamo).HasName("PK__Prestamo__A4876C13FD52D89F");

            entity.Property(e => e.IdPrestamo).HasColumnName("idPrestamo");
            entity.Property(e => e.Codlibro).HasColumnName("codlibro");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("A")
                .IsFixedLength()
                .HasColumnName("estado");
            entity.Property(e => e.FechaDevolucionE)
                .HasColumnType("datetime")
                .HasColumnName("fechaDevolucionE");
            entity.Property(e => e.FechaDevolucionR)
                .HasColumnType("datetime")
                .HasColumnName("fechaDevolucionR");
            entity.Property(e => e.FechaPrestamo)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaPrestamo");
            entity.Property(e => e.IdEmpleado).HasColumnName("idEmpleado");
            entity.Property(e => e.Idlector).HasColumnName("idlector");

            entity.HasOne(d => d.CodlibroNavigation).WithMany(p => p.Prestamos)
                .HasForeignKey(d => d.Codlibro)
                .HasConstraintName("FK__Prestamos__codli__5DCAEF64");

            entity.HasOne(d => d.IdEmpleadoNavigation).WithMany(p => p.Prestamos)
                .HasForeignKey(d => d.IdEmpleado)
                .HasConstraintName("FK__Prestamos__idEmp__5FB337D6");

            entity.HasOne(d => d.IdlectorNavigation).WithMany(p => p.Prestamos)
                .HasForeignKey(d => d.Idlector)
                .HasConstraintName("FK__Prestamos__idlec__5EBF139D");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Idrol).HasName("PK__Roles__24C6BB20346B8492");

            entity.Property(e => e.Idrol).HasColumnName("idrol");
            entity.Property(e => e.NombreRol)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombreRol");
        });

        modelBuilder.Entity<VwHistorialPrestamo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_HistorialPrestamos");

            entity.Property(e => e.DocumentoLector)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.EstadoPrestamo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FechaEsperada).HasColumnType("datetime");
            entity.Property(e => e.FechaPrestamo).HasColumnType("datetime");
            entity.Property(e => e.NombreLector)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.NombreLibro)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.TipoLector)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
