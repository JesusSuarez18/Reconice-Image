using BackEnd.accesoDatos;
using BackEnd.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Web;

namespace BackEnd.Utilitarios
{
    public static class Factory
    {
        public static Usuario miFactoryDeUsuario(SP_OBTENER_USUARIOResult elTipoComplejo)
        {
            Usuario elUsuarioCreado = new Usuario();
            elUsuarioCreado.nombre = elTipoComplejo.NOMBRE;
            elUsuarioCreado.apellidos = elTipoComplejo.APELLIDOS;
            elUsuarioCreado.correoElectronico = elTipoComplejo.CORREO_ELECTRONICO;
            elUsuarioCreado.password = elTipoComplejo.PASSWORD;
            elUsuarioCreado.fechaRegistro = elTipoComplejo.FECHA_REGISTRO;
            elUsuarioCreado.estado = (int)elTipoComplejo.ESTADO;
            return elUsuarioCreado;
        }

        public static Usuario miFactoryDeUsuarioActivar(SP_OBTENER_USUARIOResult elTipoComplejo)
        { 
            Usuario elUsuarioActivado = new Usuario();
            elUsuarioActivado.correoElectronico = elTipoComplejo.CORREO_ELECTRONICO;
            elUsuarioActivado.numeroVerificacion = elTipoComplejo.NUMERO_VERIFICACION;
            elUsuarioActivado.estado = (int)elTipoComplejo.ESTADO;

            return elUsuarioActivado;
        }

        public static Imagenes miFactoryDeUnaImagen(SP_OBTENER_IMAGENESResult elTipoComplejo)
        {
            Imagenes laImagen = new Imagenes();
            laImagen.imageData = elTipoComplejo.IMAGE_DATA.ToArray();
            laImagen.descripcion = elTipoComplejo.DESCRIPTION;
            laImagen.fechaRegistro = elTipoComplejo.FECHA_REGISTRO;

            return laImagen;
        }

        public static List<Imagenes> miFactoryListaDeImagen(List<SP_OBTENER_IMAGENESResult> listaCompleja)
        {
            List<Imagenes> lalistaImagen = new List<Imagenes>();
            foreach (SP_OBTENER_IMAGENESResult cadaTipoComplejo in listaCompleja)
            {
                lalistaImagen.Add(miFactoryDeUnaImagen(cadaTipoComplejo));
            }
            return lalistaImagen;
        }

        public static Usuario miFactoryDeUsuarioLogIn(SP_OBTENER_USUARIOResult elTipoComplejo) //MODIFICAR para generacion del LogIn
        {
            Usuario logInUsuario = new Usuario();
            logInUsuario.correoElectronico = elTipoComplejo.CORREO_ELECTRONICO;
            logInUsuario.password = elTipoComplejo.PASSWORD;

            return logInUsuario;
        }
    }
}