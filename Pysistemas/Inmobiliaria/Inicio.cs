using System;
using System.Windows.Forms;
using Inmobiliaria.Presentacion.Inicio;
using Inmobiliaria.Utilidades.Controles;
using System.Globalization;

namespace Inmobiliaria
{

    public class Inicio
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.ThreadException += Application_ThreadException;

            /*CobrosService cobrosService = new CobrosService();

            DateTime fechaVencimiento = new DateTime(2019,4,18);
            Int64 diasGracias = 3;
            CalculoDiasMontoMora calculoDiasMontoMora = new CalculoDiasMontoMora();
            calculoDiasMontoMora.fechaVencimiento = fechaVencimiento;
            calculoDiasMontoMora.diaGracias = diasGracias;
            calculoDiasMontoMora.montoMoraDia = 50000;
            calculoDiasMontoMora.fechaCobro = DateTime.Now;
            Console.WriteLine(cobrosService.CalcularMora(calculoDiasMontoMora).montoMora);
            ControlesUtilidades.GetNumeroFactura("1-1-2552");
            Utilidades.Seguridad.PysistemasLogger.Log(Application.StartupPath,"Principal");
            */

            // 46
            int thisWeekNumber = ControlesUtilidades.GetIso8601WeekOfYear(DateTime.Today.AddDays(6));
            // 11/11/2013  
            DateTime firstDayOfWeek = ControlesUtilidades.FirstDateOfWeek(DateTime.Today.Year, thisWeekNumber, CultureInfo.CurrentCulture);
            
            Console.WriteLine(firstDayOfWeek.AddDays(1));
            
            Console.WriteLine(firstDayOfWeek.AddDays(5));
            Console.WriteLine(Utilidades.Seguridad.PysistemasSeguridad.Encriptar("654321"));
            Application.Run(new Principal());
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            PysistemasMensajes.ShowInfo("Ha ocurrido un error inesperado");
        }
    }
}