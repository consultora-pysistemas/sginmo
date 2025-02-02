using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.Mantenimiento;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Utilidades.Controles;
using System;

namespace Inmobiliaria.Services.Mantenimientos
{
    public class PaisesService
    {
        public PAISES Guardar(String operacion, PAISES entidad, USUARIOS usuarioLogueado)
        {
            try
            {
                using (PaisDao paisesDao = new PaisDao())
                {
                    if (Constantes.Operaciones.NUEVO.Equals(operacion))
                    {

                        entidad.USUARIO_CREACION = usuarioLogueado.CODIGO_USUARIO;
                        entidad.FECHA_CREACION = DateTime.Now;
                        paisesDao.Agregar(entidad);
                    }
                    else
                    {
                        String pais = entidad.PAIS;
                        String codigo2 = entidad.CODIGO_ISO_2;
                        String codigo3 = entidad.CODIGO_ISO_3;
                        String nacionalidad = entidad.NACIONALIDAD;
                       
                       entidad = paisesDao.ObtenerDesdePk(entidad.PAIS_ID);
                       
                        entidad.PAIS = pais;
                        entidad.CODIGO_ISO_2 = codigo2;
                        entidad.CODIGO_ISO_3 = codigo3;
                        entidad.NACIONALIDAD = nacionalidad;


                        entidad.USUARIO_MODIFICACION = usuarioLogueado.CODIGO_USUARIO;
                        entidad.FECHA_MODIFICACION = DateTime.Now;
                        paisesDao.Actualizar(entidad);
                    }
                    paisesDao.Guardar();
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
