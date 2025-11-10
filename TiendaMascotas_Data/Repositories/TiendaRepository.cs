using TiendaMascotas_Data.Models.Interfaces;
using TiendaMascotas_Entities.interfaces;

namespace TiendaMascotas_Entities.Repositories
{
    public class TiendaRepository : ITiendaRepository
    {
        public TiendaRepository(TiendaMascotasDbContext tiendaMascotasDbContext) 
        {
        }

        public bool Delete(Guid tiendaId)
        {
            throw new NotImplementedException();
        }

        public List<Tienda> GetAllTiendas()
        {
            throw new NotImplementedException();
        }

        public Tienda GetId(Guid tiendaId)
        {
            throw new NotImplementedException();
        }

        public Tienda Save(Tienda tienda)
        {
            throw new NotImplementedException();
        }

        public Tienda Update(Tienda tienda)
        {
            throw new NotImplementedException();
        }
    }
}
