using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.IngresosEgresos;
using Inmobiliaria.Modelo.Dao.Mantenimiento;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Presentacion.EntidadesInmobiliarias.Buscadores;
using Inmobiliaria.Presentacion.Gastos.Gastos;
using Inmobiliaria.Presentacion.Inicio;
using Inmobiliaria.Presentacion.Mantenimiento.Buscadores;
using Inmobiliaria.Utilidades.Controles;
using ItemsIngresosEgresosDao = Inmobiliaria.Modelo.Dao.Gastos.ItemsIngresosEgresosDao;

namespace Inmobiliaria.Presentacion.Gastos.Buscadores
{
    public partial class FrmBusquedaIngresosEgresos : Genericos.FrmBuscadorGenerico
    {
        public string Tipo { get; set; }
        
        public FrmBusquedaIngresosEgresos(Principal frmPrincipal,String tipo):base(frmPrincipal)
        {
            InitializeComponent();
            Tipo = tipo;
            CargarDatos();
            ConfiguracionesGrid(dgvItemIngresoEgreso);            
            
        }

        public FrmBusquedaIngresosEgresos()
        {
            InitializeComponent();
        }
        async void CargarDatos()
        {
            await CargarTiposImputaciones();
            await CargarItemsIngresosEgresos();

            if (FrmPrincipal.UsuarioLogueado.PERFIL.Equals(Constantes.TiposPerfiles.ADMINISTRADOR))
            {
                tsbtnEliminar.Visible = true;
            }
        }

        async Task CargarItemsIngresosEgresos()
        {
            using (ItemsIngresosEgresosDao itemsIngresosEgresosDao = new ItemsIngresosEgresosDao())
            {
                cbTipoItem.DataSource = itemsIngresosEgresosDao.ObtenerDesdeFiltros(i => i.TIPO_ITEM.Equals(Tipo));
            }
            ControlesUtilidades.InicializarComboBox(cbTipoItem);
        }

        async Task CargarTiposImputaciones()
        {
            using (DominiosDao dominiosDao = new DominiosDao())
            {
                cbTipoImputacion.DataSource =
                    dominiosDao.ObtenerDesdeFiltros(d => d.DOMINIO.Equals(Constantes.Dominios.TIPO_IMPUTACION));
                ControlesUtilidades.InicializarComboBox(cbTipoImputacion); 
            }
        }

