/// <summary>
/// Autor Juan Navarra
/// Fecha 17/01/2020
/// </summary>
namespace Servicios
{
    using ModeloDatos;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IFooterService
    {
        /// <summary>
        /// Obtiene el footer
        /// </summary>
        /// <returns></returns>
        public Footer ObtenerFooter();
    }
}
