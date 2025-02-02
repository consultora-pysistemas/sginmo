using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Inmobiliaria.Utilidades.Controles
{
    public class ControlesUtilidades
    {
        public static void camposNumericos(KeyPressEventArgs e)
        {
            if (((e.KeyChar) < 48 && e.KeyChar != 8 && e.KeyChar != 44) || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
        public static void camposNumericosFacturas(KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 && e.KeyChar != 8 && e.KeyChar != 45) || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
        public static Int64 calcularDigitoVerificador(Int64 numDoc)
        {
            

            int[] intPesos = { 2, 3, 4, 5, 6, 7, 8, 9, 2, 3, 4, 5, 6, 7, 8, 9 };
            String numDocString = numDoc.ToString();
            if (numDocString.Length > 16)
                throw new Exception("El número de documento no es válido");
            int suma = 0;
            int index = 0;
            for (int intPos = numDocString.Length - 1; intPos >= 0; intPos--)
            {
                suma += Convert.ToInt32(numDocString[intPos].ToString()) * intPesos[index];
                index++;
            }
            int resto = (suma * 10) % 11;
            int digito = resto;
            if (digito >= 10)
                digito = 0;

            return digito;

        }

        public static void ClearComponents(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox tb = (TextBox)ctrl;
                    tb.Text = String.Empty;
                }
                else if (ctrl is ComboBox)
                {
                    ComboBox cb = (ComboBox)ctrl;
                    cb.SelectedIndex = -1;
                }
                else if (ctrl is DataGridView)
                {
                    DataGridView dg = ctrl as DataGridView;
                    dg.DataSource = null;
                    dg.Rows.Clear();
                }
                else if (ctrl is CheckBox)
                {
                    CheckBox chk = (CheckBox)ctrl;
                    chk.Checked = false;
                }
                else if (ctrl is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)ctrl;
                    dtp.Checked = false;
                }
            }


        }

        public static void EnableDisableComponents(Control control, Boolean enable)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox tb = (TextBox)ctrl;
                    tb.ReadOnly = !enable;
                }
                else if (ctrl is ComboBox)
                {
                    ComboBox cb = (ComboBox)ctrl;
                    cb.Enabled = enable;
                }
                else if (ctrl is DataGridView)
                {
                    DataGridView dg = ctrl as DataGridView;
                    dg.ReadOnly = !enable;

                }
                else if (ctrl is CheckBox)
                {
                    CheckBox chk = (CheckBox)ctrl;
                    chk.Enabled = enable;
                }
                else if (ctrl is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)ctrl;
                    dtp.Enabled = enable;
                }
            }


        }
        public static void addTooltips(Control c, String mensaje)
        {
            ToolTip tt = new ToolTip();
            tt.IsBalloon = true;
            tt.UseAnimation = true;
            tt.SetToolTip(c, mensaje);
        }
        public static void InicializarControl(Control ctrl)
        {
            if (ctrl is ComboBox)
            {
                ComboBox cb = (ComboBox)ctrl;
                cb.SelectedIndex = -1;
            }
            else if (ctrl is TextBox)
            {
                TextBox txtb = (TextBox)ctrl;
                txtb.Text = String.Empty;
            }
        }

        public static void OperacionesTabs(Boolean habilitar, TabControl tctrl)
        {
            for (int i = 0; i < tctrl.TabPages.Count - 1; i++)
            {
                if (tctrl.Controls[i] is Panel)
                {
                    tctrl.Controls[i].Enabled = habilitar;
                }
            }
        }


        /// <summary>
        /// Borra del comboBox el valor seleccionado
        /// </summary>
        /// <param name="cb">The cb.</param>
        public static void InicializarComboBox(ComboBox cb)
        {
            cb.SelectedIndex = -1;


        }

        public static Int32 DevolverValorCombo(ComboBox cb)
        {
            if (cb.SelectedValue != null)
            {
                return Int32.Parse(cb.SelectedValue.ToString());
            }
            cb.SelectedIndex = -1;
            return -2;
        }

        public static void ObtenerValorCombo(ComboBox cb, Int32 valor)
        {

            if (valor == -1)
            {
                cb.SelectedIndex = -1;
            }
            else
            {
                cb.SelectedValue = valor;
            }
        }

        public static String GetPuntoVentaAutomaticamente(string p)
        {
            String numero = null, numeroFactura = null;

            numero = p.PadLeft(7, '0');

            numeroFactura = "001-001-" + numero;

            return numeroFactura;
        }
        public static String GetNumeroFactura(String numero)
        {
            String numeroCompleto = null, sucursal = null, puntoExpedicion = null, aux = null;
            string[] separador = new string[] { "-" };

            String[] parte = numero.Split(separador, StringSplitOptions.RemoveEmptyEntries);
            if (parte.Length > 2) { 
                if (!String.IsNullOrEmpty(parte[1]) && !String.IsNullOrEmpty(parte[2]))
                {
                    sucursal = parte[0].PadLeft(3, '0');
                    puntoExpedicion = parte[1].PadLeft(3, '0');
                    aux = parte[2].PadLeft(7, '0');
                    numeroCompleto = sucursal + "-" + puntoExpedicion + "-" + aux;
                }
                else
                {
                    numeroCompleto = "0";
                }
            }else
            {
                numeroCompleto = numero;
            }

            return numeroCompleto;
        }

        public static String aplicarFormatoNumerico(String valor)
        {
            return valor == String.Empty ? String.Empty : String.Format("{0:n0}", int.Parse(valor));

        }
        public static String quitarFormatoNumerico(String valor)
        {

            if (valor.IndexOf(",") != -1)
                return String.Format("{0:g}", int.Parse(valor.Replace(",", "")));

            // para el teclado en español se usa el punto (.), posible bug en el proceso de desarrollo
            if (valor.IndexOf(".") != -1)
                return String.Format("{0:g}", int.Parse(valor.Replace(".", "")));

            return valor;
        }
        string[] NumeroBase ={
            "",
            "uno",
            "dos",
            "tres",
            "cuatro",
            "cinco",
            "seis",
            "siete",
            "ocho",
            "nueve",
            "diez",
            "once",
            "doce",
            "trece",
            "catorce",
            "quince",
            "dieciseis",
            "diecisiete",
            "dieciocho",
            "diecinueve",
        };
        string[] NumeroBase2 = {
            "",
            "",
            "veinte",
            "treinta",
            "cuarenta",
            "cincuenta",
            "sesenta",
            "setenta",
            "ochenta",
            "noventa"
        };
        public string Convertir_Numero(string num)
        {
            string Resultado = "";
            int Tama_Cadena = num.Length;
            if (Tama_Cadena < 4)//3
                Resultado = Trio(Tama_Cadena, num);
            else if (Tama_Cadena < 7)//6
            {
                int millares = Tama_Cadena - 3;
                if (num.Substring(0, 1) == "1" && Tama_Cadena == 4)
                    Resultado = "mil " + Trio(3, num.Substring(millares, 3));
                else
                    Resultado = Trio(millares, num.Substring(0, millares)) + " mil " + Trio(3, num.Substring(millares, 3));
            }
            else if (Tama_Cadena < 10)//9
            {
                int millares = Tama_Cadena - 3;
                int millon = Tama_Cadena - 6;
                if (num.Substring(0, 1) == "1" && Tama_Cadena == 7)
                {
                    if (Trio(3, num.Substring(millon, 3)) == "")
                        Resultado = "un millón " + Trio(3, num.Substring(millares, 3));
                    else
                        Resultado = "millón " + Trio(3, num.Substring(millon, 3)) + " mil " + Trio(3, num.Substring(millares, 3));
                }
                else
                    Resultado = Trio(millon, num.Substring(0, millon)) + " milllones " + Trio(3, num.Substring(millon, 3)) + " mil " + Trio(3, num.Substring(millares, 3));
            }
            else if (Tama_Cadena < 13)
                Resultado = Trio(3, num.Substring(0, 3)) + " mil " + Trio(3, num.Substring(4, 3)) + " milllones " + Trio(3, num.Substring(7, 3)) + " mil " + Trio(3, num.Substring(10, 3));
            else if (Tama_Cadena < 16)
                Resultado = Trio(3, num.Substring(0, 3)) + " billones " + Trio(3, num.Substring(4, 3)) + " mil " + Trio(3, num.Substring(7, 3)) + " milllones " + Trio(3, num.Substring(10, 3)) + " mil " + Trio(3, num.Substring(13, 3));
            else if (Tama_Cadena < 19)
                Resultado = Trio(3, num.Substring(0, 3)) + " mil " + Trio(3, num.Substring(4, 3)) + " billones " + Trio(3, num.Substring(7, 3)) + " mil " + Trio(3, num.Substring(10, 3)) + " milllones " + Trio(3, num.Substring(13, 3)) + " mil " + Trio(3, num.Substring(13, 3));
            else if (Tama_Cadena < 21)
                Resultado = "";
            else if (Tama_Cadena < 24)
                Resultado = "";

            string initialLetter = Resultado.Substring(0, 1).ToUpper();
            Resultado = initialLetter + Resultado.Substring(1);
            return Resultado;
        }
        string Unidades(string numx)
        {
            return NumeroBase[Convert.ToInt32(numx)];
        }
        string Decenas(string numx)
        {
            string Pre = "";
            int Num = Convert.ToInt32(numx);
            if (Num < 20)
            {
                Pre = NumeroBase[Num];
            }
            else
            {
                if (numx.Substring(0, 1) == "2")
                    Pre = NumeroBase2[2] + Unidades(numx.Substring(1, 1));
                else
                {
                    if (numx.Substring(1, 1) == "0")
                        Pre = NumeroBase2[Convert.ToInt32(numx.Substring(0, 1))];
                    else
                        Pre = NumeroBase2[Convert.ToInt32(numx.Substring(0, 1))] + " y " + Unidades(numx.Substring(1, 1));
                }
            }
            return Pre;
        }
        string Centenas(string numx)
        {
            string Pre = "";
            if (numx.Substring(0, 1) == "1")
            {
                if (numx.Substring(1, 1) == "0" && numx.Substring(2, 1) == "0")
                    Pre = "cien ";
                else
                    Pre = "ciento " + Decenas(numx.Substring(1, 2));
            }
            else if (numx.Substring(0, 1) == "0")
            {
                Pre = "" + Decenas(numx.Substring(1, 2));
            }
            else if (numx.Substring(0, 1) == "5")
            {
                Pre = "quinientos " + Decenas(numx.Substring(1, 2));
            }
            else if (numx.Substring(0, 1) == "7")
            {
                Pre = "setecientos " + Decenas(numx.Substring(1, 2));
            }
            else if (numx.Substring(0, 1) == "9")
            {
                Pre = "novecientos " + Decenas(numx.Substring(1, 2));
            }
            else
            {
                Pre = NumeroBase[Convert.ToInt32(numx.Substring(0, 1))] + "cientos " + Decenas(numx.Substring(1, 2));
            }
            return Pre;
        }
        string Trio(int cant, string Val)
        {
            string CadenaFinal = "";
            switch (cant)
            {
                case 1:
                    CadenaFinal = Unidades(Val);
                    break;
                case 2:
                    CadenaFinal = Decenas(Val);
                    break;
                case 3:
                    CadenaFinal = Centenas(Val);
                    break;
            }
            return CadenaFinal;
        }
        public String aplicarFormatoFactura(String valor)
        {
            if (Regex.IsMatch(valor, @"/\d{3}-\d{3}-\d{7}/"))
            {
                return valor;
            }
            else
            {
               


            }
            return null;
        }
        public static string ToTitleCase(string str)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
        }

        public static int GetIso8601WeekOfYear(DateTime time)
        {
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }

            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }

        public static DateTime FirstDateOfWeek(int year, int weekOfYear, System.Globalization.CultureInfo ci)
        {
            DateTime jan1 = new DateTime(year, 1, 1);
            int daysOffset = (int)ci.DateTimeFormat.FirstDayOfWeek - (int)jan1.DayOfWeek;
            DateTime firstWeekDay = jan1.AddDays(daysOffset);
            int firstWeek = ci.Calendar.GetWeekOfYear(jan1, ci.DateTimeFormat.CalendarWeekRule, ci.DateTimeFormat.FirstDayOfWeek);
            if ((firstWeek <= 1 || firstWeek >= 52) && daysOffset >= -3)
            {
                weekOfYear -= 1;
            }
            return firstWeekDay.AddDays(weekOfYear * 7);
        }

    }
}
