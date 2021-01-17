/// <summary>
/// Autor Juan Navarra
/// Fecha 17/01/2020
/// </summary>
namespace Repositorios
{
    using ModeloDatos;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class FooterRepository : IFooterRepository
    {
        #region Propiedades
        private readonly AgendaContext AgendaContext;
        #endregion

        #region Construnctores
        public FooterRepository(AgendaContext agendaContext)
        {
            this.AgendaContext = agendaContext;
        }
        #endregion

        #region Funciones y Metodos
        /// <summary>
        /// Obtiene el footer
        /// </summary>
        /// <returns></returns>
        public Footer ObtenerFooter()
        {
            return AgendaContext.Footer.FirstOrDefault();
        }

        /// <summary>
        /// Obtiene los enlaces por el footer activo
        /// </summary>
        /// <returns></returns>
        public List<EnlaceFooter> ObtenerEnlaces()
        {
            int footer = ObtenerFooter().Idfooter;
            return AgendaContext.EnlaceFooter.Where(w => w.Idfooter == footer).ToList();
        }
        #endregion
    }
}
