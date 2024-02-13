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
    public class UsuarioController : ApiController
    {
        public ResObtenerUsuario GET()
        {
            LogUsuario miLogicaEnElBackend = new LogUsuario();
            ReqObtenerUsuario req = new ReqObtenerUsuario();
            return miLogicaEnElBackend.obtenerUsuario(req);
        }

        public ResIngresarUsuario ingresarUsuario([FromBody] ReqIngresarUsuario req)
        {
            LogUsuario miLogicaDelBackend = new LogUsuario();
            return miLogicaDelBackend.ingresarUsuario(req);
        }
        public ResIngresarUsuario activarUsuario([FromBody] ReqIngresarUsuario req)
        {
            LogUsuario miLogicaDelBackend = new LogUsuario();
            return miLogicaDelBackend.ActivarUsuario(req);
        }
        public ResIngresarUsuario logInUsuario([FromBody] ReqIngresarUsuario req)
        {
            LogUsuario miLogicaDelBackend = new LogUsuario();
            return miLogicaDelBackend.LogInUsuario(req);
        }
    }
}