using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaMascotas_Entities.interfaces
{
    [Index(nameof(ClienteId), nameof(ArticuloId), IsUnique = true)]
    public class ClienteArticulo
    {
        [Key]
        public Guid ClienteArticuloId { get; private set; }
        [ForeignKey("Cliente")]
        public Guid ClienteId { get; private set; }

        public virtual Cliente Cliente { get; private set; }

        [ForeignKey("Articulo")]
        public Guid ArticuloId { get; private set; }

        public virtual Articulo Articulo { get; private set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Cantidad { get; private set; }
        public DateTime Fecha { get; private set; }


    }
}