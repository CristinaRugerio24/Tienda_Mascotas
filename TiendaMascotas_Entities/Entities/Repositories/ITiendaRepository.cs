using TiendaMascotas_Entities.interfaces;

namespace TiendaMascotas_Data.Models.Interfaces
{
    public interface ITiendaRepository
    {
        List<Tienda> GetAllTiendas();
        Tienda GetId(Guid tiendaId);
        Tienda Save(Tienda tienda);
        Tienda Update(Tienda tienda);
        bool Delete(Guid tiendaId); 

    }
}
