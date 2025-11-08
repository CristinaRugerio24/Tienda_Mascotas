using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
//using TiendaMascotas.Entities;

public class TiendaMascotasDbContext : DbContext
{
    public TiendaMascotasDbContext(DbContextOptions<TiendaMascotasDbContext> options)
    : base(options)
    {
    }

    public DbSet<Tienda> Tienda { get; set; }
    public DbSet<Clientes> Clientes { get; set; }
    public DbSet<Articulos> Articulos { get; set; }

    public DbSet<ArticuloTienda> ArticuloTiendas { get; set; }
    public DbSet<ClienteArticulo> ClienteArticulo { get; set; }

}