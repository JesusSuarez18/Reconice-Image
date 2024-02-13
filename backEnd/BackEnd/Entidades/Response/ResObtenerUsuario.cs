using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEnd.Entidades.Response
{
    public class ResObtenerUsuario : ResBase
    {
      public Usuario elUsuario { get; set; }
    }
}