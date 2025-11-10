using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaMascotas_Entities.interfaces
{
    [Index(nameof(TiendaId), nameof(ArticuloId), IsUnique = true)]
    public class TiendaArticulo
    {
        [Key]
        public Guid ArticuloTiendaId { get; private set; }
        [ForeignKey("Tienda")]
        public Guid TiendaId { get; private set; }
        public virtual Tienda Tienda { get; private set; }

        [ForeignKey("Articulo")]
        public Guid ArticuloId { get; private set; }
        public virtual Articulo Articulo { get; private set; }

        public DateTime Fecha { get; private set; }
    }
}