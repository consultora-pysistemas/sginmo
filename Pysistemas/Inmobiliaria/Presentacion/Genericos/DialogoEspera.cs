using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inmobiliaria.Presentacion.Genericos
{
    public partial class DialogoEspera : Form
    {
        public Action ActionToExecute { get; set; }
        public DialogoEspera()
        {
            InitializeComponent();
        }
        private void TaskCompleted()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)(() =>
                {
                    Close();
                    DialogResult = DialogResult.OK;
                }));
            }
        }

        private void DialogoEspera_Shown(object sender, EventArgs e)
        {
            Task.Factory.StartNew(ActionToExecute).ContinueWith(t => TaskCompleted());
        }
    }
}
