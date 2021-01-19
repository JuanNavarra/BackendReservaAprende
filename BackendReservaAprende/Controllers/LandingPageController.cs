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
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class LandingPageController : Controller
    {
        #region Propiedades
        private readonly ILandingPageService landingPageService;
        #endregion

        #region Constructores
        public LandingPageController(ILandingPageService landingPageService)
        {
            this.landingPageService = landingPageService;
        }
        #endregion

        #region Metodos y funciones
        /// <summary>
        /// Obtiene el footer
        /// </summary>
        /// <returns></returns>
        [HttpGet("footer")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ObtenerFooter()
        {
            try
            {
                FooterDto footer = landingPageService.ObtenerFooter();
                return Json(footer);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Obtiene los enlaces del footer
        /// </summary>
        /// <returns></returns>
        [HttpGet("enlaceFooter")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ObtenerEnlaces()
        {
            try
            {
                List<EnlaceFooterDto> enlaces = landingPageService.ObtenerEnlaces();
                return Json(enlaces);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Obtiene toda la informacion de texto del cuerpo de la pagina
        /// </summary>
        /// <returns></returns>
        [HttpGet("informacion")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ObtenerInformacion()
        {
            try
            {
                List<InformacionDto> informacionDto = landingPageService.ObtenerInformacion();
                return Json(informacionDto);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
