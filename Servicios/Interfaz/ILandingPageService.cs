/// <summary>
/// Autor Juan Navarra
/// Fecha 17/01/2020
/// </summary>
namespace Servicios
{
    using DatosDto;
    using ModeloDatos;
    using System.Collections.Generic;

    public interface ILandingPageService
    {
        /// <summary>
        /// Obtiene el footer
        /// </summary>
        /// <returns></returns>
        public FooterDto ObtenerFooter();

        /// <summary>
        /// Obtiene los enlaces por el footer activo
        /// </summary>
        /// <returns></returns>
        public List<EnlaceFooterDto> ObtenerEnlaces();

        /// <summary>
        /// Obtiene toda la informacion de texto del cuerpo de la pagina
        /// </summary>
        /// <returns></returns>
        public List<InformacionDto> ObtenerInformacion();
        /// <summary>
        /// Obtiene las imagenes del carousel que van en la informacion
        /// </summary>
        /// <returns></returns>
        public List<ImagenInfoDto> ObtenerImagenesInfo();
        /// <summary>
        /// Obtiene las imagenes del carousel
        /// </summary>
        /// <returns></returns>
        public List<CarouselImgDto> ObtenerImagenesCarousel();
        /// <summary>
        /// Obtiene todos los lenguajes disponibles del header
        /// </summary>
        /// <returns></returns>
        public List<LenguajeDto> ObtenerLenguajes();
        /// <summary>
        /// Actualiza la bandera del hedear del landing page
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ApiCallResult ActualiarBandera(int id);
        /// <summary>
        /// Obtiene un lenguaje dado un id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public LenguajeDto ObtenerLenguajeId(int id);
    }
}
