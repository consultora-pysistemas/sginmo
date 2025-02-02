using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.Mantenimiento;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Utilidades.Controles;
using System;

namespace Inmobiliaria.Services.Mantenimientos
{
    public class CiudadesService
    {
        public CIUDADES Guardar(String operacion, CIUDADES entidad,CIUDADES_DEPARTAMENTOS CiudadDepartamentoEntidad, USUARIOS usuarioLogueado)
        {
            try
            {
                using (CiudadesDao ciudadesDao = new CiudadesDao())
                {
                    if (Constantes.Operaciones.NUEVO.Equals(operacion))
                    {

                        entidad.USUARIO_CREACION = usuarioLogueado.CODIGO_USUARIO;
                        entidad.FECHA_CREACION = DateTime.Now;
                        ciudadesDao.Agregar(entidad);

                    }
                    else
                    {
                        String Ciudad = entidad.CIUDAD;

                        entidad = ciudadesDao.ObtenerDesdePk(entidad.CIUDAD_ID);
                        entidad.CIUDAD = Ciudad;

                        entidad.USUARIO_MODIFICACION = usuarioLogueado.CODIGO_USUARIO;
                        entidad.FECHA_MODIFICACION = DateTime.Now;
                        ciudadesDao.Actualizar(entidad);
                    }
                    ciudadesDao.Guardar();
                }

                using (CiudadesDepartamentosDao ciudadesDepartamentoDao = new CiudadesDepartamentosDao())
                {
                    if (Constantes.Operaciones.NUEVO.Equals(operacion))
                    {

                        CiudadDepartamentoEntidad.CIUDAD_ID = entidad.CIUDAD_ID;
                        CiudadDepartamentoEntidad.CODIGO = "9999";

                        CiudadDepartamentoEntidad.USUARIO_CREACION = usuarioLogueado.CODIGO_USUARIO;
                        CiudadDepartamentoEntidad.FECHA_CREACION = DateTime.Now;
                        ciudadesDepartamentoDao.Agregar(CiudadDepartamentoEntidad);



                    }
                    else
                    {
                        Int64 CiudadId = CiudadDepartamentoEntidad.CIUDAD_ID;

                        CiudadDepartamentoEntidad = ciudadesDepartamentoDao.ObtenerDesdePk(CiudadDepartamentoEntidad.CIUDAD_DEPARTAMENTO_ID);
                        CiudadDepartamentoEntidad.CIUDAD_ID = CiudadId;

                        CiudadDepartamentoEntidad.USUARIO_MODIFICACION = usuarioLogueado.CODIGO_USUARIO;
                        CiudadDepartamentoEntidad.FECHA_MODIFCACION = DateTime.Now;
                        ciudadesDepartamentoDao.Actualizar(CiudadDepartamentoEntidad);
                    }
                    ciudadesDepartamentoDao.Guardar();
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
