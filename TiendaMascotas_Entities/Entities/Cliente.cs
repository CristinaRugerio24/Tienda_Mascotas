using System.ComponentModel.DataAnnotations;

namespace TiendaMascotas_Entities.interfaces
{

    public class Cliente
    {
        [Key]
        public Guid ClienteId { get; private set; }
        public string Nombre { get; private set; }
        public string ApellidoMaterno { get; private set; }
        public string ApellidoPaterno { get; private set; }
        public string Telefono { get; private set; }
        public string CorreoElectronico { get; private set; }
        public string Contrasenia { get; private set; }

        public virtual List<ClienteArticulo> ClienteArticulos { get; private set; } = new();
    }

}