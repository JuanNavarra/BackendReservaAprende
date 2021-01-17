namespace BackendReservaAprende.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Servicios;
    using System;

    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class FooterController : Controller
    {
        private readonly IFooterService footerService;
        public FooterController(IFooterService footerService)
        {
            this.footerService = footerService;
        }

        /// <summary>
        /// Obtiene el footer
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ObtenerFooter()
        {
            try
            {
                var footer = footerService.ObtenerFooter();
                return Json(footer);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
