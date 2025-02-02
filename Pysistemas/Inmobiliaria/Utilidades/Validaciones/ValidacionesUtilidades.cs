using System;

namespace Inmobiliaria.Utilidades.Validaciones
{
    public class ValidacionesUtilidades
    {
        public static string ValidarArgumento(string argumento, string mensaje)
        {
            if (string.IsNullOrEmpty(argumento))
                throw new Exception(mensaje);
            return argumento;
        }

        public static Object ValidarArgumento(Object argumento, string mensaje)
        {
            if (argumento == null)
                throw new Exception(mensaje);
            return argumento;
        }


        public static void ValidarArgumento(Boolean expresion, string mensaje)
        {
            if (!expresion)
                throw new Exception(mensaje);
        }

        public static String ObtenerError(String codigo)
        {
            switch (codigo)
            {
                case "23000":
                    return "Error no se puede duplicar los datos";
                    
                default:
                    return string.Empty;
                    
                    
                    
            }
        }
    }
}
