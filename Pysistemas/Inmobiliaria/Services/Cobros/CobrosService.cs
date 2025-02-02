using System;
using System.Collections.Generic;
using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.Cobros;
using Inmobiliaria.Modelo.Views;

namespace Inmobiliaria.Services.Cobros
{
    public class CobrosService
    {
        public CalculoDiasMontoMora CalcularMora(CalculoDiasMontoMora calculoMontoMora)
        {
            calculoMontoMora.montoMora = 0;
            calculoMontoMora.diasMoras = 0;
            DateTime fechaVencimientoAux = calculoMontoMora.fechaVencimiento.AddDays(calculoMontoMora.diaGracias.Value);
            if (fechaVencimientoAux < calculoMontoMora.fechaCobro)
            {
                TimeSpan diferenciaDias = calculoMontoMora.fechaCobro - fechaVencimientoAux;
                Int64 diasMora = diferenciaDias.Days;
                Decimal montoMora = diasMora * calculoMontoMora.montoMoraDia;
                calculoMontoMora.diasMoras = diasMora;
                calculoMontoMora.montoMora = montoMora;
                return calculoMontoMora;

            }
            return calculoMontoMora;
        }

        public COBROS GuardarCobro(String operacion, COBROS cabecera, List<COBROS_DETALLES> detalles, String usuario)
        {
            try
            {
                
                using (CobrosDao cobrosDao = new CobrosDao())
                {
                    if (Constantes.Operaciones.NUEVO.Equals(operacion))
                    {
                        cabecera.USUARIO_CREACION = usuario;
                        cabecera.FECHA_CREACION = DateTime.Now;
                        cobrosDao.Agregar(cabecera);
                        cobrosDao.Guardar();
                        using (CobrosDetallesDao cobrosDetallesDao = new CobrosDetallesDao())
                        {
                            foreach (COBROS_DETALLES detalle in detalles)
                            {
                                if(!"DESCUENTO".Equals(detalle.TIPO_DOCUMENTO))
                                {
                                    CancelarCuota(detalle.DOCUMENTO_ID, usuario, cabecera);
                                }else
                                {
                                    detalle.DOCUMENTO_ID = detalles[0].DOCUMENTO_ID;
                                }
                                detalle.COBRO_ID = cabecera.COBRO_ID;
                                detalle.USUARIO_CREACION = usuario;
                                
                                detalle.FECHA_CREACION = DateTime.Now;
                                cobrosDetallesDao.Agregar(detalle);
                                cobrosDetallesDao.Guardar();
                                
                               

                            }
                        }

                    }
                    else
                    {
                        cobrosDao.Actualizar(cabecera);
                        cobrosDao.Guardar();
                    }
                }
                return cabecera;
            }
            
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void CancelarCuota(long? cronogramaCuotaId,String usuario,COBROS cobros)
        {
            try
            {
                using (CronogramasCuotasDao cronogramasCuotasDao = new CronogramasCuotasDao())
                {
                    CRONOGRAMAS_CUOTAS cuota = cronogramasCuotasDao.ObtenerDesdePk(cronogramaCuotaId);
                    cuota.ESTADO = "CANCELADO";
                    cuota.FECHA_CANCELACION = cobros.FECHA;
                    cuota.USUARIO_MODIFICACION = usuario;
                    cuota.FECHA_MODIFICACION = DateTime.Now;
                    cronogramasCuotasDao.Actualizar(cuota);
                    cronogramasCuotasDao.Guardar();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
