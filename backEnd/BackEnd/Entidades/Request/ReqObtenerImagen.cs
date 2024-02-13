using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEnd.Entidades.Request
{
    public class ReqObtenerImagen :ReqBase
    {
        public int imagenID { get; set; }
    }
}