using System.ComponentModel;


namespace Domain.Exceptions
{
    public enum CodigosRespuestaAuth
    {
        [Description("Se proceso la solicitud correctamente")]
        Succes_01 = 1,

        [Description("No se pueden utilizar los servicios de {0} ya que se requiere de un usuario autenticado")]
        Error_Auth = 500,
        [Description("El modulo que intentas modificar no existe")]
        Error_Modulo_01 = 501,
        [Description("Si el permiso no es indefinido se deben de enviar las fechas correspondientes")]
        Error_OperacionEspecial_01 = 502,
        [Description("Ocurrio un erro al actualizar el area")]
        Error_Area_Update = 503,
        [Description("No se encuentra la aplicación con el id {0}")]
        Error_Aplicacion=504,
        [Description("No se enviaron perfiles que buscar")]
        Error_Perfil=505,
        [Description("No se encuentra el usuario con el id {0}")]
        Error_Usuario=506,
        [Description("No se encuentra el pefil de la aplicacion con el id {0}")]
        Error_Modulo_507=507,
        [Description("No se encuentra el usuario perfil aplicacion con el id {0}")]
        Error_Modulo_508 = 508,
        [Description("No se enviaron operaciones que buscar")]
        Error_Operacion=509

    }
}
