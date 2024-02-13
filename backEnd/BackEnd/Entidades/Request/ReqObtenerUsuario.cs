using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEnd.Entidades
{
    public class ReqObtenerUsuario : ReqBase
    {
        public long idDelUsuario { get; set; }
    }
}