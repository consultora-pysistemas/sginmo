using System;
using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.IngresosEgresos;
using Inmobiliaria.Modelo.Views;

namespace Inmobiliaria.Services.IngresosEgresos
{
    public class ItemsIngresosEgresosService
    {
        public void Guardar(ITEMS_INGRESOS_EGRESOS entity, String operacion, USUARIOS usuarioLogueado)
        {
            try
            {
                using (ItemsIngresosEgresosDao itemsIngresosEgresosDao = new ItemsIngresosEgresosDao())
                {
                    if (Constantes.Operaciones.NUEVO.Equals(operacion))
                    {
                        entity.USUARIO_CREACION = usuarioLogueado.CODIGO_USUARIO;
                        entity.FECHA_CREACION = DateTime.Now;
                        itemsIngresosEgresosDao.Agregar(entity);
                    }
                    else
                    {
                        entity.USUARIO_MODIFICACION = usuarioLogueado.CODIGO_USUARIO;
                        entity.FECHA_MODIFICACION = DateTime.Now;
                        itemsIngresosEgresosDao.Actualizar(entity);

                    }
                    itemsIngresosEgresosDao.Guardar();
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
