/// <summary>
/// Autor Juan Navarra
/// Fecha 17/01/2020
/// </summary>
namespace BackendReservaAprende
{
    using AutoMapper;
    using DatosDto;
    using ModeloDatos;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class MapeoModel: Profile
    {
        #region Construnctores
        public MapeoModel()
        {
            CreateMap<Footer, FooterDto>();
            CreateMap<FooterDto, Footer>();
            CreateMap<EnlaceFooter, EnlaceFooterDto>().
                ForMember(f => f.Enlace, option => option.MapFrom(o => o.Enlance));
            CreateMap<EnlaceFooterDto, EnlaceFooter>()
                .ForMember(f => f.Enlance, option => option.MapFrom(o => o.Enlace));
            CreateMap<Informacion, InformacionDto>();
            CreateMap<InformacionDto, Informacion>();
            CreateMap<Imagenes, ImagenInfoDto>();
            CreateMap<ImagenInfoDto, Imagenes>();
            CreateMap<Lenguaje, LenguajeDto>()
                .ForMember(f => f.Id, option => option.MapFrom(o => o.Idlenguaje))
                .ForMember(f => f.OnAction, option => option.MapFrom(o => o.Estado));
            CreateMap<LenguajeDto, Lenguaje>()
                .ForMember(f => f.Idlenguaje, option => option.MapFrom(o => o.Id))
                .ForMember(f => f.Estado, option => option.MapFrom(o => o.OnAction));
        }
        #endregion
    }
}
