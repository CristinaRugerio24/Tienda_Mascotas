using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaMascotas_Entities.interfaces;

namespace TiendaMascotas_Entities.Entities.Repositories
{
    public interface IArticuloRepository
    {
        List<Articulo> GetAllArticulos();
        Articulo GetById(Guid articuloId);
        Articulo Save(Articulo articulo);
        Articulo Update(Articulo articulo);
        bool Delete(Guid articuloId);
    }
}
