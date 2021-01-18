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
        }
        #endregion
    }
}
