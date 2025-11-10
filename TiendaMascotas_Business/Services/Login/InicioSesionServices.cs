using System.Collections.Generic;
using TiendaMascotas_Data.Models.Interfaces;

namespace TiendaMascotas_Business.Services.Login
{
    public class InicioSesionServices : IInicioSesionService
    {
        private readonly ITiendaRepository _tiendaRepository;
        private readonly IInicioSesionService _inicioSesionService;
       
        public InicioSesionServices(
            ITiendaRepository tiendaRepository,
            IInicioSesionService inicioSesionService)
        {
            tiendaRepository = _tiendaRepository;
            inicioSesionService = _inicioSesionService;
        }
    }
}