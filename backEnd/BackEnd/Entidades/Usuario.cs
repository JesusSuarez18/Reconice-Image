using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEnd.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public int ImagenId { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string correoElectronico { get; set; }
        public string password { get; set; }
        public DateTime fechaRegistro { get; set; }
        public string numeroVerificacion { get; set; }
        public int estado { get; set; }
    }
}