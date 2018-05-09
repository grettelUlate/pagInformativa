using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace paginaInform.Models
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public string mensaje { get; set; }
       public string activo { get; set; }
    }
}