using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.Mantenimiento;
using Inmobiliaria.Modelo.Dao.Usuarios;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Utilidades.Controles;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Inmobiliaria.Services.Usuarios
{
    class UsuariosService
    {
        public USUARIOS Guardar(String operacion, USUARIOS entidad, USUARIOS usuarioLogueado)
        {
            try
            {
                using (UsuariosDao usuariosDao = new UsuariosDao())
                {
                    if (Constantes.Operaciones.NUEVO.Equals(operacion))
                    {

                        entidad.USUARIO_CREACION = usuarioLogueado.CODIGO_USUARIO;
                        entidad.FECHA_CREACION = DateTime.Now;
                        usuariosDao.Agregar(entidad);                        
                    }
                    else
                    {
                        String Password = entidad.PASSWORD;
                        String Activo = entidad.ACTIVO;
                        String Perfil = entidad.PERFIL;


                        entidad = usuariosDao.ObtenerDesdePk(entidad.CODIGO_USUARIO);

                        entidad.PASSWORD = Password;
                        entidad.ACTIVO = Activo;
                        entidad.PERFIL = Perfil;



                        entidad.USUARIO_MODIFICACION = usuarioLogueado.CODIGO_USUARIO;
                        //entidad.FECHA_MODIFICACION = DateTime.Now;
                        usuariosDao.Actualizar(entidad);
                    }
                    usuariosDao.Guardar();
                }
                if (Constantes.Operaciones.NUEVO.Equals(operacion))
                {
                    List<VARIABLES_ENTORNOS> variablesEntornos = new List<VARIABLES_ENTORNOS>();
                    //IList<VARIABLES_ENTORNOS> variablesEntornos = new List<VARIABLES_ENTORNOS>();
                    // copiamos las variables de entorno de admin
                    using (VariablesEntornosDao variableDao = new VariablesEntornosDao())
                    {
                        variablesEntornos = variableDao.ObtenerDesdeFiltros(c => c.CODIGO_USUARIO == "admin").ToList();
                    }
                    if (variablesEntornos.Count > 0)
                    {

                        foreach (VARIABLES_ENTORNOS variable in variablesEntornos)
                        {
                            using (VariablesEntornosDao variableDao = new VariablesEntornosDao())
                            {
                                try
                                {
                                    VARIABLES_ENTORNOS entidadVariable = new VARIABLES_ENTORNOS();

                                    entidadVariable.CODIGO_USUARIO = entidad.CODIGO_USUARIO;

                                    entidadVariable.CLAVE = variable.CLAVE;
                                    entidadVariable.VALOR = variable.VALOR;

                                    entidadVariable.USUARIO_CREACION = usuarioLogueado.CODIGO_USUARIO;
                                    entidadVariable.FECHA_CREACION = DateTime.Now;

                                    variableDao.Agregar(entidadVariable);
                                    variableDao.Guardar();
                                }
                                catch (Exception ex)
                                {

                                    throw ex;
                                }
                            }
                        }
                    }
                }
                return entidad;

            }
            catch (Exception e)
            {
                PysistemasMensajes.ShowError("Ha ocurrido un error " + e);
                throw e;
            }
        }
    }
}
