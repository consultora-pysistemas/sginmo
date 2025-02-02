using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.Mantenimiento;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Utilidades.Controles;
using System;

namespace Inmobiliaria.Services.Mantenimientos
{
    public class DepartamentosService
    {
        public DEPARTAMENTOS Guardar(String operacion, DEPARTAMENTOS entidad, DEPARTAMENTOS_PAISES DepartamentoPaisEntidad, USUARIOS usuarioLogueado)
        {
            try
            {
                using (DepartamentosDao departamentosDao = new DepartamentosDao())
                {
                    if (Constantes.Operaciones.NUEVO.Equals(operacion))
                    {

                        entidad.USUARIO_CREACION = usuarioLogueado.CODIGO_USUARIO;
                        entidad.FECHA_CREACION = DateTime.Now;
                        departamentosDao.Agregar(entidad);



                    }
                    else
                    {
                        String Departamento = entidad.DEPARTAMENTO;

                        entidad = departamentosDao.ObtenerDesdePk(entidad.DEPARTAMENTO_ID);

                        entidad.DEPARTAMENTO = Departamento;
                        entidad.USUARIO_MODIFICACION = usuarioLogueado.CODIGO_USUARIO;
                        entidad.FECHA_MODIFICACION = DateTime.Now;
                        departamentosDao.Actualizar(entidad);
                    }
                    departamentosDao.Guardar();
                }

                using (DepartamentosPaisesDao departamentoPaisDao = new DepartamentosPaisesDao())
                {
                    if (Constantes.Operaciones.NUEVO.Equals(operacion))
                    {                        
                        DepartamentoPaisEntidad.DEPARTAMENTO_ID = entidad.DEPARTAMENTO_ID;
                        DepartamentoPaisEntidad.CODIGO = "123456";

                        DepartamentoPaisEntidad.USUARIO_CREACION = usuarioLogueado.CODIGO_USUARIO;
                        DepartamentoPaisEntidad.FECHA_CREACION = DateTime.Now;
                        departamentoPaisDao.Agregar(DepartamentoPaisEntidad);



                    }
                    else
                    {
                        Int64 DepartamentoId = DepartamentoPaisEntidad.DEPARTAMENTO_ID;

                        DepartamentoPaisEntidad = departamentoPaisDao.ObtenerDesdePk(DepartamentoPaisEntidad.DEPARTAMENTO_PAIS_ID);

                        DepartamentoPaisEntidad.DEPARTAMENTO_ID = DepartamentoId;

                        DepartamentoPaisEntidad.USUARIO_MODIFICACION = usuarioLogueado.CODIGO_USUARIO;
                        DepartamentoPaisEntidad.FECHA_MODIFICACION = DateTime.Now;
                        departamentoPaisDao.Actualizar(DepartamentoPaisEntidad);
                    }
                    departamentoPaisDao.Guardar();
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
