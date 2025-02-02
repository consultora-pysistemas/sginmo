using System;
using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.Usuarios;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Utilidades.Seguridad;

namespace Inmobiliaria.Services.Seguridad
{
    public class IngresoSistemaService
    {
        public Respuesta IngresoSistema(string codigoUsuario,string password)
        {
            Respuesta respuesta = new Respuesta();
            respuesta.Status = Constantes.TipoRespuesta.OK;
            try
            {
                using (UsuariosDao usuariodDao = new UsuariosDao())
                {
                    USUARIOS usuario = usuariodDao.ObtenerDesdePk(codigoUsuario);
                    if (usuario == null)
                    {
                        respuesta.Status = Constantes.TipoRespuesta.ERROR;
                        respuesta.Mensaje = String.Format("El usuario {0} no existe", codigoUsuario);
                        return respuesta;
                    }

                    if (!PysistemasSeguridad.Encriptar(password).Equals(usuario.PASSWORD))
                    {
                        respuesta.Status = Constantes.TipoRespuesta.ERROR;
                        respuesta.Mensaje = String.Format("El password para el usuario {0} no coincide", codigoUsuario);
                        return respuesta;
                    }

                    if (!Constantes.Booleano.SI.Equals(usuario.ACTIVO))
                    {
                        respuesta.Status = Constantes.TipoRespuesta.ERROR;
                        respuesta.Mensaje = String.Format("El usuario {0} no está activo", codigoUsuario);
                        return respuesta;
                    }

                    respuesta.Entity = usuario;

                }
                return respuesta;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
