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

    public class InformacionRepository : IInformacionRepository
    {
        #region Propiedades
        private readonly AgendaContext agendaContext;
        #endregion
        #region Constructores
        public InformacionRepository(AgendaContext agendaContext)
        {
            this.agendaContext = agendaContext;
        }
        #endregion
        #region Metodos
        /// <summary>
        /// Obtiene toda la informacion de texto del cuerpo de la pagina
        /// </summary>
        /// <returns></returns>
        public List<Informacion> ObtenerInformacion()
        {
            try
            {
                return agendaContext.Informacion.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
