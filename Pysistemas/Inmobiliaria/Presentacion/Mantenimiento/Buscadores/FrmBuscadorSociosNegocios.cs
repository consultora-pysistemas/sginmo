using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Presentacion.Genericos;
using Inmobiliaria.Presentacion.Inicio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Inmobiliaria.Presentacion.Mantenimiento.Buscadores
{
    public partial class FrmBuscadorSociosNegocios : FrmMaestro
    {
        public String TipoSocioNegocio { get; set; }
        public SOCIOS_NEGOCIOS_VIEW Entity { get; set; }
        public FrmBuscadorSociosNegocios(Principal principal,String tipoSocioNegocio):base(principal)
        {
            InitializeComponent();
            TipoSocioNegocio = tipoSocioNegocio;
            Entity = new SOCIOS_NEGOCIOS_VIEW();
             
            ConfiguracionesGrid(dgvSociosNegocios);
            
        }

       

        private void FrmBuscadorSociosNegocios_Shown(object sender, EventArgs e)
        {
            txtBusqueda.Focus();
            Buscar();
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)13))
            {
                Buscar();
            }
        }

        public void Buscar()
        {
            
            using(BusquedaSociosNegociosViewDao busquedaSocioNegocioView = new BusquedaSociosNegociosViewDao())
            {
                if (String.IsNullOrWhiteSpace(txtBusqueda.Text))
                {
                    dgvSociosNegocios.DataSource = busquedaSocioNegocioView.ObtenerLista();
                    return;
                }
                if (Constantes.TiposSociosNegocios.ADMINISTRADOR.Equals(TipoSocioNegocio))
                {
                    dgvSociosNegocios.DataSource = busquedaSocioNegocioView.ObtenerDesdeFiltros(s => s.SOCIO_NEGOCIO.ToUpper().Contains(txtBusqueda.Text.ToUpper()) || s.NUMERO_DOCUMENTO.Contains(txtBusqueda.Text) && s.ES_ADMINISTRADOR.Equals(Constantes.Booleano.SI));
                }
                else if (Constantes.TiposSociosNegocios.INQUILINO.Equals(TipoSocioNegocio))
                {
                    dgvSociosNegocios.DataSource = busquedaSocioNegocioView.ObtenerDesdeFiltros(s => s.SOCIO_NEGOCIO.ToUpper().Contains(txtBusqueda.Text.ToUpper()) || s.NUMERO_DOCUMENTO.Contains(txtBusqueda.Text) && s.ES_INQUILINO.Equals(Constantes.Booleano.SI));
                }
                else if (Constantes.TiposSociosNegocios.PROPIETARIO.Equals(TipoSocioNegocio))
                {
                    dgvSociosNegocios.DataSource = busquedaSocioNegocioView.ObtenerDesdeFiltros(s => s.SOCIO_NEGOCIO.ToUpper().Contains(txtBusqueda.Text.ToUpper()) || s.NUMERO_DOCUMENTO.Contains(txtBusqueda.Text) && s.ES_PROPIETARIO.Equals(Constantes.Booleano.SI));
                }
                else if (Constantes.TiposSociosNegocios.PORTERO.Equals(TipoSocioNegocio))
                {
                    dgvSociosNegocios.DataSource = busquedaSocioNegocioView.ObtenerDesdeFiltros(s => s.SOCIO_NEGOCIO.ToUpper().Contains(txtBusqueda.Text.ToUpper()) || s.NUMERO_DOCUMENTO.Contains(txtBusqueda.Text) && s.ES_PORTERO.Equals(Constantes.Booleano.SI));
                }
                else if (Constantes.TiposSociosNegocios.VENDEDOR.Equals(TipoSocioNegocio))
                {
                    dgvSociosNegocios.DataSource = busquedaSocioNegocioView.ObtenerDesdeFiltros(s => s.SOCIO_NEGOCIO.ToUpper().Contains(txtBusqueda.Text.ToUpper()) || s.NUMERO_DOCUMENTO.Contains(txtBusqueda.Text) && s.ES_VENDEDOR.Equals(Constantes.Booleano.SI));
                }
                
            }
        }

        private void FrmBuscadorSociosNegocios_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Búsqueda de " + TipoSocioNegocio;
            String tipo = String.Empty;
            if (Constantes.TiposSociosNegocios.ADMINISTRADOR.Equals(TipoSocioNegocio))
            {
                tipo = "Administradores";
                dgvSociosNegocios.Columns[2].HeaderText = "Administrador";
            }
            else if (Constantes.TiposSociosNegocios.INQUILINO.Equals(TipoSocioNegocio))
            {
                tipo = "Inquilinos";
                dgvSociosNegocios.Columns[2].HeaderText = "Clientes";
            }
            else if (Constantes.TiposSociosNegocios.PROPIETARIO.Equals(TipoSocioNegocio))
            {
                tipo = "Propietarios";
                dgvSociosNegocios.Columns[2].HeaderText = "Propietario";
            }
            else if (Constantes.TiposSociosNegocios.PORTERO.Equals(TipoSocioNegocio))
            {
                tipo = "Porteros";
                dgvSociosNegocios.Columns[2].HeaderText = "Portero";
            }
            else if (Constantes.TiposSociosNegocios.VENDEDOR.Equals(TipoSocioNegocio))
            {
                tipo = "Vendedores";
                dgvSociosNegocios.Columns[2].HeaderText = "Vendedores";
            }
            else
            {
                tipo = "Socio de Negocios";
                dgvSociosNegocios.Columns[2].HeaderText = "Socio de Negocio";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(dgvSociosNegocios.CurrentRow != null)
            {
                Int64 socioNegocioId = Int64.Parse(dgvSociosNegocios.CurrentRow.Cells["sOCIONEGOCIOIDDataGridViewTextBoxColumn"].Value.ToString());
                using(BusquedaSociosNegociosViewDao socioNegocioDao = new BusquedaSociosNegociosViewDao())
                {
                    IList<SOCIOS_NEGOCIOS_VIEW> lista = socioNegocioDao.ObtenerDesdeFiltros(s=>s.SOCIO_NEGOCIO_ID.Equals(socioNegocioId));
                    Entity = lista[0];
                }
                DialogResult = DialogResult.OK;
                Hide();
            }
            else
            {
                Buscar();
            }

        }

        private void dgvSociosNegocios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnGuardar_Click(null, null);
        }

        private void dgvSociosNegocios_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnGuardar_Click(null, null);
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {            
                Buscar();
            
        }

        private void dgvSociosNegocios_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvSociosNegocios.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
