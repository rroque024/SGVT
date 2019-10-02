using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SGVT.Models
{
    public partial class BD_SGVTContext : DbContext
    {
        public BD_SGVTContext()
        {
        }

        public BD_SGVTContext(DbContextOptions<BD_SGVTContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ComprobantePago> ComprobantePago { get; set; }
        public virtual DbSet<Cotizacion> Cotizacion { get; set; }
        public virtual DbSet<CotizacionxServicio> CotizacionxServicio { get; set; }
        public virtual DbSet<Distrito> Distrito { get; set; }
        public virtual DbSet<EstadoPago> EstadoPago { get; set; }
        public virtual DbSet<EstadoServicio> EstadoServicio { get; set; }
        public virtual DbSet<Pago> Pago { get; set; }
        public virtual DbSet<Pedido> Pedido { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Servicio> Servicio { get; set; }
        public virtual DbSet<TipoCanto> TipoCanto { get; set; }
        public virtual DbSet<TipoCorte> TipoCorte { get; set; }
        public virtual DbSet<TipoCristal> TipoCristal { get; set; }
        public virtual DbSet<TipoPago> TipoPago { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuario { get; set; }
        public virtual DbSet<Trabajador> Trabajador { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-QF1C1KU;Database=BD_SGVT;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ComprobantePago>(entity =>
            {
                entity.HasKey(e => e.PkIdComprobantePago);

                entity.ToTable("Comprobante_Pago");

                entity.Property(e => e.PkIdComprobantePago).HasColumnName("PK_Id_Comprobante_Pago");

                entity.Property(e => e.FkIdPago).HasColumnName("FK_Id_Pago");

                entity.Property(e => e.NCabecera)
                    .HasColumnName("N_Cabecera")
                    .HasMaxLength(200);

                entity.HasOne(d => d.FkIdPagoNavigation)
                    .WithMany(p => p.ComprobantePago)
                    .HasForeignKey(d => d.FkIdPago)
                    .HasConstraintName("FK_Comprobante_Pago_Pago");
            });

            modelBuilder.Entity<Cotizacion>(entity =>
            {
                entity.HasKey(e => e.PkIdCotizacion);

                entity.Property(e => e.PkIdCotizacion).HasColumnName("PK_Id_Cotizacion");

                entity.Property(e => e.FcMontoInicial).HasColumnName("FC_Monto_Inicial");

                entity.Property(e => e.FkDni).HasColumnName("FK_Dni");

                entity.Property(e => e.FkIdPedido).HasColumnName("FK_Id_Pedido");

                entity.HasOne(d => d.FkDniNavigation)
                    .WithMany(p => p.Cotizacion)
                    .HasForeignKey(d => d.FkDni)
                    .HasConstraintName("FK_Cotizacion_Usuario");

                entity.HasOne(d => d.FkIdPedidoNavigation)
                    .WithMany(p => p.Cotizacion)
                    .HasForeignKey(d => d.FkIdPedido)
                    .HasConstraintName("FK_Cotizacion_Pedido");
            });

            modelBuilder.Entity<CotizacionxServicio>(entity =>
            {
                entity.HasKey(e => e.PkIdCotizacionxServicio);

                entity.Property(e => e.PkIdCotizacionxServicio).HasColumnName("PK_Id_CotizacionxServicio");

                entity.Property(e => e.DFecha)
                    .HasColumnName("D_Fecha")
                    .HasColumnType("date");

                entity.Property(e => e.DHora)
                    .HasColumnName("D_Hora")
                    .HasColumnType("datetime");

                entity.Property(e => e.FMontoFinal).HasColumnName("F_MontoFinal");

                entity.Property(e => e.FkIdCotizacion).HasColumnName("FK_Id_Cotizacion");

                entity.Property(e => e.FkIdDistrito).HasColumnName("FK_Id_Distrito");

                entity.Property(e => e.FkIdServicio).HasColumnName("FK_Id_Servicio");

                entity.HasOne(d => d.FkIdCotizacionNavigation)
                    .WithMany(p => p.CotizacionxServicio)
                    .HasForeignKey(d => d.FkIdCotizacion)
                    .HasConstraintName("FK_CotizacionxServicio_Cotizacion");

                entity.HasOne(d => d.FkIdDistritoNavigation)
                    .WithMany(p => p.CotizacionxServicio)
                    .HasForeignKey(d => d.FkIdDistrito)
                    .HasConstraintName("FK_CotizacionxServicio_Distrito");

                entity.HasOne(d => d.FkIdServicioNavigation)
                    .WithMany(p => p.CotizacionxServicio)
                    .HasForeignKey(d => d.FkIdServicio)
                    .HasConstraintName("FK_CotizacionxServicio_Servicio");
            });

            modelBuilder.Entity<Distrito>(entity =>
            {
                entity.HasKey(e => e.PkIdDistrito);

                entity.Property(e => e.PkIdDistrito).HasColumnName("PK_Id_Distrito");

                entity.Property(e => e.IdPesoPrecio).HasColumnName("ID_Peso_Precio");

                entity.Property(e => e.NdDistrito)
                    .HasColumnName("ND_Distrito")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<EstadoPago>(entity =>
            {
                entity.HasKey(e => e.PkIdEstadoPago);

                entity.ToTable("Estado_Pago");

                entity.Property(e => e.PkIdEstadoPago).HasColumnName("PK_Id_Estado_Pago");

                entity.Property(e => e.NeNombre)
                    .HasColumnName("NE_Nombre")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<EstadoServicio>(entity =>
            {
                entity.HasKey(e => e.PkIdEstadoServicio);

                entity.ToTable("Estado_Servicio");

                entity.Property(e => e.PkIdEstadoServicio).HasColumnName("PK_Id_Estado_Servicio");

                entity.Property(e => e.NeNombre)
                    .HasColumnName("NE_Nombre")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Pago>(entity =>
            {
                entity.HasKey(e => e.PkIdPago);

                entity.Property(e => e.PkIdPago).HasColumnName("PK_Id_Pago");

                entity.Property(e => e.DpFecha)
                    .HasColumnName("DP_Fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.FMonto).HasColumnName("F_Monto");

                entity.Property(e => e.FkIdCotizacionxServicio).HasColumnName("FK_Id_CotizacionxServicio");

                entity.Property(e => e.FkIdEstadoPago).HasColumnName("FK_Id_Estado_Pago");

                entity.Property(e => e.FkIdTipoPago).HasColumnName("FK_Id_Tipo_Pago");

                entity.HasOne(d => d.FkIdCotizacionxServicioNavigation)
                    .WithMany(p => p.Pago)
                    .HasForeignKey(d => d.FkIdCotizacionxServicio)
                    .HasConstraintName("FK_Pago_CotizacionxServicio");

                entity.HasOne(d => d.FkIdEstadoPagoNavigation)
                    .WithMany(p => p.Pago)
                    .HasForeignKey(d => d.FkIdEstadoPago)
                    .HasConstraintName("FK_Pago_Estado_Pago");

                entity.HasOne(d => d.FkIdTipoPagoNavigation)
                    .WithMany(p => p.Pago)
                    .HasForeignKey(d => d.FkIdTipoPago)
                    .HasConstraintName("FK_Pago_Tipo_Pago");
            });

            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.HasKey(e => e.PkIdPedido);

                entity.Property(e => e.PkIdPedido)
                    .HasColumnName("PK_Id_Pedido")
                    .ValueGeneratedNever();

                entity.Property(e => e.FAltura).HasColumnName("F_Altura");

                entity.Property(e => e.FAncho).HasColumnName("F_Ancho");

                entity.Property(e => e.FDiametro).HasColumnName("F_Diametro");

                entity.Property(e => e.FkIdProducto).HasColumnName("FK_Id_Producto");

                entity.Property(e => e.FkIdTipoCanto).HasColumnName("FK_Id_Tipo_Canto");

                entity.Property(e => e.FkIdTipoCorte).HasColumnName("FK_Id_Tipo_Corte");

                entity.Property(e => e.FkIdTipoCristal).HasColumnName("FK_Id_Tipo_Cristal");

                entity.Property(e => e.ICantidad).HasColumnName("I_Cantidad");

                entity.HasOne(d => d.FkIdProductoNavigation)
                    .WithMany(p => p.Pedido)
                    .HasForeignKey(d => d.FkIdProducto)
                    .HasConstraintName("FK_Pedido_Producto");

                entity.HasOne(d => d.FkIdTipoCantoNavigation)
                    .WithMany(p => p.Pedido)
                    .HasForeignKey(d => d.FkIdTipoCanto)
                    .HasConstraintName("FK_Pedido_Tipo_Canto");

                entity.HasOne(d => d.FkIdTipoCorteNavigation)
                    .WithMany(p => p.Pedido)
                    .HasForeignKey(d => d.FkIdTipoCorte)
                    .HasConstraintName("FK_Pedido_Tipo_Corte");

                entity.HasOne(d => d.FkIdTipoCristalNavigation)
                    .WithMany(p => p.Pedido)
                    .HasForeignKey(d => d.FkIdTipoCristal)
                    .HasConstraintName("FK_Pedido_Tipo_Cristal");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.PkIdProducto);

                entity.Property(e => e.PkIdProducto).HasColumnName("PK_Id_Producto");

                entity.Property(e => e.EstadoProducto).HasColumnName("Estado_Producto");

                entity.Property(e => e.Imagen).HasColumnName("Imagen");

                entity.Property(e => e.NpDescripcion)
                    .HasColumnName("NP_Descripcion")
                    .HasMaxLength(200);

                entity.Property(e => e.NpNombre)
                    .HasColumnName("NP_Nombre")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Servicio>(entity =>
            {
                entity.HasKey(e => e.PkIdServicio);

                entity.Property(e => e.PkIdServicio).HasColumnName("PK_Id_Servicio");

                entity.Property(e => e.FkIdEstadoServicio).HasColumnName("FK_Id_Estado_Servicio");

                entity.Property(e => e.FkIdTrabajador).HasColumnName("FK_Id_Trabajador");

                entity.Property(e => e.NsNombre)
                    .HasColumnName("NS_Nombre")
                    .HasMaxLength(20);

                entity.HasOne(d => d.FkIdEstadoServicioNavigation)
                    .WithMany(p => p.Servicio)
                    .HasForeignKey(d => d.FkIdEstadoServicio)
                    .HasConstraintName("FK_Servicio_Estado_Servicio");

                entity.HasOne(d => d.FkIdTrabajadorNavigation)
                    .WithMany(p => p.Servicio)
                    .HasForeignKey(d => d.FkIdTrabajador)
                    .HasConstraintName("FK_Servicio_Trabajador");
            });

            modelBuilder.Entity<TipoCanto>(entity =>
            {
                entity.HasKey(e => e.PkIdTipoCanto);

                entity.ToTable("Tipo_Canto");

                entity.Property(e => e.PkIdTipoCanto).HasColumnName("PK_Id_Tipo_Canto");

                entity.Property(e => e.ItcaPrecio).HasColumnName("ITCa_Precio");

                entity.Property(e => e.NtcaDescripcion)
                    .HasColumnName("NTCa_Descripcion")
                    .HasMaxLength(200);

                entity.Property(e => e.NtcaNombre)
                    .HasColumnName("NTCa_Nombre")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<TipoCorte>(entity =>
            {
                entity.HasKey(e => e.PkIdTipoCorte);

                entity.ToTable("Tipo_Corte");

                entity.Property(e => e.PkIdTipoCorte).HasColumnName("PK_Id_Tipo_Corte");

                entity.Property(e => e.ItcoPrecio).HasColumnName("ITCo_Precio");

                entity.Property(e => e.TpcoNombre)
                    .HasColumnName("TPCo_Nombre")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<TipoCristal>(entity =>
            {
                entity.HasKey(e => e.PkIdTipoCristal);

                entity.ToTable("Tipo_Cristal");

                entity.Property(e => e.PkIdTipoCristal).HasColumnName("PK_Id_Tipo_Cristal");

                entity.Property(e => e.ItcPrecio).HasColumnName("ITC_Precio");

                entity.Property(e => e.NtcDescripcion)
                    .HasColumnName("NTC_Descripcion")
                    .HasMaxLength(200);

                entity.Property(e => e.NtcNombre)
                    .HasColumnName("NTC_Nombre")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<TipoPago>(entity =>
            {
                entity.HasKey(e => e.PkIdTipoPago);

                entity.ToTable("Tipo_Pago");

                entity.Property(e => e.PkIdTipoPago).HasColumnName("PK_Id_Tipo_Pago");

                entity.Property(e => e.NtNombre)
                    .HasColumnName("NT_Nombre")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TipoUsuario>(entity =>
            {
                entity.HasKey(e => e.PkIdTipoUsuario);

                entity.ToTable("Tipo_Usuario");

                entity.Property(e => e.PkIdTipoUsuario).HasColumnName("PK_Id_Tipo_Usuario");

                entity.Property(e => e.NtNombre)
                    .HasColumnName("NT_Nombre")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Trabajador>(entity =>
            {
                entity.HasKey(e => e.PkIdTrabajador);

                entity.Property(e => e.PkIdTrabajador).HasColumnName("PK_Id_Trabajador");

                entity.Property(e => e.ItCelular).HasColumnName("IT_Celular");

                entity.Property(e => e.NtAmaterno)
                    .HasColumnName("NT_AMaterno")
                    .HasMaxLength(20);

                entity.Property(e => e.NtApaterno)
                    .HasColumnName("NT_APaterno")
                    .HasMaxLength(20);

                entity.Property(e => e.NtNombre)
                    .HasColumnName("NT_Nombre")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.PkDni);

                entity.Property(e => e.PkDni)
                    .HasColumnName("PK_Dni")
                    .ValueGeneratedNever();

                entity.Property(e => e.FkIdTipoUsuario).HasColumnName("FK_Id_Tipo_Usuario");

                entity.Property(e => e.IuCelular).HasColumnName("IU_Celular");

                entity.Property(e => e.NuAmaterno)
                    .IsRequired()
                    .HasColumnName("NU_AMaterno")
                    .HasMaxLength(20);

                entity.Property(e => e.NuApaterno)
                    .IsRequired()
                    .HasColumnName("NU_APaterno")
                    .HasMaxLength(20);

                entity.Property(e => e.NuContraseña)
                    .IsRequired()
                    .HasColumnName("NU_Contraseña")
                    .HasMaxLength(50);

                entity.Property(e => e.NuCorreo)
                    .IsRequired()
                    .HasColumnName("NU_Correo")
                    .HasMaxLength(30);

                entity.Property(e => e.NuDireccion)
                    .HasColumnName("NU_Direccion")
                    .HasMaxLength(50);

                entity.Property(e => e.NuNombre)
                    .IsRequired()
                    .HasColumnName("NU_Nombre")
                    .HasMaxLength(20);

                entity.HasOne(d => d.FkIdTipoUsuarioNavigation)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.FkIdTipoUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Usuario_Tipo_Usuario");
            });
        }
    }
}
