using System;
using System.Collections.Generic;
using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.EntidadesInmobiliarias;
using Inmobiliaria.Modelo.Dao.IngresosEgresos;
using Inmobiliaria.Modelo.Views;

namespace Inmobiliaria.Services.IngresosEgresos
{
    public class LiquidacionesService
    {
        public void Guardar(LIQUIDACIONES cabecera, List<LIQUIDACIONES_DETALLES_ITEMS> detalles, String operacion)
        {
            try
            {
                    using (LiquidacionesDao liquidacionesDao = new LiquidacionesDao())
                    {
                        if (Constantes.Operaciones.NUEVO.Equals(operacion))
                        {

                            liquidacionesDao.Agregar(cabecera);
                            liquidacionesDao.Guardar();
                        }
                        else
                        {
                            liquidacionesDao.Actualizar(cabecera);
                            liquidacionesDao.Guardar();
                        }

                        List<LIQUIDACIONES_DETALLES> detallesLiquidacion = ObtenerDetalles(detalles);
                        foreach (LIQUIDACIONES_DETALLES detalle in detallesLiquidacion)
                        {
                            using (LiquidacionesDetallesDao liquidacionesDetallesDao = new LiquidacionesDetallesDao())
                            {
                                if (detalle.LIQUIDACION_DETALLE_ID == 0)
                                {
                                    detalle.LIQUIDACION_ID = cabecera.LIQUIDACION_ID;
                                    liquidacionesDetallesDao.Agregar(detalle);
                                    liquidacionesDetallesDao.Guardar();
                                    

                                }
                                else
                                {
                                    
                                    liquidacionesDetallesDao.Actualizar(detalle);
                                    liquidacionesDetallesDao.Guardar();
                                }
                            }
                            
                        }

                        SetearDetalles(detallesLiquidacion, detalles);
                        using (PropiedadesDao propiedadesDao = new PropiedadesDao())
                        {
                            using (OperacionesPropiedadesDao operacionesPropiedadesDao = new OperacionesPropiedadesDao()
                            )
                            {
                                OPERACIONES_PROPIEDADES operacionesPropiedades =
                                    operacionesPropiedadesDao.ObtenerDesdePk(cabecera.OPERACION_PROPIEDAD_ID);
                                PROPIEDADES propiedades =
                                    propiedadesDao.ObtenerDesdePk(operacionesPropiedades.PROPIEDAD_ID);
                                propiedades.USUARIO_MODIFICACION = cabecera.USUARIO_CREACION;
                                propiedades.FECHA_MODIFICACION = DateTime.Now;
                                propiedades.ESTADO = "LIBRE";
                                propiedades.USUARIO_MODIFICACION = cabecera.USUARIO_CREACION;
                                propiedades.FECHA_MODIFICACION = DateTime.Now;

                                propiedadesDao.Actualizar(propiedades);
                                propiedadesDao.Guardar();
                                operacionesPropiedades.ESTADO = "FINALIZADO";
                                operacionesPropiedades.USUARIO_MODIFICACION = cabecera.USUARIO_CREACION;
                                operacionesPropiedades.FECHA_MODIFICACION = DateTime.Now;
                                operacionesPropiedadesDao.Actualizar(operacionesPropiedades);
                                operacionesPropiedadesDao.Guardar();
                            }
                        }



                    }

                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private void SetearDetalles(List<LIQUIDACIONES_DETALLES> detallesLiquidacion, List<LIQUIDACIONES_DETALLES_ITEMS> detalles)
        {
            foreach (var detalleItem in detalles)
            {
                foreach (var det in detallesLiquidacion)
                {
                    if (detalleItem.ITEM_INGRESO_EGRESO_ID == det.ITEM_INGRESO_EGRESO_ID &&
                        detalleItem.LIQUIDACION_DETALLE_ID == 0)
                    {
                        detalleItem.LIQUIDACION_DETALLE_ID = det.LIQUIDACION_DETALLE_ID;
                        break;
                        
                    }
                }
            }
        }

        private List<LIQUIDACIONES_DETALLES> ObtenerDetalles(List<LIQUIDACIONES_DETALLES_ITEMS> detalles)
        {
            List<LIQUIDACIONES_DETALLES> lista = new List<LIQUIDACIONES_DETALLES>();
            foreach (LIQUIDACIONES_DETALLES_ITEMS item in detalles)
            {
                LIQUIDACIONES_DETALLES detalle = new LIQUIDACIONES_DETALLES();
                detalle.LIQUIDACION_DETALLE_ID = item.LIQUIDACION_DETALLE_ID;
                detalle.LIQUIDACION_ID = item.LIQUIDACION_ID;
                detalle.ITEM_INGRESO_EGRESO_ID = item.ITEM_INGRESO_EGRESO_ID;
                detalle.NUMERO_ITEM = item.NUMERO_ITEM;
                detalle.FECHA_CREACION = item.FECHA_CREACION;
                detalle.USUARIO_CREACION = item.USUARIO_CREACION;
                detalle.MONTO = item.MONTO;
                lista.Add(detalle);
            }
            return lista;
        }
    }
}
