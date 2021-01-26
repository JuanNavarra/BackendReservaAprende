namespace Servicios
{
    using DatosDto;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IUsuarioService
    {
        /// <summary>
        /// Guarda un usuario a la base de datos
        /// </summary>
        /// <param name="usuario"></param>
        public ApiCallResult GuardarUsuario(UsuarioDto usuarioDto);
    }
}
