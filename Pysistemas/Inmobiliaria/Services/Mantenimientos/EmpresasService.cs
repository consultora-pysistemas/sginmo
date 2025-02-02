using System;
using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.Mantenimiento;
using Inmobiliaria.Modelo.Views;

namespace Inmobiliaria.Services.Mantenimientos
{
    public class EmpresasService
    {

        public EMPRESAS Guardar(EMPRESAS empresa, String operacion)
        {
            try
            {
                using (EmpresasDao empresasDao = new EmpresasDao())
                {
                    if (Constantes.Operaciones.NUEVO.Equals(operacion))
                    {
                        if (empresa.SOCIO_NEGOCIO_ID == null)
                        {
                            using (SociosNegociosDao sociosNegociosDao = new SociosNegociosDao())
                            {
                               SOCIOS_NEGOCIOS socioNegocio = new SOCIOS_NEGOCIOS();
                               socioNegocio.RAZON_SOCIAL = empresa.RAZON_SOCIAL;
                               socioNegocio.NUMERO_DOCUMENTO = empresa.NUMERO_DOCUMENTO;
                               socioNegocio.DIGITO_VERIFICADOR = empresa.DIGITO_VERIFICADOR;
                               socioNegocio.TIPO_DOCUMENTO = empresa.TIPO_DOCUMENTO;
                               socioNegocio.TIPO_PERSONERIA = empresa.TIPO_PERSONERIA;
                               socioNegocio.DIRECCION = empresa.DIRECCION;
                               socioNegocio.TELEFONO = empresa.TELEFONO;
                               socioNegocio.CLASIFICACION_FISCAL = "GRAVADA";
                               socioNegocio.ACTIVO = Constantes.Booleano.SI;
                               socioNegocio.ES_EMPRESA = Constantes.Booleano.SI;
                               socioNegocio.ES_CONTRIBUYENTE = Constantes.Booleano.SI;
                               socioNegocio.ES_ADMINISTRADOR = socioNegocio.ES_CLIENTE = socioNegocio.ES_INQUILINO =
                                   socioNegocio.ES_PORTERO = socioNegocio.ES_PROPIETARIO = socioNegocio.ES_PROVEEDOR =
                                       socioNegocio.ES_VENDEDOR = Constantes.Booleano.NO;
                               socioNegocio.USUARIO_CREACION = empresa.USUARIO_CREACION;
                               socioNegocio.FECHA_CREACION = DateTime.Now;
                               sociosNegociosDao.Agregar(socioNegocio);
                               sociosNegociosDao.Guardar();
                               empresa.SOCIO_NEGOCIO_ID = socioNegocio.SOCIO_NEGOCIO_ID;
                               





                            }
                        }
                        empresasDao.Agregar(empresa);
                    }
                    else
                    {
                        empresasDao.Actualizar(empresa);
                    
                    }
                    empresasDao.Guardar();
                    if (Constantes.Operaciones.NUEVO.Equals(operacion))
                    {
                        //Crear sucursal por defecto
                        using (SucursalesDao sucursalesDao = new SucursalesDao())
                        {
                            SUCURSALES sucursal = new SUCURSALES();
                            sucursal.EMPRESA_ID = empresa.EMPRESA_ID;
                            sucursal.SUCURSAL = empresa.RAZON_SOCIAL;
                            sucursal.DIRECCION = empresa.DIRECCION;
                            sucursal.TELEFONO = empresa.TELEFONO;
                            sucursal.FECHA_CREACION = DateTime.Now;
                            sucursal.USUARIO_CREACION = empresa.USUARIO_CREACION;
                            sucursal.POR_DEFECTO = Constantes.Booleano.SI;
                            sucursalesDao.Agregar(sucursal);
                            sucursalesDao.Guardar();
                        }
                    }
                }
                
                return empresa;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
