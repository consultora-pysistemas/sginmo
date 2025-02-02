using Inmobiliaria.Modelo;
using System;
using System.Collections.Generic;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Modelo.Dao.Cobros;

namespace Inmobiliaria.Services.EntidadesInmobiliarias
{
    public class CronogramasCuotasService
    {
        public List<CRONOGRAMAS_CUOTAS> GenerarCuotas(OPERACIONES_PROPIEDADES operacion)
        {
            List<CRONOGRAMAS_CUOTAS> listaCuotas = new List<CRONOGRAMAS_CUOTAS>();
            try
            {
                Decimal precio = 0;


                if (Constantes.TiposOperacionesInmuebles.VENTA.Equals(operacion.TIPO_OPERACION))
                {
                    precio = (decimal)(operacion.PRECIO / operacion.PLAZO);
                }
                else
                {
                    precio = operacion.PRECIO;
                }

                

                    DateTime fechaVencCuota = new DateTime(operacion.FECHA_INICIO_CONTRATO.Year, operacion.FECHA_INICIO_CONTRATO.Month,int.Parse(operacion.DIA_PAGO.ToString())); 
                
                for(int i = 1; i <= operacion.PLAZO; i++)
                {
                    CRONOGRAMAS_CUOTAS cuota = new CRONOGRAMAS_CUOTAS();
                    cuota.NUMERO_CUOTA = i;
                    cuota.MONTO = Decimal.Parse(precio.ToString("N0"));
                    if(i==1)
                        fechaVencCuota = DateTime.Parse(operacion.FECHA_INICIO_CONTRATO.ToShortDateString());
                    else
                    {
                        fechaVencCuota = DateTime.Parse(fechaVencCuota.AddMonths(1).ToShortDateString());

                        Int64 diaPago = Int64.Parse(operacion.DIA_PAGO.ToString());

                        
                        if (DateTime.IsLeapYear(fechaVencCuota.Year) && fechaVencCuota.Month == 2 && diaPago > 29)
                        {
                            operacion.DIA_PAGO = 29;                            
                        
                        }
                        else if (!DateTime.IsLeapYear(fechaVencCuota.Year) && fechaVencCuota.Month == 2 && diaPago > 28)
                        {
                            operacion.DIA_PAGO = 28;                            

                        }
                        if (operacion.DIA_PAGO == 31 && (fechaVencCuota.Month == 4 || fechaVencCuota.Month == 6 || fechaVencCuota.Month == 9 ||
                            fechaVencCuota.Month == 11))
                        {
                            operacion.DIA_PAGO = 30;
                        }
                                                
                        fechaVencCuota = new DateTime(fechaVencCuota.Year, fechaVencCuota.Month, int.Parse(operacion.DIA_PAGO.ToString()));
                        //fechaVencCuota = DateTime.Parse(fechaVencCuota.AddMonths(1).ToShortDateString());
                        operacion.DIA_PAGO = diaPago;
                    }
                        
                    cuota.FECHA_VENCIMIENTO = fechaVencCuota;
                    cuota.ESTADO = "PENDIENTE";
                    cuota.MONEDA_ID = 1;
                    listaCuotas.Add(cuota);
                }






                return listaCuotas;
            }catch(Exception e)
            {
                throw e;
            }
        }
        public void BorrarCuotasParaRegenerar(List<CRONOGRAMAS_CUOTAS> listaCuotas)
        {
            //List<CRONOGRAMAS_CUOTAS> listaCuotas = new List<CRONOGRAMAS_CUOTAS>();

            foreach (CRONOGRAMAS_CUOTAS cuota in listaCuotas)
            {
                using (CronogramasCuotasDao cronogramaCuotaDao = new CronogramasCuotasDao())
                {                    
                    cronogramaCuotaDao.Remover(cuota);
                    cronogramaCuotaDao.Guardar();
                    
                }
            }
        }
        public void RefinanciarCuotas(int cuotaDesde,List<CRONOGRAMAS_CUOTAS> listaCuotas, OPERACIONES_PROPIEDADES operacion)
        {
            //List<CRONOGRAMAS_CUOTAS> listaCuotas = new List<CRONOGRAMAS_CUOTAS>();


            for (int i = cuotaDesde; i <= operacion.PLAZO; i++)
            {

            }
            
        }
        private int CalculaDiaPago(OPERACIONES_PROPIEDADES operacion,DateTime fechaVencCuota)
        {
            int diaPago = 0;
            if (DateTime.IsLeapYear(fechaVencCuota.Year) && fechaVencCuota.Month == 2 && diaPago > 29)
            {
                diaPago = 29;

            }
            else if (!DateTime.IsLeapYear(fechaVencCuota.Year) && fechaVencCuota.Month == 2 && diaPago > 28)
            {
                diaPago = 28;

            }
            if (operacion.DIA_PAGO == 31 && (fechaVencCuota.Month == 4 || fechaVencCuota.Month == 6 || fechaVencCuota.Month == 9 ||
                fechaVencCuota.Month == 11))
            {
                diaPago = 30;
            }
            return diaPago;
        }
    }
}
