using BackEnd.accesoDatos;
using BackEnd.Entidades;
using BackEnd.Entidades.Request;
using BackEnd.Entidades.Response;
using BackEnd.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebSockets;

namespace BackEnd.Logica
{
    public class LogImagenes
    {
        string stringConexion = "";
        public ResIngresarImagen ingresarImagen(ReqIngresarImagen req)
        {
            ResIngresarImagen res = new ResIngresarImagen();
            res.listaDeErrores = new List<string>();
            try
            {
                if (req == null)
                {
                    res.listaDeErrores.Add("Req nulo");
                    res.result = false;
                }
                else
                {
                    if (req.laImagen.imageData == null && req.laImagen.imageData.Length > 0)
                    {
                        res.listaDeErrores.Add("Falta la data la imagen ");
                        res.result = false;
                    }
                    if (String.IsNullOrEmpty(req.laImagen.descripcion))
                    {
                        res.listaDeErrores.Add("Falta de ingresar un descripcion a la imagen ");
                        res.result = false;
                    }
                    if (String.IsNullOrEmpty(req.laImagen.fileExtension ))
                    {
                        res.listaDeErrores.Add("Título faltante");
                        res.result = false;
                    }
                    if (req.laImagen.size == 0 )
                    {
                        res.listaDeErrores.Add("Falta el tamaño de la imagen");
                        res.result = false;
                    }
                    if (req.laImagen.fechaRegistro == null)
                    {
                        res.listaDeErrores.Add("No se ha ingresado una fecha de registro");
                        res.result = false;
                    }
                    if (!res.listaDeErrores.Any())
                    {
                        //¿No hay nada en la lista de errores?
                        //Correcto. Todo bien. No hay nada en la lista de errores.
                        //Llamo al linq
                        int? idReturn = 0;
                        int? idDeErrorDeBaseDeDatos = 0;
                        string descripcionErrorDeBaseDeDatos = "";

                        conexionLinqDataContext miLinq = new conexionLinqDataContext(stringConexion);//falta ingresar el link del string de conexion
                        miLinq.SP_INGRESAR_IMAGEN(req.laImagen.imageData, req.laImagen.descripcion,req.laImagen.fileExtension, req.laImagen.size, ref idReturn, ref idDeErrorDeBaseDeDatos, ref descripcionErrorDeBaseDeDatos);

                        if (idDeErrorDeBaseDeDatos == 0) //Hubo errores en BD
                        {
                            //Todo bien. No, no hay errores en base de datos
                            res.result = true;
                        }
                        else
                        {
                            //Si, si hay errores en BD.
                            res.result = false;
                            res.listaDeErrores.Add("La base de datos retornó:" + descripcionErrorDeBaseDeDatos);
                        }
                    }
                }
            }
            catch
            {
                res.listaDeErrores.Add("Error no controlado en lógica");
                res.result = false;
            }
            return res;
        }

        public ResObtenerImagenes obtenerImagenes(ReqObtenerImagen req)
        {

            ResObtenerImagenes res = new ResObtenerImagenes();

            res.listaDeErrores = new List<string>();
            try
            {
                if (req == null)
                {
                    res.result = false;
                    res.listaDeErrores.Add("Request nulo");
                }
                else
                {
                    conexionLinqDataContext miLinq = new conexionLinqDataContext(stringConexion); //Instancio Linq
                    List<SP_OBTENER_IMAGENESResult> listaTipoComplejo = new List<SP_OBTENER_IMAGENESResult>();
                    listaTipoComplejo = miLinq.SP_OBTENER_IMAGENES().ToList();
                    res.laListaImagenes = Factory.miFactoryListaDeImagen(listaTipoComplejo);
                    res.result = true;
                }
            }
            catch (Exception e)
            {
                res.result = false;
                res.listaDeErrores.Add("Error no controlado en lógica: " + e.StackTrace);
            }
            return res;
        }
    }
}