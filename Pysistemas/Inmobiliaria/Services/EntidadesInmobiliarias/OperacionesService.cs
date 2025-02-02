using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.Cobros;
using Inmobiliaria.Modelo.Dao.EntidadesInmobiliarias;
using Inmobiliaria.Modelo.Views;
using System;
using System.Collections.Generic;

namespace Inmobiliaria.Services.EntidadesInmobiliarias
{
    public class OperacionesService
    {
        public void GuardarOperacion(List<CRONOGRAMAS_CUOTAS> cuotas,OPERACIONES_PROPIEDADES operacionPropiedades,String operacion,USUARIOS usuarioLogueado)
        {
            try
            {
                using(OperacionesPropiedadesDao operacionesPropiedadesDao = new OperacionesPropiedadesDao())
                {
                    if (Constantes.Operaciones.NUEVO.Equals(operacion))
                    {
                        operacionPropiedades.USUARIO_CREACION = usuarioLogueado.CODIGO_USUARIO;
                        operacionPropiedades.FECHA_CREACION = DateTime.Now;
                        operacionesPropiedadesDao.Agregar(operacionPropiedades);
                        operacionesPropiedadesDao.Guardar();
                        foreach(CRONOGRAMAS_CUOTAS cuota in cuotas)
                        {
                            using(CronogramasCuotasDao cronogramaCuotaDao = new CronogramasCuotasDao())
                            {
                                cuota.OPERACION_PROPIEDAD_ID = operacionPropiedades.OPERACION_PROPIEDAD_ID;
                                cuota.USUARIO_CREACION = usuarioLogueado.CODIGO_USUARIO;
                                cuota.FECHA_CREACION = DateTime.Now;
                                cronogramaCuotaDao.Agregar(cuota);
                                cronogramaCuotaDao.Guardar();
                            }

                            //Cambiamos el estado de la propiedad a OCUPADA
                            using(PropiedadesDao propiedadesDao = new PropiedadesDao())
                            {
                                PROPIEDADES propiedad = propiedadesDao.ObtenerDesdePk(operacionPropiedades.PROPIEDAD_ID);
                                if(propiedad != null)
                                {
                                    if (Constantes.TiposOperacionesInmuebles.ALQUILER.Equals(operacionPropiedades.TIPO_OPERACION))
                                    {
                                        propiedad.ESTADO = "OCUPADA";
                                    }
                                    else
                                    {
                                        propiedad.ESTADO = "VENDIDA";
                                    }

                                    propiedad.USUARIO_MODIFICACION = usuarioLogueado.CODIGO_USUARIO;
                                    propiedad.FECHA_MODIFICACION = DateTime.Now;
                                    propiedadesDao.Actualizar(propiedad);
                                    propiedadesDao.Guardar();
                                }
                            }
                        }
                    }
                    else
                    {
                        //en el editar en teoria sino modifica las cuotas no recibe nada y no deberia entrar aqui
                        // falta controlar las cuotas para que no dupliquen a la hora de regenerar
                        if (Constantes.Operaciones.RENOVAR.Equals(operacion))
                        {
                            if (cuotas != null && cuotas.Count > 0)
                            {
                                foreach (CRONOGRAMAS_CUOTAS cuota in cuotas)
                                {
                                    using (CronogramasCuotasDao cronogramaCuotaDao = new CronogramasCuotasDao())
                                    {
                                        cuota.OPERACION_PROPIEDAD_ID = operacionPropiedades.OPERACION_PROPIEDAD_ID;
                                        cuota.USUARIO_CREACION = usuarioLogueado.CODIGO_USUARIO;
                                        cuota.FECHA_CREACION = DateTime.Now;
                                        cronogramaCuotaDao.Agregar(cuota);
                                        cronogramaCuotaDao.Guardar();
                                    }
                                }
                            }
                        }else if (Constantes.Operaciones.EDITAR.Equals(operacion))
                        {
                            if (cuotas != null && cuotas.Count > 0)
                            {
                                foreach (CRONOGRAMAS_CUOTAS cuota in cuotas)
                                {
                                    using (CronogramasCuotasDao cronogramaCuotaDao = new CronogramasCuotasDao())
                                    {
                                        //cuota.OPERACION_PROPIEDAD_ID = operacionPropiedades.OPERACION_PROPIEDAD_ID;
                                        cuota.USUARIO_MODIFICACION = usuarioLogueado.CODIGO_USUARIO;
                                        cuota.FECHA_MODIFICACION = DateTime.Now;
                                        cronogramaCuotaDao.Actualizar(cuota);
                                        cronogramaCuotaDao.Guardar();
                                    }
                                }
                            }

                        }
                        operacionPropiedades.USUARIO_MODIFICACION = usuarioLogueado.CODIGO_USUARIO;
                        operacionPropiedades.FECHA_MODIFICACION = DateTime.Now;
                        operacionesPropiedadesDao.Actualizar(operacionPropiedades);
                        operacionesPropiedadesDao.Guardar();
                        return;
                    }
                    




                }
                
            }catch(Exception e)
            {
                throw e;
            }
        }
    }
}
