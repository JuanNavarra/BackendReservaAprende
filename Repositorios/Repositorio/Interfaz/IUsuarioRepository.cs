namespace Repositorios
{
    using ModeloDatos;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IUsuarioRepository
    {
        /// <summary>
        /// Guarda un usuario a la base de datos
        /// </summary>
        /// <param name="usuario"></param>
        public void GuardarUsuario(Usuarios usuario);
    }
}
