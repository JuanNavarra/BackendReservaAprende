/// <summary>
/// Autor Juan Navarra
/// Fecha 17/01/2021
/// </summary>
namespace Repositorios
{
    using ModeloDatos;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IFooterRepository
    {
        /// <summary>
        /// Obtiene el footer
        /// </summary>
        /// <returns></returns>
        public Footer ObtenerFooter();
        /// <summary>
        /// Obtiene los enlaces por el footer activo
        /// </summary>
        /// <returns></returns>
        public List<EnlaceFooter> ObtenerEnlaces();
    }
}
