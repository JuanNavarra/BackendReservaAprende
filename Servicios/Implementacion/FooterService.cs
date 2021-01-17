/// <summary>
/// Autor Juan Navarra
/// Fecha 17/01/2020
/// </summary>
namespace Servicios
{
    using ModeloDatos;
    using Repositorios;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class FooterService : IFooterService
    {
        #region Propiedades
        private readonly IFooterRepository footerRepository;
        #endregion

        #region Construnctores
        public FooterService(IFooterRepository footerRepository)
        {
            this.footerRepository = footerRepository;
        }
        #endregion

        #region Metodos y funciones
        /// <summary>
        /// Obtiene el footer
        /// </summary>
        /// <returns></returns>
        public Footer ObtenerFooter()
        {
            try
            {
                return footerRepository.ObtenerFooter();
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}
