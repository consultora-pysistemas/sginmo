using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.Mantenimiento;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Presentacion.Inicio;
using Inmobiliaria.Presentacion.Mantenimiento.SociosNegocios;
using Inmobiliaria.Utilidades.Controles;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Inmobiliaria.Presentacion.Mantenimiento.Buscadores
{
    public partial class FrmBusquedaSociosNegocios : Genericos.FrmBuscadorGenerico
    {
        public string TipoSocioNegocio { get; set; }

        public FrmBusquedaSociosNegocios(String Tipo,Principal principal):base(principal)
        {
            InitializeComponent();            
            TipoSocioNegocio = Tipo;
            lblBusqueda.Text = "Búsqueda de " + TipoSocioNegocio;
            lblTitulo.Text = String.Empty;
            ConfiguracionesGrid(dgvSociosNegocios);
            tsbtnEliminar.Visible = false;
        }
        private void FrmBusquedaSociosNegocios_Load(object sender, EventArgs e)
        {             
            String tipo = String.Empty;
            if (Constantes.TiposSociosNegocios.ADMINISTRADOR.Equals(TipoSocioNegocio))
            {
                tipo = "Administradores";
                dgvSociosNegocios.Columns[2].HeaderText = "Administrador";
            }
            else if (Constantes.TiposSociosNegocios.INQUILINO.Equals(TipoSocioNegocio))
            {
                tipo = "Clientes";
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
                dgvSociosNegocios.Columns[2].HeaderText = "Portero";
            }
            else
            {
                tipo = "Socio de Negocios";
                dgvSociosNegocios.Columns[2].HeaderText = "Socio de Negocio";
            }

        }

        protected override void Nuevo()
        {
            FrmSociosNegocios frmSociosNegocios = new FrmSociosNegocios(FrmPrincipal, Constantes.Operaciones.NUEVO, TipoSocioNegocio);

            if (DialogResult.OK.Equals(frmSociosNegocios.ShowDialog()))
            {
               
                PysistemasMensajes.ShowInfo("Los datos han sido guardados con éxito");
            }
            btnCancelar_Click(null, null);
        }

        protected override void Editar()
        {
            if (dgvSociosNegocios.CurrentRow != null)
            {
                FrmSociosNegocios frmSociosNegocios = new FrmSociosNegocios(FrmPrincipal, Constantes.Operaciones.EDITAR, TipoSocioNegocio);
                frmSociosNegocios.Entity = ObtenerEntity();
                if (DialogResult.OK.Equals(frmSociosNegocios.ShowDialog()))
                {

                    PysistemasMensajes.ShowInfo("Los datos han sido guardados con éxito");
                }
                btnCancelar_Click(null, null);
            }
        }

        private SOCIOS_NEGOCIOS ObtenerEntity()
        {
            Int64 id = Int64.Parse(dgvSociosNegocios.CurrentRow.Cells[0].Value.ToString());
            using (SociosNegociosDao socioNegocioDao = new SociosNegociosDao())
            {
                return socioNegocioDao.ObtenerDesdePk(id);
            }
        }

        private void pbBuscar_Click(object sender, EventArgs e)
        {
            btnBuscar_Click(sender, e);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //if (String.IsNullOrEmpty(txtSocioNegocio.Text) && String.IsNullOrWhiteSpace(txtNumeroDocumento.Text))
            //    return;
            using (BusquedaSociosNegociosViewDao socioNegocioView = new BusquedaSociosNegociosViewDao())
            {
                if (!String.IsNullOrEmpty(txtSocioNegocio.Text))
                {
                    if (Constantes.TiposSociosNegocios.ADMINISTRADOR.Equals(TipoSocioNegocio))
                    {
                        dgvSociosNegocios.DataSource = socioNegocioView.ObtenerDesdeFiltros(it => it.SOCIO_NEGOCIO.ToUpper().Contains(txtSocioNegocio.Text.ToUpper()) && it.ES_ADMINISTRADOR.Equals(Constantes.Booleano.SI));
                    }
                    else if (Constantes.TiposSociosNegocios.INQUILINO.Equals(TipoSocioNegocio))
                    {
                        dgvSociosNegocios.DataSource = socioNegocioView.ObtenerDesdeFiltros(it => it.SOCIO_NEGOCIO.ToUpper().Contains(txtSocioNegocio.Text.ToUpper()) && it.ES_INQUILINO.Equals(Constantes.Booleano.SI));
                    }
                    else if (Constantes.TiposSociosNegocios.PROPIETARIO.Equals(TipoSocioNegocio))
                    {
                        dgvSociosNegocios.DataSource = socioNegocioView.ObtenerDesdeFiltros(it => it.SOCIO_NEGOCIO.ToUpper().Contains(txtSocioNegocio.Text.ToUpper()) && it.ES_PROPIETARIO.Equals(Constantes.Booleano.SI));
                    }
                    else if (Constantes.TiposSociosNegocios.PORTERO.Equals(TipoSocioNegocio))
                    {
                        dgvSociosNegocios.DataSource = socioNegocioView.ObtenerDesdeFiltros(it => it.SOCIO_NEGOCIO.ToUpper().Contains(txtSocioNegocio.Text.ToUpper()) && it.ES_PORTERO.Equals(Constantes.Booleano.SI));
                    }
                    /*
                    else if (Constantes.TiposSociosNegocios.VENDEDOR.Equals(TipoSocioNegocio))
                    {
                        dgvSociosNegocios.DataSource = socioNegocioView.ObtenerDesdeFiltros(it => it.SOCIO_NEGOCIO.ToUpper().Contains(txtSocioNegocio.Text.ToUpper()) && it.ES_VENDEDOR.Equals(Constantes.Booleano.SI));
                    }
                    */
                    else
                    {
                        dgvSociosNegocios.DataSource = socioNegocioView.ObtenerDesdeFiltros(it => it.SOCIO_NEGOCIO.ToUpper().Contains(txtSocioNegocio.Text.ToUpper()) );                        
                    }
                    
                    return;
                }else
                if (!String.IsNullOrEmpty(txtNumeroDocumento.Text))
                {
                    if (Constantes.TiposSociosNegocios.ADMINISTRADOR.Equals(TipoSocioNegocio))
                    {
                        dgvSociosNegocios.DataSource = socioNegocioView.ObtenerDesdeFiltros(it => it.NUMERO_DOCUMENTO.ToUpper().Contains(txtNumeroDocumento.Text.ToUpper()) && it.ES_ADMINISTRADOR.Equals(Constantes.Booleano.SI));
                    }
                    else if (Constantes.TiposSociosNegocios.INQUILINO.Equals(TipoSocioNegocio))
                    {
                        dgvSociosNegocios.DataSource = socioNegocioView.ObtenerDesdeFiltros(it => it.NUMERO_DOCUMENTO.ToUpper().Contains(txtNumeroDocumento.Text.ToUpper()) && it.ES_INQUILINO.Equals(Constantes.Booleano.SI));
                    }
                    else if (Constantes.TiposSociosNegocios.PROPIETARIO.Equals(TipoSocioNegocio))
                    {
                        dgvSociosNegocios.DataSource = socioNegocioView.ObtenerDesdeFiltros(it => it.NUMERO_DOCUMENTO.ToUpper().Contains(txtNumeroDocumento.Text.ToUpper()) && it.ES_PROPIETARIO.Equals(Constantes.Booleano.SI));
                    }
                    else if (Constantes.TiposSociosNegocios.PORTERO.Equals(TipoSocioNegocio))
                    {
                        dgvSociosNegocios.DataSource = socioNegocioView.ObtenerDesdeFiltros(it => it.NUMERO_DOCUMENTO.ToUpper().Contains(txtNumeroDocumento.Text.ToUpper()) && it.ES_PORTERO.Equals(Constantes.Booleano.SI));
                    }
                    /*
                    else if (Constantes.TiposSociosNegocios.VENDEDOR.Equals(TipoSocioNegocio))
                    {
                        dgvSociosNegocios.DataSource = socioNegocioView.ObtenerDesdeFiltros(it => it.NUMERO_DOCUMENTO.ToUpper().Contains(txtNumeroDocumento.Text.ToUpper()) && it.ES_VENDEDOR.Equals(Constantes.Booleano.SI));
                    }
                    */
                    else
                    {
                        dgvSociosNegocios.DataSource = socioNegocioView.ObtenerDesdeFiltros(it => it.NUMERO_DOCUMENTO.ToUpper().Contains(txtNumeroDocumento.Text.ToUpper()) );
                    }

                    return;
                    
                }
                else
                {
                    //dgvSociosNegocios.DataSource = socioNegocioView.ObtenerLista();
                    if (Constantes.TiposSociosNegocios.ADMINISTRADOR.Equals(TipoSocioNegocio))
                    {
                        dgvSociosNegocios.DataSource = socioNegocioView.ObtenerDesdeFiltros(it => it.ES_ADMINISTRADOR.Equals(Constantes.Booleano.SI));
                    }
                    else if (Constantes.TiposSociosNegocios.INQUILINO.Equals(TipoSocioNegocio))
                    {
                        dgvSociosNegocios.DataSource = socioNegocioView.ObtenerDesdeFiltros(it => it.ES_INQUILINO.Equals(Constantes.Booleano.SI));
                    }
                    else if (Constantes.TiposSociosNegocios.PROPIETARIO.Equals(TipoSocioNegocio))
                    {
                        dgvSociosNegocios.DataSource = socioNegocioView.ObtenerDesdeFiltros(it => it.ES_PROPIETARIO.Equals(Constantes.Booleano.SI));
                    }
                    else if (Constantes.TiposSociosNegocios.PORTERO.Equals(TipoSocioNegocio))
                    {
                        dgvSociosNegocios.DataSource = socioNegocioView.ObtenerDesdeFiltros(it => it.ES_PORTERO.Equals(Constantes.Booleano.SI));
                    }
                    else if (Constantes.TiposSociosNegocios.VENDEDOR.Equals(TipoSocioNegocio))
                    {
                        dgvSociosNegocios.DataSource = socioNegocioView.ObtenerDesdeFiltros(it => it.ES_VENDEDOR.Equals(Constantes.Booleano.SI));
                    }
                    else if (Constantes.TiposSociosNegocios.CLIENTE.Equals(TipoSocioNegocio))
                    {
                        dgvSociosNegocios.DataSource = socioNegocioView.ObtenerDesdeFiltros(it => it.ES_CLIENTE.Equals(Constantes.Booleano.SI));
                    }
                    return;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtSocioNegocio.Text = txtNumeroDocumento.Text = String.Empty;
            dgvSociosNegocios.DataSource = null;
            dgvSociosNegocios.Rows.Clear();
            txtSocioNegocio.Focus();
        }

        private void dgvSociosNegocios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }

        private void dgvSociosNegocios_MouseClick(object sender, MouseEventArgs e)
        {
            dgvSociosNegocios_CellContentClick(sender, null);
        }

        private void FrmBusquedaSociosNegocios_Shown(object sender, EventArgs e)
        {
            txtSocioNegocio.Focus();
        }

        private void txtSocioNegocio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)13))
            {
                Buscar();
            }
        }

        protected override void Buscar()
        {
            btnBuscar_Click(null, null);
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
