namespace DatosDto
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class UsuarioDto
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Idioma { get; set; }
        public int Rol { get; set; }
    }
}