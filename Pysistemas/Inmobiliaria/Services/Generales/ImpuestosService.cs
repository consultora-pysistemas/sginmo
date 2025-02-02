using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.Mantenimiento;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Utilidades.Controles;
using System;

namespace Inmobiliaria.Services.Generales
{
    public class ImpuestosService
    {
        public IMPUESTOS Guardar(String operacion, IMPUESTOS entidad, USUARIOS usuarioLogueado)
        {
            try
            {
                using (ImpuestosDao impuestosDao = new ImpuestosDao())
                {
                    if (Constantes.Operaciones.NUEVO.Equals(operacion))
                    {

                        entidad.USUARIO_CREACION = usuarioLogueado.CODIGO_USUARIO;
                        entidad.FECHA_CREACION = DateTime.Now;
                        impuestosDao.Agregar(entidad);



                    }
                    else
                    {
                        entidad.USUARIO_MODIFICACION = usuarioLogueado.CODIGO_USUARIO;
                        entidad.FECHA_MODIFICACION = DateTime.Now;
                        impuestosDao.Actualizar(entidad);
                    }
                    impuestosDao.Guardar();
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
