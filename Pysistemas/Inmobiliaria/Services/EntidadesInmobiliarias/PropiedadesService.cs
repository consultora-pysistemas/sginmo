using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.EntidadesInmobiliarias;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Utilidades.Controles;
using System;
using System.Collections.Generic;

namespace Inmobiliaria.Services.EntidadesInmobiliarias
{
    public class PropiedadesService
    {
        public PROPIEDADES Guardar(String operacion, PROPIEDADES entidad, IList<SOCIOS_NEGOCIOS_VIEW> propietarios, USUARIOS usuarioLogueado)
        {
            try
            {
                /*if (propietarios.Count == 0)
                {
                    throw new Exception("El/Los propietarios son requeridos para registrar el departamento/lote/casa/dúplex");

                }*/
                using (PropiedadesDao propiedadesDao = new PropiedadesDao())
                {
                    if (Constantes.Operaciones.NUEVO.Equals(operacion))
                    {

                        entidad.USUARIO_CREACION = usuarioLogueado.CODIGO_USUARIO;
                        entidad.FECHA_CREACION = DateTime.Now;
                        propiedadesDao.Agregar(entidad);



                    }
                    else
                    {
                        
                        entidad.USUARIO_MODIFICACION = usuarioLogueado.CODIGO_USUARIO;
                        entidad.FECHA_MODIFICACION = DateTime.Now;
                        propiedadesDao.Actualizar(entidad);
                    }
                    propiedadesDao.Guardar();
                }

               /* using ( PropietariosEntidadesInmobiliariasDao propietarioEntidadInmobiliariaDao = new PropietariosEntidadesInmobiliariasDao())
                {
                    if (Constantes.Operaciones.NUEVO.Equals(operacion))
                    {

                        foreach (SOCIOS_NEGOCIOS_VIEW prop in propietarios)
                        {
                            PROPIETARIOS_ENT_INMOB propietarioEntidad = new PROPIETARIOS_ENT_INMOB();
                            propietarioEntidad.ENTIDAD_INMOBILIARIA_ID = entidad.ENTIDAD_INMOBILIARIA_ID;
                            propietarioEntidad.PROPIETARIO_ID = prop.SOCIO_NEGOCIO_ID;
                            propietarioEntidad.USUARIO_CREACION = usuarioLogueado.CODIGO_USUARIO;
                            propietarioEntidad.FECHA_CREACION = DateTime.Now;
                            propietarioEntidad.PROPIEDAD_ID = entidad.PROPIEDAD_ID;
                            propietarioEntidadInmobiliariaDao.Agregar(propietarioEntidad);
                            propietarioEntidadInmobiliariaDao.Guardar();
                        }
                    }
                    else
                    {
                        foreach (SOCIOS_NEGOCIOS_VIEW prop in propietarios)
                        {
                            IList<PROPIETARIOS_ENT_INMOB> list = propietarioEntidadInmobiliariaDao.ObtenerDesdeFiltros(p => p.ENTIDAD_INMOBILIARIA_ID == entidad.ENTIDAD_INMOBILIARIA_ID && p.PROPIETARIO_ID == prop.SOCIO_NEGOCIO_ID);
                            if (list.Count == 0)//No existe este propietario para esta entidad
                            {
                                PROPIETARIOS_ENT_INMOB propietarioEntidad = new PROPIETARIOS_ENT_INMOB();
                                propietarioEntidad.ENTIDAD_INMOBILIARIA_ID = entidad.ENTIDAD_INMOBILIARIA_ID;
                                propietarioEntidad.PROPIEDAD_ID = entidad.PROPIEDAD_ID;
                                propietarioEntidad.PROPIETARIO_ID = prop.SOCIO_NEGOCIO_ID;
                                propietarioEntidad.USUARIO_CREACION = usuarioLogueado.CODIGO_USUARIO;
                                propietarioEntidad.FECHA_CREACION = DateTime.Now;
                                propietarioEntidadInmobiliariaDao.Actualizar(propietarioEntidad);
                                propietarioEntidadInmobiliariaDao.Guardar();
                            }

                        }
                    }
                }*/
                return entidad;
            }
            catch(Exception ex)
            {
                PysistemasMensajes.ShowError("Ha ocurrido un error " + ex);
                throw ex;
            }
        }
    }
}
