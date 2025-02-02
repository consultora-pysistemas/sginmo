using System.Windows.Forms;

namespace Inmobiliaria.Utilidades.Controles
{
    public class PysistemasMensajes
    {
        public static void ShowInfo(string message)
        {
            MessageBox.Show(message, "Información PySistemas", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }


        public static void ShowError(string message)
        {
            MessageBox.Show(message, "Error PySistemas", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }


        public static void ShowAlert(string message)
        {
            MessageBox.Show(message, "Advertencia PySistemas", MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);
        }


        public static bool AskConfirmation(string message)
        {
            return DialogResult.Yes == MessageBox.Show(message, "Confirmación PySistemas", MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question);
        }
    }
}
