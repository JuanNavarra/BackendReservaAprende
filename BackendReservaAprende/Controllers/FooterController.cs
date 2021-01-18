/// <summary>
/// Autor Juan Navarra
/// Fecha 17/01/2020
/// </summary>
namespace BackendReservaAprende.Controllers
{
    using DatosDto;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Servicios;
    using System;
    using System.Collections.Generic;

    [Produces("application/json")]
    [Route("api/")]
    [ApiController]
    [AllowAnonymous]
    public class FooterController : Controller
    {
        #region Propiedades
        private readonly IFooterService footerService;
        #endregion

        #region Constructores
        public FooterController(IFooterService footerService)
        {
            this.footerService = footerService;
        }
        #endregion

        #region Metodos y funciones
        /// <summary>
        /// Obtiene el footer
        /// </summary>
        /// <returns></returns>
        [HttpGet("Footer")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ObtenerFooter()
        {
            try
            {
                FooterDto footer = footerService.ObtenerFooter();
                return Json(footer);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Obtiene el footer
        /// </summary>
        /// <returns></returns>
        [HttpGet("EnlaceFooter")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ObtenerEnlaces()
        {
            try
            {
                List<EnlaceFooterDto> enlaces = footerService.ObtenerEnlaces();
                return Json(enlaces);
            }
            catch (Exception e)
            {
                throw;
            }
        }
        #endregion
    }
}
