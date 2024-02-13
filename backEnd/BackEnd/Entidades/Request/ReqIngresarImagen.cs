using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEnd.Entidades.Request
{
    public class ReqIngresarImagen : ResBase
    {
        public Imagenes laImagen { get; set; }
    }
}