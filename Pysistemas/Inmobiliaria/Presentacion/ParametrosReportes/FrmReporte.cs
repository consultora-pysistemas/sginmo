using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Inmobiliaria.Presentacion.ParametrosReportes
{
    public partial class FrmReporte : Genericos.FrmMaestro
    {
        public FrmReporte()
        {
            InitializeComponent();
        }

        private void FrmReporte_Load(object sender, System.EventArgs e)
        {
            crystalReportViewer1.ShowLogo = false;
            crystalReportViewer1.ShowCopyButton = false;
            crystalReportViewer1.ShowGroupTreeButton = false;
            crystalReportViewer1.ShowParameterPanelButton = false;
            crystalReportViewer1.ShowRefreshButton = false;
            //crViewer.ShowPageNavigateButtons = false;
            foreach (Control ctrl in crystalReportViewer1.Controls)
            {
                //Buscar toolstrip del visor de informes
                if (ctrl is ToolStrip)
                {
                    ToolStrip ts = (ToolStrip)ctrl;
                    foreach (ToolStripItem tsi in ts.Items)
                    {
                        //Buscar el botón exportar por un ImageIndex
                        if (tsi is ToolStripButton && tsi.ImageIndex == 8)
                        {

                            ToolStripButton crXb = (ToolStripButton)tsi;
                            //Clonar el aspecto 
                            ToolStripButton tsb = new ToolStripButton();
                            tsb.Size = crXb.Size;
                            tsb.Padding = crXb.Padding;
                            tsb.Margin = crXb.Margin;

                            tsb.TextImageRelation = crXb.TextImageRelation;
                            tsb.Text = crXb.Text;
                            tsb.ToolTipText = crXb.ToolTipText;
                            tsb.ImageScaling = crXb.ImageScaling;
                            tsb.ImageAlign = crXb.ImageAlign;
                            tsb.ImageIndex = crXb.ImageIndex;
                            tsb.Image = Properties.Resources.PDF_24px;
                            tsb.Visible = crXb.Visible;
                            tsb.Enabled = true;

                            //Añadir el nuevo botón
                            ts.Items.Insert(0, tsb);
                            tsb.Click += new EventHandler(Export_Click);


                            break;
                        }
                    }
                }
            }

            crystalReportViewer1.ShowExportButton = true;
        }

        private void Export_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDiag = new SaveFileDialog();
            saveDiag.Title = "Exportar Informe";
            saveDiag.Filter = "Adobe Acrobat (*.pdf) | *.pdf ";
            saveDiag.FilterIndex = 1;


            if (saveDiag.ShowDialog() == DialogResult.OK)
            {
                DiskFileDestinationOptions crDiskFileDestinationOptions = new DiskFileDestinationOptions();
                ReportDocument rptDoc = (ReportDocument)crystalReportViewer1.ReportSource;
                ExportOptions crExportOptions = rptDoc.ExportOptions;
                crDiskFileDestinationOptions.DiskFileName = saveDiag.FileName;
                crExportOptions.ExportDestinationOptions = crDiskFileDestinationOptions;
                crExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;



                crExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;

                rptDoc.Export(crExportOptions);
            }
        }
    }
}
