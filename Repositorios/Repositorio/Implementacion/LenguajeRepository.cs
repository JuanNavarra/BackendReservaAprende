namespace Repositorios
{
    using DatosDto;
    using ModeloDatos;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class LenguajeRepository : ILenguajeRepository
    {
        #region Propiedades
        private readonly AgendaContext agendaContext;
        #endregion
        #region Constructores
        public LenguajeRepository(AgendaContext agendaContext)
        {
            this.agendaContext = agendaContext;
        }
        #endregion
        #region Metodos y funciones

        /// <summary>
        /// Obtiene todos los lenguajes disponibles del header
        /// </summary>
        /// <returns></returns>
        public List<LenguajeDto> ObtenerLenguajes()
        {
            try
            {
                List<LenguajeDto> lenguajes = (from t0 in agendaContext.Lenguaje
                                               join t1 in agendaContext.Imagenes on t0.Idlenguaje equals t1.Idlenguaje
                                               where t1.Idlenguaje != null && t1.Activo
                                               select new LenguajeDto
                                               {
                                                   OnAction = t0.Estado,
                                                   Flag = t1.Rutaimagen,
                                                   Id = t0.Idlenguaje,
                                                   Nombre = t0.Nombre
                                               }).ToList();
                return lenguajes;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Actualiza la bandera del hedear del landing page
        /// </summary>
        /// <param name="id"></param>
        /// <param name="estado"></param>
        /// <returns></returns>
        public void ActualiarBandera(int id, bool estado)
        {
            try
            {
                Lenguaje bandera = agendaContext.Lenguaje.Where(w => w.Idlenguaje == id).FirstOrDefault();
                bandera.Estado = estado;
                agendaContext.Lenguaje.Update(bandera);
                agendaContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Obtiene un lenguaje dado un id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Lenguaje ObtenerLenguajeId(int id)
        {
            try
            {
                Lenguaje lenguaje = agendaContext.Lenguaje.Where(w => w.Idlenguaje == id).FirstOrDefault();
                return lenguaje;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
