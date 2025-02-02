using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.Mantenimiento;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Utilidades.Controles;
using System;

namespace Inmobiliaria.Services.Generales
{
    public class FormasPagosService
    {
        public FORMAS_PAGOS Guardar(String operacion, FORMAS_PAGOS entidad, USUARIOS usuarioLogueado)
        {
            try
            {
                using (FormasPagosDao formasPagosDao = new FormasPagosDao())
                {
                    if (Constantes.Operaciones.NUEVO.Equals(operacion))
                    {

                        entidad.USUARIO_CREACION = usuarioLogueado.CODIGO_USUARIO;
                        entidad.FECHA_CREACION = DateTime.Now;
                        formasPagosDao.Agregar(entidad);



                    }
                    else
                    {
                        String formaPago = entidad.FORMA_PAGO;
                        String codigo = entidad.CODIGO;
                        String requiereBanco = entidad.REQUERE_BANCO;
                        String porDefecto = entidad.POR_DEFECTO;
                        String dias = entidad.DIAS.ToString();

                        entidad = formasPagosDao.ObtenerDesdePk(entidad.FORMA_PAGO_ID);

                        entidad.FORMA_PAGO = formaPago;
                        entidad.CODIGO = codigo;
                        entidad.REQUERE_BANCO = requiereBanco;
                        entidad.POR_DEFECTO = porDefecto;
                        entidad.DIAS = int.Parse(dias);


                        entidad.USUARIO_MODIFICACION = usuarioLogueado.CODIGO_USUARIO;
                        entidad.FECHA_MODIFICACION = DateTime.Now;
                        formasPagosDao.Actualizar(entidad);
                    }
                    formasPagosDao.Guardar();
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
