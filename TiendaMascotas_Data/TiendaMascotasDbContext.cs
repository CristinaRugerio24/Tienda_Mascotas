using Microsoft.EntityFrameworkCore;
using TiendaMascotas_Entities.interfaces;

public class TiendaMascotasDbContext : DbContext
{

    public DbSet<Tienda> Tienda { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Articulo> Articulos { get; set; }

    public DbSet<TiendaArticulo> ArticuloTiendas { get; set; }
    public DbSet<ClienteArticulo> ClienteArticulo { get; set; }

    public TiendaMascotasDbContext(DbContextOptions<TiendaMascotasDbContext> options) : base(options)
    {
    }
}