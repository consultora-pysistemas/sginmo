namespace Inmobiliaria.Modelo.Views
{
    public class Constantes
    {
        public static class Booleano
        {
            public static string SI = "SI";
            public static string NO = "NO";
        }

        public static class Operaciones
        {
            public static string NUEVO = "N";
            public static string EDITAR = "E";
            public static string BUSCAR = "B";
            public static string RENOVAR = "R";
        }

       

        public static class TiposSociosNegocios
        {            
            public static string PROPIETARIO = "PROPIETARIO";
            public static string INQUILINO = "CLIENTE";
            public static string PORTERO = "PORTERO";
            public static string ADMINISTRADOR = "ADMINISTRADOR";
            public static string CLIENTE = "CLIENTE";
            public static string PROVEEDOR = "PROVEEDOR";
            public static string EMPRESA = "EMPRESA";
            public static string VENDEDOR = "VENDEDOR";                                   
        }

        public static class TipoRespuesta
        {
            public static string OK = "OK";
            public static string ERROR = "ERROR";
        }

        public static class VariablesEntorno
        {
            public static string EMPRESA_ID = "empresa_id";
            public static string EMPRESA = "empresa";
            public static string SUCURSAL_ID = "sucursal_id";
            public static string SUCURSAL = "sucursal";
        }

        public static class Dominios
        {
            public static string TIPOS_PERSONERIAS = "TIPOS_PERSONERIAS";
            public static string TIPOS_DOCUMENTOS_IDENTIDAD = "TIPOS_DOCUMENTOS_IDENTIDAD";
            public static string TIPOS_ENTIDADES_INMOBILIARIAS = "TIPOS_ENTIDADES_INMOBILIARIAS";
            public static string TIPOS_OPERACIONES = "TIPOS_OPERACIONES";
            public static string TIPOS_PROPIEDADES = "TIPOS_PROPIEDADES";
            public static string TIPOS_GASTOS = "TIPOS_GASTOS";
            public static string TIPOS_MONEDAS = "TIPOS_MONEDAS";
            public static string TIPOS_CONTRATOS = "TIPOS_CONTRATOS";
            public static string CONDICION_OPERACION = "CONDICION_OPERACION";
            public static string TIPO_ITEM_INGR_EGR = "TIPO_ITEM_INGR_EGR";
            public static string TIPO_IMPUTACION = "TIPO_IMPUTACION";
            public static string ESTADO_INGRESO_EGRESO = "ESTADO_INGRESO_EGRESO";
            public static string MONTO_MORA_DEFECTO = "MONTO_MORA_DEFECTO";
            public static string DIAS_GRACIA_VENCIMIENTO = "DIAS_GRACIA_VENCIMIENTO";
            public static string PORCENTAJE_COMISION_VENTA = "PORCENTAJE_COMISION_VENTA";
            public static string PORCENTAJE_COMISION_ALQUILER = "PORCENTAJE_COMISION_ALQUILER";
            public static string MOTIVO_LIQUIDACION = "MOTIVO_LIQUIDACION";
            public static string TIPOS_PERFILES = "TIPOS_PERFILES";
            public static string TIPOS_FINANCIACIONES = "TIPOS_FINANCIACIONES";



        }
        public static class TiposPerfiles
        {
            public static string ADMINISTRADOR = "ADMINISTRADOR";
            public static string USUARIO = "USUARIO";
        }
        public static class EstadosUnidadesInmobiliarias
        {
            public static string VIGENTE = "VIGENTE";
            public static string FINALIZADO = "FINALIZADO";
            public static string LIBRE = "LIBRE";
            public static string OCUPADA = "OCUPADA";
            public static string VENDIDA = "VENDIDA";
        }

        public static class TiposOperacionesInmuebles
        {
            public static string ALQUILER = "ALQUILER";
            public static string VENTA = "VENTA";
        }

        public static class TiposContratos
        {
            public static string PRIVADO = "PRIVADO";
            public static string PUBLICO = "PUBLICO";
        }

        public static class CondicionOperaciones
        {
            public static string CONTADO = "CONTADO";
            public static string CREDITO = "CREDITO";
        }

        public static class TiposIngresosEgresos
        {
            public static string INGRESO = "INGRESO";
            public static string EGRESO = "EGRESO";
            public static string DESCUENTO = "DESCUENTO";
        }

        public static class TiposImputaciones
        {
            public static string ENTIDAD_INMOBILIARIA = "ENTIDAD_INMOBILIARIA";
            public static string PROPIEDADES = "PROPIEDAD";
            public static string INQUILINOS = "INQUILINO";
            public static string PROPIETARIOS = "PROPIETARIO";
            public static string VENDEDOR = "VENDEDOR";
            public static string ADMINISTRADOR = "ADMINISTRADOR";
        }

        public static class EstadosIngresosEgresos
        {
            public static string PENDIENTE = "PENDIENTE";
            public static string CANCELADO = "CANCELADO";
        }

        public static class OperacionTotal
        {
            public static string MAS = "MAS";
            public static string MENOS = "MENOS";
        }

        public static class TiposPropiedades
        {
            public static string LOTE = "LOTE";
            
        }
        public static class TiposEntidades
        {
            public static string LOTEAMIENTO = "LOTEAMIENTO";
            public static string EDIFICIO = "EDIFICIO";
            public static string NINGUNA = "NINGUNA";


        }

        public static class ItemIngresosEgresosAplicacion
        {
            public static string COMISION_VENTA = "COMISION_VENTA";
            public static string COMISION_ALQUILER = "COMISION_ALQUILER";
            public static string DEPOSITO_GARANTIA = "DEPOSITO_GARANTIA";
            public static string ANDE = "ANDE";
            public static string MATERIALES = "MATERIALES";
            public static string MANO_OBRA = "MANO_OBRA";
            public static string ALQUILERES_PENDIENTES = "ALQUILERES_PENDIENTES";

        }
        


    }
}
