using System;
using System.Collections.Generic;

namespace ModeloDatos
{
    public partial class Usuarios
    {
        public int Idusuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Idioma { get; set; }
        public int Rol { get; set; }
    }
}
