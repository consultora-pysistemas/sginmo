using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.Mantenimiento;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Utilidades.Controles;
using System;

namespace Inmobiliaria.Services.Mantenimientos
{
    public class BarriosService
    {

        public BARRIOS Guardar(String operacion, BARRIOS entidad, BARRIOS_CIUDADES BarrioCiudad, USUARIOS usuarioLogueado)
        {
            try
            {
                if (BarrioCiudad == null)
                {
                    throw new Exception("La ciudad es requeria para cargar el barrio.");
                }
                
                using (BarriosDao barriosDao = new BarriosDao())
                {
                    if (Constantes.Operaciones.NUEVO.Equals(operacion))
                    {

                        entidad.USUARIO_CREACION = usuarioLogueado.CODIGO_USUARIO;
                        entidad.FECHA_CREACION = DateTime.Now;
                        barriosDao.Agregar(entidad);
                    }
                    else
                    {
                        String barrio = entidad.BARRIO;

                        entidad = barriosDao.ObtenerDesdePk(entidad.BARRIO_ID);
                        entidad.BARRIO = barrio;

                        entidad.USUARIO_MODIFICACION = usuarioLogueado.CODIGO_USUARIO;
                        entidad.FECHA_MODIFICACION = DateTime.Now;
                        barriosDao.Actualizar(entidad);
                    }
                    barriosDao.Guardar();
                }
                
                using (BarriosCiudadesDao barrioCiudadDao = new BarriosCiudadesDao())
                {

                    if (Constantes.Operaciones.NUEVO.Equals(operacion))
                    {

                        //BARRIOS_CIUDADES BarrioCiudadEntidad = new BARRIOS_CIUDADES();

                        BarrioCiudad.BARRIO_ID = entidad.BARRIO_ID;
                        BarrioCiudad.CODIGO = "9426"; // cualquier numero cargo por ahora
                        BarrioCiudad.USUARIO_CREACION = usuarioLogueado.CODIGO_USUARIO;
                        BarrioCiudad.FECHA_CREACION = DateTime.Now;
                        barrioCiudadDao.Agregar(BarrioCiudad);
                        //barrioCiudadDao.Guardar();

                    }
                    else
                    {
                        Int64 barrioId = BarrioCiudad.BARRIO_ID;
                        Int64 ciudadId = BarrioCiudad.CIUDAD_ID;
                        String codigo = BarrioCiudad.CODIGO;

                        BarrioCiudad = barrioCiudadDao.ObtenerDesdePk(BarrioCiudad.BARRIO_CIUDAD_ID);


                        BarrioCiudad.BARRIO_ID = barrioId;
                        BarrioCiudad.CIUDAD_ID = ciudadId;
                        BarrioCiudad.CODIGO = codigo;
                        

                        BarrioCiudad.USUARIO_MODIFICACION = usuarioLogueado.CODIGO_USUARIO;
                        BarrioCiudad.FECHA_MODIFICACION = DateTime.Now;
                        barrioCiudadDao.Actualizar(BarrioCiudad);
                        

                    }
                    barrioCiudadDao.Guardar();


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
