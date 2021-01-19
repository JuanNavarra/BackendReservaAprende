namespace Repositorios
{
    using ModeloDatos;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IInformacionRepository
    {
        /// <summary>
        /// Obtiene toda la informacion de texto del cuerpo de la pagina
        /// </summary>
        /// <returns></returns>
        public List<Informacion> ObtenerInformacion();
    }
}
