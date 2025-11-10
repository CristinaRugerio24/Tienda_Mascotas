using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaMascotas_Entities.interfaces;

namespace TiendaMascotas_Entities.Entities.Repositories
{
    public interface IClienteRepository
    {
        List<Cliente> GetAllClientes();
        Cliente GetById(Guid clienteId);
        Cliente Save(Cliente cliente);
        Cliente Update(Cliente cliente);
        bool Delete(Guid clienteId);
    }
}
