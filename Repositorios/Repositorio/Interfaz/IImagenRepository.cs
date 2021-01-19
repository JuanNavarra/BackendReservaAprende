namespace Repositorios
{
    using DatosDto;
    using ModeloDatos;
    using System.Collections.Generic;

    public interface IImagenRepository
    {
        /// <summary>
        /// Obtiene las imagenes del carousel que van en la informacion
        /// </summary>
        /// <returns></returns>
        public List<Imagenes> ObtenerImagenesInfo();
        /// <summary>
        /// Obtiene las imagenes del carousel
        /// </summary>
        /// <returns></returns>
        public List<CarouselImgDto> ObtenerImagenesCarousel();
    }
}
