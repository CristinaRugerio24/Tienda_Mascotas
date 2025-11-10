using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaMascotas_Entities.interfaces
{
    public class Articulo
    {
        [Key]
        public Guid ArticuloId { get; private set; }
        public int Codigo { get; private set; }
        public string Nombre { get; private set; }
        public string Descripcion { get; private set; }
        
        [Column(TypeName = "decimal(10,2)")]
        public decimal Precio { get; private set; }
        public int Stock { get; private set; }
        public string Imagen { get; private set; }

        public virtual List<ClienteArticulo> ClienteArticulos { get; private set; } = new();

        public virtual List<TiendaArticulo> TiendaArticulos { get; private set; } = new();

    }
}