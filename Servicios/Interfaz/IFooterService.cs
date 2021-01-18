/// <summary>
/// Autor Juan Navarra
/// Fecha 17/01/2020
/// </summary>
namespace Servicios
{
    using DatosDto;
    using ModeloDatos;
    using System.Collections.Generic;

    public interface IFooterService
    {
        /// <summary>
        /// Obtiene el footer
        /// </summary>
        /// <returns></returns>
        public FooterDto ObtenerFooter();

        /// <summary>
        /// Obtiene los enlaces por el footer activo
        /// </summary>
        /// <returns></returns>
        public List<EnlaceFooterDto> ObtenerEnlaces();
    }
}
