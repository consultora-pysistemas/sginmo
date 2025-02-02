using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.EntidadesInmobiliarias;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Utilidades.Controles;
using System;
using System.Collections.Generic;

namespace Inmobiliaria.Services.EntidadesInmobiliarias
{
    public class EntidadesInmobiliariaService
    {


        public ENTIDADES_INMOBILIARIAS Guardar(String operacion,ENTIDADES_INMOBILIARIAS entidad,IList<SOCIOS_NEGOCIOS_VIEW> propietarios,USUARIOS usuarioLogueado)
        {



            try
            {
                if(propietarios.Count == 0)
                {
                   PysistemasMensajes.ShowInfo("El/Los propietarios son requeridos para registrar el edificio/loteamiento");
                   return null;

                }

                using(EntidadesInmobiliariasDao entidadesInmobiliariasDao = new EntidadesInmobiliariasDao())
                {
                    if (Constantes.Operaciones.NUEVO.Equals(operacion))
                    {

                        entidad.USUARIO_CREACION = usuarioLogueado.CODIGO_USUARIO;
                        entidad.FECHA_CREACION = DateTime.Now;
                        entidadesInmobiliariasDao.Agregar(entidad);



                    }else
                    {
                        entidad.USUARIO_MODIFICACION = usuarioLogueado.CODIGO_USUARIO;
                        entidad.FECHA_MODIFICACION = DateTime.Now;
                        entidadesInmobiliariasDao.Actualizar(entidad);
                    }
                    entidadesInmobiliariasDao.Guardar();
                }

                using (PropietariosEntidadesInmobiliariasDao propietarioEntidadInmobiliariaDao = new PropietariosEntidadesInmobiliariasDao())
                {
                    if (Constantes.Operaciones.NUEVO.Equals(operacion))
                    {
                        foreach(SOCIOS_NEGOCIOS_VIEW prop in propietarios)
                        {
                            PROPIETARIOS_ENT_INMOB propietarioEntidad = new PROPIETARIOS_ENT_INMOB();
                            propietarioEntidad.ENTIDAD_INMOBILIARIA_ID = entidad.ENTIDAD_INMOBILIARIA_ID;
                            propietarioEntidad.PROPIETARIO_ID = prop.SOCIO_NEGOCIO_ID;
                            propietarioEntidad.USUARIO_CREACION = usuarioLogueado.CODIGO_USUARIO;
                            propietarioEntidad.FECHA_CREACION = DateTime.Now;
                            propietarioEntidadInmobiliariaDao.Agregar(propietarioEntidad);
                            propietarioEntidadInmobiliariaDao.Guardar();
                        }
                    }else
                    {
                        foreach (SOCIOS_NEGOCIOS_VIEW prop in propietarios)
                        {
                            IList<PROPIETARIOS_ENT_INMOB> list = propietarioEntidadInmobiliariaDao.ObtenerDesdeFiltros(p => p.ENTIDAD_INMOBILIARIA_ID == entidad.ENTIDAD_INMOBILIARIA_ID && p.PROPIETARIO_ID == prop.SOCIO_NEGOCIO_ID);
                            if(list.Count == 0)//No existe este propietario para esta entidad
                            {
                                PROPIETARIOS_ENT_INMOB propietarioEntidad = new PROPIETARIOS_ENT_INMOB();
                                propietarioEntidad.ENTIDAD_INMOBILIARIA_ID = entidad.ENTIDAD_INMOBILIARIA_ID;
                                propietarioEntidad.PROPIETARIO_ID = prop.SOCIO_NEGOCIO_ID;
                                propietarioEntidad.USUARIO_CREACION = usuarioLogueado.CODIGO_USUARIO;
                                propietarioEntidad.FECHA_CREACION = DateTime.Now;
                                propietarioEntidadInmobiliariaDao.Agregar(propietarioEntidad);
                                propietarioEntidadInmobiliariaDao.Guardar();
                            }
                            
                        }
                    }
                }





                return entidad;

            }catch(Exception e)
            {
                PysistemasMensajes.ShowError("Ha ocurrido un error " + e);
                throw e;
            }
        }



    }
}
