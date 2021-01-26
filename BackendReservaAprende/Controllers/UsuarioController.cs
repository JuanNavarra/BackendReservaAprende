namespace BackendReservaAprende
{
    using DatosDto;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Servicios;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class UsuarioController : Controller
    {
        #region Propiedades
        private readonly IUsuarioService usuarioService;
        #endregion
        #region Constructores
        public UsuarioController(IUsuarioService usuarioService)
        {
            this.usuarioService = usuarioService;
        }
        #endregion
        #region Metodos y funciones
        /// <summary>
        /// Crea un usuario
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost("crearUsuario")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult CrearUsuario(UsuarioDto user)
        {
            try
            {
                ApiCallResult result = this.usuarioService.GuardarUsuario(user);
                return Json(result);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
