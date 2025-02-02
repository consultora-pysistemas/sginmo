using System;
using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.IngresosEgresos;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Utilidades.Controles;

namespace Inmobiliaria.Services.IngresosEgresos
{
    public class IngresosEgresosService
    {
        public INGRESOS_EGRESOS Guardar(String operacion, INGRESOS_EGRESOS entity, String usuario)
        {
            try
            {
                using (IngresosEgresosDao ingresosEgresosDao = new IngresosEgresosDao())
                {
                    if (Constantes.Operaciones.NUEVO.Equals(operacion))
                    {

                        entity.FECHA_CREACION = DateTime.Now;
                        entity.USUARIO_CREACION = usuario;
                        ingresosEgresosDao.Agregar(entity);

                    }
                    else
                    {
                        entity.FECHA_MODIFICACION = DateTime.Now;
                        entity.USUARIO_MODIFICACION = usuario;
                        ingresosEgresosDao.Actualizar(entity);
                    }
                    ingresosEgresosDao.Guardar();
                    return entity;
                }
                
            }
            catch (Exception e)
            {
                PysistemasMensajes.ShowError(e.Message);
                throw e;

            }
        }
    }
}
