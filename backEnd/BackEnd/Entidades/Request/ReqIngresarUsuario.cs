using BackEnd.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEnd.Entidades
{
    public class ReqIngresarUsuario : ReqBase
    {
        public Usuario elUsuario { get; set; }
    }
}