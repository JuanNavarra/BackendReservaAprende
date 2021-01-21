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

        /// <summary>
        /// Obtiene las imagenes del carousel que van en la informacion
        /// </summary>
        /// <returns></returns>
        [HttpGet("imagenes")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ObtenerImagenes()
        {
            try
            {
                List<ImagenInfoDto> imagenDto = landingPageService.ObtenerImagenesInfo();
                return Json(imagenDto);
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Obtiene las imagenes del carousel
        /// </summary>
        /// <returns></returns>
        [HttpGet("carouselImg")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ObtenerImagenesCarousel()
        {
            try
            {
                List<CarouselImgDto> carouselImgDto = this.landingPageService.ObtenerImagenesCarousel();
                return Json(carouselImgDto);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Obtiene todos los lenguajes disponibles del header
        /// </summary>
        /// <returns></returns>
        [HttpGet("lenguajes")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ObtenerLenguajes()
        {
            try
            {
                List<LenguajeDto> lenguajes = this.landingPageService.ObtenerLenguajes();
                return Json(lenguajes);
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
        /// <returns></returns>
        [HttpPut("lenguaje/{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ActualizarBandera(int id)
        {
            try
            {
                ApiCallResult result = landingPageService.ActualiarBandera(id);
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
