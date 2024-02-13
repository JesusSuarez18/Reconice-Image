using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEnd.Entidades
{
    public class ResBase
    {
        public bool result { get; set; }
        public List<string>listaDeErrores { get; set; }
    }
}