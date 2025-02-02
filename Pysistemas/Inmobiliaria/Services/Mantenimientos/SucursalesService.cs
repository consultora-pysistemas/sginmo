using System;
using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.Mantenimiento;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Utilidades.Controles;

namespace Inmobiliaria.Services.Mantenimientos
{
    public class SucursalesService
    {
        public SUCURSALES Guardar(SUCURSALES sucursal, String operacion)
        {
            try
            {
                using (SucursalesDao sucursalesDao = new SucursalesDao())
                {
                    if (Constantes.Operaciones.NUEVO.Equals(operacion))
                    {
                        sucursalesDao.Agregar(sucursal);
                        
                    }
                    else
                    {
                        sucursalesDao.Actualizar(sucursal);
                    }
                    sucursalesDao.Guardar();
                }
                return sucursal;
            }
            catch (Exception e)
            {
                PysistemasMensajes.ShowError(e.Message);
                return sucursal;
            }
        }
    }
}
