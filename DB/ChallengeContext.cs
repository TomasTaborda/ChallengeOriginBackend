using Microsoft.EntityFrameworkCore;

namespace DB
{
    public class ChallengeContext : DbContext
    {
        public ChallengeContext(DbContextOptions<ChallengeContext> options) : base(options)
        {

        }
        public DbSet<Tarjeta> Tarjetas { get; set; }
        public DbSet<Movimiento> Movimientos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tarjeta>()
                .ToTable("Tarjeta")
                .HasData(
                    new Tarjeta
                    {
                        Id = 1,
                        NumeroTarjeta = 4512365452557852,
                        Pin = 1234,
                        Activa = true,
                        Balance = 1000,
                        FechaVencimiento = new DateOnly(2024, 12, 31)
                    },
                    new Tarjeta
                    {
                        Id = 2,
                        NumeroTarjeta = 4512365452557853,
                        Pin = 1235,
                        Activa = true,
                        Balance = 2000,
                        FechaVencimiento = new DateOnly(2025, 1, 31)
                    },
                    new Tarjeta
                    {
                        Id = 3,
                        NumeroTarjeta = 4512365452557854,
                        Pin = 1236,
                        Activa = false,
                        Balance = 3000,
                        FechaVencimiento = new DateOnly(2025, 2, 28)
                    },
                    new Tarjeta
                    {
                        Id = 4,
                        NumeroTarjeta = 4512365452557855,
                        Pin = 1237,
                        Activa = true,
                        Balance = 4000,
                        FechaVencimiento = new DateOnly(2025, 3, 31)
                    },
                    new Tarjeta
                    {
                        Id = 5,
                        NumeroTarjeta = 4512365452557856,
                        Pin = 1238,
                        Activa = false,
                        Balance = 5000,
                        FechaVencimiento = new DateOnly(2025, 4, 30)
                    });
            modelBuilder.Entity<Movimiento>()
                .ToTable("Movimiento")
                .HasOne(m => m.Tarjeta)
                .WithMany(t => t.Movimientos)
                .HasForeignKey(m => m.TarjetaId);

            modelBuilder.Entity<Movimiento>()
                .HasData(
                    new Movimiento
                    {
                        IdOperacion = 1,
                        TarjetaId = 1,
                        Monto = 1000,
                        Fecha = DateTime.Now
                    },
                    new Movimiento
                    {
                        IdOperacion = 2,
                        TarjetaId = 2,
                        Monto = 2000,
                        Fecha = DateTime.Now
                    },
                    new Movimiento
                    {
                        IdOperacion = 3,
                        TarjetaId = 3,
                        Monto = 50,
                        Fecha = DateTime.Now
                    },
                    new Movimiento
                    {
                        IdOperacion = 4,
                        TarjetaId = 4,
                        Monto = 1500,
                        Fecha = DateTime.Now
                    }
                );


        }
    }
}
