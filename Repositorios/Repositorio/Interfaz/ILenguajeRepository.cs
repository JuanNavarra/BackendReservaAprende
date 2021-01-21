namespace Repositorios
{
    using DatosDto;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface ILenguajeRepository
    {
        /// <summary>
        /// Obtiene todos los lenguajes disponibles del header
        /// </summary>
        /// <returns></returns>
        public List<LenguajeDto> ObtenerLenguajes();

        /// <summary>
        /// Actualiza la bandera del hedear del landing page
        /// </summary>
        /// <param name="id"></param>
        /// <param name="estado"></param>
        /// <returns></returns>
        public void ActualiarBandera(int id, bool estado);
    }
}
