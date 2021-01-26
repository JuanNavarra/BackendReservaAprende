namespace Servicios
{
    using AutoMapper;
    using DatosDto;
    using ModeloDatos;
    using Repositorios;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class UsuarioService : IUsuarioService
    {
        #region Propiedades
        private readonly IUsuarioRepository usuarioRepository;
        private readonly IMapper mapper;
        private readonly ILandingPageService landingPageService;
        #endregion
        #region Constructores
        public UsuarioService(IUsuarioRepository usuarioRepository, IMapper mapper, ILandingPageService landingPageService)
        {
            this.usuarioRepository = usuarioRepository;
            this.mapper = mapper;
            this.landingPageService = landingPageService;
        }
        #endregion
        #region Metodos y funciones
        /// <summary>
        /// Guarda un usuario a la base de datos
        /// </summary>
        /// <param name="usuario"></param>
        public ApiCallResult GuardarUsuario(UsuarioDto usuarioDto)
        {
            try
            {
                if (usuarioDto == null)
                    throw new Exception("Objeto vacio");

                LenguajeDto lenguajeDto = this.landingPageService.ObtenerLenguajeId(usuarioDto.Idioma);

                if (lenguajeDto == null)
                    throw new Exception("Lenguaje no existe");

                Usuarios usuario = mapper.Map<Usuarios>(usuarioDto);
                this.usuarioRepository.GuardarUsuario(usuario);
                return new ApiCallResult
                {
                    Message = "Usuario guardado con exito",
                    Status = true
                };
            }
            catch (Exception ex)
            {
                return new ApiCallResult
                {
                    Message = ex.Message
                };
            }
        }
        #endregion
    }
}
