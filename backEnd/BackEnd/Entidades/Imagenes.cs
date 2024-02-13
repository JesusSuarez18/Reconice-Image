using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEnd.Entidades
{
    public class Imagenes
    {
        public byte[] imageData { get; set; }
        public string descripcion { get; set; }
        public string fileExtension { get; set; }
        public int size { get; set; }
        public DateTime fechaRegistro { get; set; }

    }
}