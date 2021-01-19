namespace Repositorios
{
    using DatosDto;
    using ModeloDatos;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ImagenRepository : IImagenRepository
    {
        #region Propiedades
        private readonly AgendaContext agendaContext;
        #endregion
        #region Constructores
        public ImagenRepository(AgendaContext agendaContext)
        {
            this.agendaContext = agendaContext;
        }
        #endregion
        #region Metodos y funciones
        /// <summary>
        /// Obtiene las imagenes del carousel que van en la informacion
        /// </summary>
        /// <returns></returns>
        public List<Imagenes> ObtenerImagenesInfo()
        {
            return this.agendaContext.Imagenes.ToList();
        }

        /// <summary>
        /// Obtiene las imagenes del carousel
        /// </summary>
        /// <returns></returns>
        public List<CarouselImgDto> ObtenerImagenesCarousel()
        {
            try
            {
                List<CarouselImgDto> carouselImgDtos = (from t0 in agendaContext.CarouselHome
                         join t1 in agendaContext.Imagenes on t0.Idcarouselhome equals t1.Idcarouselhome
                         where t1.Idcarouselhome != null && t0.Estado
                         select new CarouselImgDto
                         {
                             Activo = t1.Activo,
                             Rutaimagen = t1.Rutaimagen
                         }).ToList();
                return carouselImgDtos;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}
