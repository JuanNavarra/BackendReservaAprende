/// <summary>
/// Autor Juan Navarra
/// Fecha 17/01/2020
/// </summary>
namespace Servicios
{
    using AutoMapper;
    using DatosDto;
    using ModeloDatos;
    using Repositorios;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class LandingPageService : ILandingPageService
    {
        #region Propiedades
        private readonly IFooterRepository footerRepository;
        private readonly IInformacionRepository informacionRepository;
        private readonly IMapper mapper;
        #endregion

        #region Construnctores
        public LandingPageService(IFooterRepository footerRepository, IMapper mapper, IInformacionRepository informacionRepository)
        {
            this.footerRepository = footerRepository;
            this.mapper = mapper;
            this.informacionRepository = informacionRepository;
        }
        #endregion

        #region Metodos y funciones
        /// <summary>
        /// Obtiene el footer
        /// </summary>
        /// <returns></returns>
        public FooterDto ObtenerFooter()
        {
            try
            {
                Footer footer = footerRepository.ObtenerFooter();
                FooterDto footerDto = mapper.Map<Footer, FooterDto>(footer);
                return footerDto;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Obtiene los enlaces por el footer activo
        /// </summary>
        /// <returns></returns>
        public List<EnlaceFooterDto> ObtenerEnlaces()
        {
            try
            {
                List<EnlaceFooter> enlaces = footerRepository.ObtenerEnlaces();
                List<EnlaceFooterDto> enlacesDto = mapper.Map<List<EnlaceFooterDto>>(enlaces);
                return enlacesDto;
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
        public List<InformacionDto> ObtenerInformacion()
        {
            try
            {
                List<Informacion> informacion = informacionRepository.ObtenerInformacion();
                List<InformacionDto> informacionDto = mapper.Map<List<InformacionDto>>(informacion);
                return informacionDto;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
