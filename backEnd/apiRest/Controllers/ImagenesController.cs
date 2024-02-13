using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using BackEnd.Entidades;
using BackEnd.Entidades.Request;
using BackEnd.Entidades.Response;
using BackEnd.Logica;

namespace apiRest.Controllers
{
    public class ImagenesController : ApiController
    {
        public ResObtenerImagenes GET()
        {
            LogImagenes miLogicaEnElBackend = new LogImagenes();
            ReqObtenerImagen req = new ReqObtenerImagen();
            return miLogicaEnElBackend.obtenerImagenes(req);
        }
        public ResIngresarImagen ingresarImagen([FromBody] ReqIngresarImagen req)
        {
            LogImagenes miLogicaDelBackend = new LogImagenes();
            return miLogicaDelBackend.ingresarImagen(req);
        } 
    }
}