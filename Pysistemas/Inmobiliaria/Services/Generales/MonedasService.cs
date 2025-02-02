using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.Mantenimiento;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Utilidades.Controles;
using System;
using System.Linq;

namespace Inmobiliaria.Services.Generales
{
    public class MonedasService
    {
        public MONEDAS Guardar(String operacion, MONEDAS entidad, USUARIOS usuarioLogueado)
        {
            try
            {
                using (MonedasDao monedasDao = new MonedasDao())
                {
                    if (Constantes.Operaciones.NUEVO.Equals(operacion))
                    {

                        entidad.USUARIO_CREACION = usuarioLogueado.CODIGO_USUARIO;
                        entidad.FECHA_CREACION = DateTime.Now;
                        monedasDao.Agregar(entidad);



                    }
                    else
                    {
                        entidad.USUARIO_MODIFICACION = usuarioLogueado.CODIGO_USUARIO;
                        entidad.FECHA_MODIFICACION = DateTime.Now;
                        monedasDao.Actualizar(entidad);
                    }
                    monedasDao.Guardar();
                }
                return entidad;

            }
            catch (Exception e)
            {
                PysistemasMensajes.ShowError("Ha ocurrido un error " + e);
                throw e;
            }
        }

        public MONEDAS ObtenerMonedaPorDefecto()
        {
            using(MonedasDao monedasDao = new MonedasDao())
            {
                return monedasDao.ObtenerDesdeFiltros(m => m.TIPO_MONEDA.Equals("LOCAL")).FirstOrDefault();
            }
        }
    }
}
