using Azure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TiendaMascotas_Business.Services.Login;

namespace TiendaMascotas.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AplicacionController : ControllerBase
    {
        private readonly IInicioSesionService _inicioSesionService;
        public AplicacionController(IInicioSesionService inicioSesionService)
        {
            _inicioSesionService = inicioSesionService;
        }
        /// <summary>
        /// Devuelve el total de aplicaciones existentes en la base de datos
        /// </summary>
        /// <param name="comboInputModel"></param>
        /// <returns></returns>
        //[ProducesResponseType(typeof(Response<DataOutputModel<AplicacionOutputModel>>), 200)]
        //[ProducesResponseType(typeof(Response<IEnumerable<string>>), 400)]
        //[ProducesResponseType(typeof(Response), 500)]
        //[HttpGet]
        //public async Task<IActionResult> GetAll([FromQuery] DataInputModel comboInputModel, bool? activo)
        //{
        //}
    }

}