        private void cbTipoImputacion_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbTipoImputacion.SelectedValue != null)
            {
                String tipoImputacion = cbTipoImputacion.SelectedValue.ToString();
                if (Constantes.TiposImputaciones.ENTIDAD_INMOBILIARIA.Equals(tipoImputacion))
                {
                    lblEntidadPropiedadSocionegocio.Text = "Edificios/Loteamientos";
                }
                else if (Constantes.TiposImputaciones.PROPIEDADES.Equals(tipoImputacion))
                {
                    lblEntidadPropiedadSocionegocio.Text = "Departamentos/Casas/Dúplex/Lotes";
                }
                else if (Constantes.TiposImputaciones.INQUILINOS.Equals(tipoImputacion))
                {
                    lblEntidadPropiedadSocionegocio.Text = "Clientes";
                }
                else if (Constantes.TiposImputaciones.PROPIETARIOS.Equals(tipoImputacion))
                {
                    lblEntidadPropiedadSocionegocio.Text = "Propietarios";
                }
                else if (Constantes.TiposImputaciones.ADMINISTRADOR.Equals(tipoImputacion))
                {
                    lblEntidadPropiedadSocionegocio.Text = "Administradores";
                }
                else if (Constantes.TiposImputaciones.VENDEDOR.Equals(tipoImputacion))
                {
                    lblEntidadPropiedadSocionegocio.Text = "Vendedores";
                }
            }
        }

        private void FrmBusquedaIngresosEgresos_Load(object sender, EventArgs e)
        {
            lblTitulo.Visible = false;
            if (Constantes.TiposIngresosEgresos.INGRESO.Equals(Tipo))
            {
                lblItemIngresoEgreso.Text = "Items ingresos";
                lblBusqueda.Text = "Búsqueda de ingresos";
            }
            else
            {
                lblItemIngresoEgreso.Text = "Items egresos";
                lblBusqueda.Text = "Búsqueda de egresos";
            }
            
        }

        private void FrmBusquedaIngresosEgresos_Shown(object sender, EventArgs e)
        {
            cbTipoImputacion.Focus();
            dgvItemIngresoEgreso.Columns["mONTODataGridViewTextBoxColumn"].DefaultCellStyle.Format = "N0";
            dgvItemIngresoEgreso.Columns["sALDODataGridViewTextBoxColumn"].DefaultCellStyle.Format = "N0";
        }

        private void btnBuscadorEntidadPropiedad_Click(object sender, EventArgs e)
        {
            if (cbTipoImputacion.SelectedValue != null)
            {
                String tipoImputacion = cbTipoImputacion.SelectedValue.ToString();
                if (Constantes.TiposImputaciones.ENTIDAD_INMOBILIARIA.Equals(tipoImputacion))
                {
                    FrmBuscadorEntidadesInmobiliarias frmBuscadorEntidadesInmobiliarias = new FrmBuscadorEntidadesInmobiliarias();
                    if (DialogResult.OK.Equals(frmBuscadorEntidadesInmobiliarias.ShowDialog()))
                    {
                        txtEntidadPropiedad.Text = frmBuscadorEntidadesInmobiliarias.Entity.NOMBRE;
                        txtEntidadPropiedad.Tag = frmBuscadorEntidadesInmobiliarias.Entity.ENTIDAD_INMOBILIARIA_ID;
                        frmBuscadorEntidadesInmobiliarias.Close();
                        
                    }
                }
                else if (Constantes.TiposImputaciones.PROPIEDADES.Equals(tipoImputacion))
                {
                    FrmBuscadorPropiedad buscadorPropiedad = new FrmBuscadorPropiedad();
                    if (DialogResult.OK.Equals(buscadorPropiedad.ShowDialog()))
                    {
                        txtEntidadPropiedad.Text = buscadorPropiedad.Entity.NOMBRE;
                        txtEntidadPropiedad.Tag = buscadorPropiedad.Entity.PROPIEDAD_ID;
                        buscadorPropiedad.Close();
                    }
                }
                else if (Constantes.TiposImputaciones.INQUILINOS.Equals(tipoImputacion))
                {
                    FrmBuscadorSociosNegocios frmBusquedaSociosNegocios = new FrmBuscadorSociosNegocios(FrmPrincipal,Constantes.TiposSociosNegocios.INQUILINO);
                    if (DialogResult.OK.Equals(frmBusquedaSociosNegocios.ShowDialog()))
                    {
                        txtEntidadPropiedad.Text = frmBusquedaSociosNegocios.Entity.SOCIO_NEGOCIO;
                        txtEntidadPropiedad.Tag = frmBusquedaSociosNegocios.Entity.SOCIO_NEGOCIO_ID;
                        frmBusquedaSociosNegocios.Close();
                    }
                }
                else if (Constantes.TiposImputaciones.PROPIETARIOS.Equals(tipoImputacion))
                {
                    FrmBuscadorSociosNegocios frmBusquedaSociosNegocios = new FrmBuscadorSociosNegocios(FrmPrincipal, Constantes.TiposSociosNegocios.PROPIETARIO);
                    if (DialogResult.OK.Equals(frmBusquedaSociosNegocios.ShowDialog()))
                    {
                        txtEntidadPropiedad.Text = frmBusquedaSociosNegocios.Entity.SOCIO_NEGOCIO;
                        txtEntidadPropiedad.Tag = frmBusquedaSociosNegocios.Entity.SOCIO_NEGOCIO_ID;
                        frmBusquedaSociosNegocios.Close();
                    }
                }
                else if (Constantes.TiposImputaciones.ADMINISTRADOR.Equals(tipoImputacion))
                {
                    FrmBuscadorSociosNegocios frmBusquedaSociosNegocios = new FrmBuscadorSociosNegocios(FrmPrincipal, Constantes.TiposSociosNegocios.ADMINISTRADOR);
                    if (DialogResult.OK.Equals(frmBusquedaSociosNegocios.ShowDialog()))
                    {
                        txtEntidadPropiedad.Text = frmBusquedaSociosNegocios.Entity.SOCIO_NEGOCIO;
                        txtEntidadPropiedad.Tag = frmBusquedaSociosNegocios.Entity.SOCIO_NEGOCIO_ID;
                        frmBusquedaSociosNegocios.Close();
                    }
                }
                else if (Constantes.TiposImputaciones.VENDEDOR.Equals(tipoImputacion))
                {
                    FrmBuscadorSociosNegocios frmBusquedaSociosNegocios = new FrmBuscadorSociosNegocios(FrmPrincipal, Constantes.TiposSociosNegocios.VENDEDOR);
                    if (DialogResult.OK.Equals(frmBusquedaSociosNegocios.ShowDialog()))
                    {
                        txtEntidadPropiedad.Text = frmBusquedaSociosNegocios.Entity.SOCIO_NEGOCIO;
                        txtEntidadPropiedad.Tag = frmBusquedaSociosNegocios.Entity.SOCIO_NEGOCIO_ID;
                        frmBusquedaSociosNegocios.Close();
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Int64 entidadPropiedadId = 0;
            Int64 tipoItemId = 0;
            String tipoImputacion = String.Empty;
            int cantidadLineas = 0;


            if (txtEntidadPropiedad.Tag != null)
            {
                entidadPropiedadId = Int64.Parse(txtEntidadPropiedad.Tag.ToString());

            }
                
            if (cbTipoItem.SelectedValue != null)
            {
                tipoItemId = Int64.Parse(cbTipoItem.SelectedValue.ToString());
            }

            if (cbTipoImputacion.SelectedValue != null)
            {
                tipoImputacion = cbTipoImputacion.SelectedValue.ToString();
            }
            using (BusquedaIngresosEgresosViewDao ingresosEgresosViewDao = new BusquedaIngresosEgresosViewDao())
            {
                        
                if (Constantes.TiposImputaciones.ENTIDAD_INMOBILIARIA.Equals(tipoImputacion))
                {
                    dgvItemIngresoEgreso.DataSource = ingresosEgresosViewDao.ObtenerDesdeFiltros(ie =>
                                ie.TIPO.Equals(Tipo) && (ie.ENTIDAD_INMOBILIARIA_ID == entidadPropiedadId || entidadPropiedadId == 0)
                                && (tipoItemId == ie.ITEM_INGRESO_EGRESO_ID || tipoItemId == 0)
                                && (ie.TIPO_IMPUTACION.Equals(tipoImputacion)) 
                                ).OrderBy(ie=>ie.ENTIDAD_INMOBILIARIA).ThenBy(ie=>ie.PROPIEDAD).ThenByDescending(ie=>ie.FECHA).ToList();
                }
                else if (Constantes.TiposImputaciones.PROPIEDADES.Equals(tipoImputacion))
                {
                    dgvItemIngresoEgreso.DataSource = ingresosEgresosViewDao.ObtenerDesdeFiltros(ie =>
                                ie.TIPO.Equals(Tipo) && (ie.PROPIEDAD_ID == entidadPropiedadId || entidadPropiedadId == 0)
                                && (tipoItemId == ie.ITEM_INGRESO_EGRESO_ID || tipoItemId == 0)
                                && (ie.TIPO_IMPUTACION.Equals(tipoImputacion)) 
                                ).OrderBy(ie => ie.ENTIDAD_INMOBILIARIA).ThenBy(ie => ie.PROPIEDAD).ThenByDescending(ie => ie.FECHA).ToList();
                }
                else if (Constantes.TiposImputaciones.ADMINISTRADOR.Equals(tipoImputacion) || Constantes.TiposImputaciones.INQUILINOS.Equals(tipoImputacion)
                    || Constantes.TiposImputaciones.PROPIETARIOS.Equals(tipoImputacion) || Constantes.TiposImputaciones.VENDEDOR.Equals(tipoImputacion))
                {
                            dgvItemIngresoEgreso.DataSource = ingresosEgresosViewDao.ObtenerDesdeFiltros(ie =>
                                ie.TIPO.Equals(Tipo) && (ie.SOCIO_NEGOCIO_ID == entidadPropiedadId || entidadPropiedadId == 0)
                                && (tipoItemId == ie.ITEM_INGRESO_EGRESO_ID || tipoItemId == 0)
                                && (ie.TIPO_IMPUTACION.Equals(tipoImputacion)) 
                                ).OrderBy(ie => ie.ENTIDAD_INMOBILIARIA).ThenBy(ie => ie.PROPIEDAD).ThenByDescending(ie => ie.FECHA).ToList();
                }
                else if (Constantes.TiposIngresosEgresos.INGRESO.Equals(Tipo) && tipoItemId != 0)
                {
                    dgvItemIngresoEgreso.DataSource = ingresosEgresosViewDao.ObtenerDesdeFiltros(ie => ie.ITEM_INGRESO_EGRESO_ID == tipoItemId).OrderBy(ie => ie.ENTIDAD_INMOBILIARIA).ThenBy(ie => ie.PROPIEDAD).ThenByDescending(ie => ie.FECHA).ToList();
                }
                else if (Constantes.TiposIngresosEgresos.EGRESO.Equals(Tipo) && tipoItemId != 0)
                {
                    dgvItemIngresoEgreso.DataSource = ingresosEgresosViewDao.ObtenerDesdeFiltros(ie => ie.ITEM_INGRESO_EGRESO_ID == tipoItemId).OrderBy(ie => ie.ENTIDAD_INMOBILIARIA).ThenBy(ie => ie.PROPIEDAD).ThenByDescending(ie => ie.FECHA).ToList();
                }
                else if (Constantes.TiposIngresosEgresos.DESCUENTO.Equals(Tipo) && tipoItemId != 0)
                {
                    dgvItemIngresoEgreso.DataSource = ingresosEgresosViewDao.ObtenerDesdeFiltros(ie => ie.ITEM_INGRESO_EGRESO_ID == tipoItemId).OrderBy(ie => ie.ENTIDAD_INMOBILIARIA).ThenBy(ie => ie.PROPIEDAD).ThenByDescending(ie => ie.FECHA).ToList();
                }
                else
                {
                        dgvItemIngresoEgreso.DataSource = ingresosEgresosViewDao.ObtenerDesdeFiltros(ie =>
                                ie.TIPO.Equals(Tipo)).OrderBy(ie => ie.ENTIDAD_INMOBILIARIA).ThenBy(ie => ie.PROPIEDAD).ThenByDescending(ie => ie.FECHA).ToList();
                }
                //cantidadLineas = dgvItemIngresoEgreso.RowCount;
                //lbRegistrosRecuperados.Text = lbRegistrosRecuperados.Text + " " + cantidadLineas.ToString();
            }                                                                  
        }                                
        protected override void Nuevo()
        {
            FrmIngresosEgresos frmIngresosEgresos = new FrmIngresosEgresos(FrmPrincipal,Constantes.Operaciones.NUEVO,Tipo);
            frmIngresosEgresos.Show();
        }
        protected override void Eliminar()
        {
            //base.Eliminar();
            
            if (dgvItemIngresoEgreso.CurrentRow != null)
            {
                if (PysistemasMensajes.AskConfirmation("Esta seguro que desea borrar el documento?"))
                {
                    Int64 ingresoEgresoId = Int64.Parse(dgvItemIngresoEgreso.CurrentRow.Cells[0].Value.ToString());

                    using (IngresosEgresosDao ingresosEgresosDao = new IngresosEgresosDao())
                    {
                        INGRESOS_EGRESOS entidad = ingresosEgresosDao.ObtenerDesdePk(ingresoEgresoId);
                        ingresosEgresosDao.Remover(entidad);
                        ingresosEgresosDao.Guardar();
                    }
                }
                btnBuscar_Click(null, null);
            }
            /*
            else
            {
                PysistemasMensajes.ShowInfo("No se ha seleccionado ningun documento.");
            }
            */
        
        }
        protected override void Editar()
        {
            if (dgvItemIngresoEgreso.CurrentRow != null)
            {
                FrmIngresosEgresos frmIngresosEgresos = new FrmIngresosEgresos(FrmPrincipal, Constantes.Operaciones.EDITAR, Tipo);
                Int64 ingresoEgresoId = Int64.Parse(dgvItemIngresoEgreso.CurrentRow.Cells[0].Value.ToString());
                frmIngresosEgresos.Entity.INGRESO_EGRESO_ID = ingresoEgresoId;

                if (DialogResult.OK.Equals(frmIngresosEgresos.ShowDialog(this)))
                {

                    PysistemasMensajes.ShowInfo("Los datos han sido guardados con éxito");
                }
                //btnCancelar_Click(null, null);

                //frmIngresosEgresos.Show();
            }
            
        }

        private void dgvItemIngresoEgreso_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Editar();            
        }

        private void dgvItemIngresoEgreso_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Editar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtEntidadPropiedad.Text = String.Empty;
            ControlesUtilidades.InicializarComboBox(cbTipoImputacion);
            ControlesUtilidades.InicializarComboBox(cbTipoItem);
            txtEntidadPropiedad.Tag = null;
            dgvItemIngresoEgreso.DataSource = null;
            dgvItemIngresoEgreso.Rows.Clear();
            cbTipoImputacion.Focus();

        }

        private void dgvItemIngresoEgreso_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvItemIngresoEgreso.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
