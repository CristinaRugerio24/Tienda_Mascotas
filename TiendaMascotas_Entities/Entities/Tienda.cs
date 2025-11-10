
using System.ComponentModel.DataAnnotations;

namespace TiendaMascotas_Entities.interfaces
{
    public class Tienda
    {
        [Key]
        public Guid TiendaId { get; private set; }
        public string Sucursal { get; private set; }
        public string DireccionCompleta { get; private set; }

        public virtual List<TiendaArticulo> TiendaArticulos { get; private set; } = new();
    }
}