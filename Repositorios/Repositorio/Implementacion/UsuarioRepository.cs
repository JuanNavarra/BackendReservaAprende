namespace Repositorios
{
    using ModeloDatos;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class UsuarioRepository : IUsuarioRepository
    {
        #region Propiedades
        private readonly AgendaContext agendaContext;
        #endregion
        #region Constructores
        public UsuarioRepository(AgendaContext agendaContext)
        {
            this.agendaContext = agendaContext;
        }
        #endregion
        #region Metodos y funciones
        /// <summary>
        /// Guarda un usuario a la base de datos
        /// </summary>
        /// <param name="usuario"></param>
        public void GuardarUsuario(Usuarios usuario)
        {
            try
            {
                agendaContext.Usuarios.Add(usuario);
                agendaContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
