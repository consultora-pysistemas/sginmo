using Inmobiliaria.Presentacion.Inicio;
using System;
using System.Windows.Forms;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Modelo.Dao.Mantenimiento;
using Inmobiliaria.Presentacion.Genericos;
using System.Threading;
using System.IO;
using System.Drawing;
using Inmobiliaria.Modelo;
using System.Threading.Tasks;
using Inmobiliaria.Presentacion.EntidadesInmobiliarias.Buscadores;
using Inmobiliaria.Utilidades.Controles;
using Inmobiliaria.Presentacion.Mantenimiento.Buscadores;
using System.Collections.Generic;
using Inmobiliaria.Modelo.Dao.EntidadesInmobiliarias;
using System.Linq;
using Inmobiliaria.Presentacion.Mantenimiento.SociosNegocios;
using Inmobiliaria.Presentacion.Mantenimiento.UbicacionGeografica;
using Inmobiliaria.Services.EntidadesInmobiliarias;
using Inmobiliaria.Presentacion.Mantenimiento.UbicacionGeografica.Buscadores;

namespace Inmobiliaria.Presentacion.EntidadesInmobiliarias.Entidades
{
    public partial class FrmEntidadesInmobiliarias : FrmMaestro
    {
        public string Operacion { get; set; }
        private String _fileLocation = String.Empty;
        private int _maxImageSize = 2097152;
        public ENTIDADES_INMOBILIARIAS Entity { get; set; }
        public SOCIOS_NEGOCIOS_VIEW Propietario { get; set; }
        public FrmEntidadesInmobiliarias(Principal principal,String operacion):base(principal)
        {
           
            InitializeComponent();
            
            using (DialogoEspera dialogoEspera = new DialogoEspera())
            {
                dialogoEspera.label1.Text = "Favor aguarde mientras se cargan los datos";
                //AndroNETInicio inicio = new AndroNETInicio();
                dialogoEspera.ActionToExecute = EsperaCargaDatos;
                if (DialogResult.OK.Equals(dialogoEspera.ShowDialog()))
                {
                    txtNombre.Focus();
                }
            }
            
            Operacion = operacion;
            CargarDatos();
            Entity = new ENTIDADES_INMOBILIARIAS();
            Propietario = new SOCIOS_NEGOCIOS_VIEW();
            
            ConfiguracionesGrid(dgvPropietarios);
        }

        private void TxtNombre_LostFocus(object sender, EventArgs e)
        {
            if (cbTipoEntidades.SelectedValue != null && !String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                using (EntidadesInmobiliariasDao entidadesInmobiliariasDao = new EntidadesInmobiliariasDao())
                {
                    String tipo = cbTipoEntidades.SelectedValue.ToString();
                    IList<ENTIDADES_INMOBILIARIAS> lista = entidadesInmobiliariasDao.ObtenerDesdeFiltros(ei =>
                        ei.NOMBRE.ToUpper().Equals(txtNombre.Text.ToUpper()) && ei.TIPO.Equals(tipo));
                    if (lista.Count > 0)
                    {
                        PysistemasMensajes.ShowAlert("Ya existe un " + tipo + " con el nombre " + txtNombre.Text);
                        txtNombre.Focus();
                        return;
                    }
                }
            }
        }

        private void EntidadesInmobiliarias_Shown(object sender, EventArgs e)
        {
            
            txtNombre.Focus();
        }

        private void EntidadesInmobiliarias_Load(object sender, EventArgs e)
        {

            AddTooltips();
            tcEntidadesInmobiliarias.TabPages.Remove(tpFotos);
            if (Constantes.Operaciones.NUEVO.Equals(Operacion))
            {
                lblTitulo.Text = "Crear Edificio/Loteamiento";
                lblEstado.ForeColor = Color.Green;
                lblEstado.Text = "VIGENTE";

            }
            else
            {
                lblTitulo.Text = "Modificar Edificio/Loteamiento";
                CargarPropietarios();
                txtNombre.Text = Entity.NOMBRE;
                cbTipoEntidades.SelectedValue = Entity.TIPO;
                txtNumeroFinca.Text = Entity.NUMERO_FINCA;
                txtCuentaCatastral.Text = Entity.CUENTA_CATASTRAL;
                txtCantidadUnidades.Text = Entity.CANTIDAD_UNIDADES.ToString();
                txtAnoContruccion.Text = Entity.ANO_CONSTRUCCION.ToString();
                txtMedidasLote.Text = Entity.MEDIDAS_LOTE;
                txtM2Contruccion.Text = Entity.M2_CONSTRUCCION.ToString();
                txtCaracteristicas.Text = Entity.CARACTERISTICA;
                cbPaís.SelectedValue = Entity.PAIS_ID;
                cbDepartamento.SelectedValue = Entity.DEPARTAMENTO_ID;
                cbCiudad.SelectedValue = Entity.CIUDAD_ID;
                cbBarrios.SelectedValue = Entity.BARRIO_ID;
                txtDireccion.Text = Entity.DIRECCION;
                cbNaturaleza.SelectedItem = Entity.NATURALEZA;
                if (Constantes.EstadosUnidadesInmobiliarias.LIBRE.Equals(Entity.ESTADO) || Constantes.EstadosUnidadesInmobiliarias.VIGENTE.Equals(Entity.ESTADO))
                {
                    lblEstado.ForeColor = Color.Green;
                }
                else
                {
                    lblEstado.ForeColor = Color.Red;
                }
                lblEstado.Text = Entity.ESTADO;

            }
        }

        private void CargarPropietarios()
        {
            using (PropietariosEntidadesInmobiliariasDao propietariosEntidadesDao = new PropietariosEntidadesInmobiliariasDao()) 
            {
                int entidadInmobiliariaId = Int32.Parse(Entity.ENTIDAD_INMOBILIARIA_ID.ToString());

                IList<PROPIETARIOS_ENT_INMOB> listaPropietarios = propietariosEntidadesDao.ObtenerDesdeFiltros(p => p.ENTIDAD_INMOBILIARIA_ID == entidadInmobiliariaId && p.PROPIEDAD_ID.HasValue == false);
                List<SOCIOS_NEGOCIOS_VIEW> listaSociosNegociosPropietarios = new List<SOCIOS_NEGOCIOS_VIEW>();
                if (listaPropietarios.Count > 0)
                {
                     listaSociosNegociosPropietarios = new List<SOCIOS_NEGOCIOS_VIEW>();
                    using(BusquedaSociosNegociosViewDao busquedaSocioNegocioDao = new BusquedaSociosNegociosViewDao())
                    {
                        foreach(PROPIETARIOS_ENT_INMOB propEntidad in listaPropietarios)
                        {
                            int propietarioID = int.Parse(propEntidad.PROPIETARIO_ID.ToString());
                            IList<SOCIOS_NEGOCIOS_VIEW> socio = busquedaSocioNegocioDao.ObtenerDesdeFiltros(p=>p.SOCIO_NEGOCIO_ID == propietarioID);
                            if (socio != null)
                            {
                                listaSociosNegociosPropietarios.Add(socio[0]);
                            }
                        }
                    }
                }
                dgvPropietarios.DataSource = listaSociosNegociosPropietarios;
            }
        }

        private void AddTooltips()
        {
            ControlesUtilidades.addTooltips(txtNombre,"Nombre del Edificio/Loteamiento/Salones comerciales/Complejos/Barrios cerrados");
            ControlesUtilidades.addTooltips(cbTipoEntidades, "Edificio/Loteamiento/Salones comerciales/Complejos/Barrios cerrados");
            ControlesUtilidades.addTooltips(txtCuentaCatastral, "Identificación física del Edificio/Loteamiento/Salones");

        }

        private void EsperaCargaDatos()
        {
            Thread.Sleep(500);
        }

        async void CargarDatos()
        {
            await CargarPaises();
           
           
           
            await CargarTiposEntidadesInmobiliarias();
            
        }

        async Task CargarTiposEntidadesInmobiliarias()
        {
           
                 using (DominiosDao dominiosDao = new DominiosDao())
                 {
                     cbTipoEntidades.DataSource = dominiosDao.ObtenerDesdeFiltros(d => d.DOMINIO.Equals(Constantes.Dominios.TIPOS_ENTIDADES_INMOBILIARIAS));
                ControlesUtilidades.InicializarComboBox(cbTipoEntidades);
                 }
                  
            return ;
        }

       

        async Task<int> CargarDepartamentosPaises()
        {
            using(BusquedaDepartamentosPaisesViewDao busquedaDepartamentosPaisesView = new BusquedaDepartamentosPaisesViewDao())
            {
                if(cbPaís.SelectedValue != null)
                {
                    Int64 paisId = Int64.Parse(cbPaís.SelectedValue.ToString());
                    cbDepartamento.DataSource = busquedaDepartamentosPaisesView.ObtenerDesdeFiltros(d => d.PAIS_ID == paisId);
                    ControlesUtilidades.InicializarComboBox(cbDepartamento);
                }
            }
            return 1;
        }

        async Task CargarPaises()
        {
            using(PaisDao paisDao = new PaisDao())
            {
                cbPaís.DataSource = paisDao.ObtenerLista();

            }
            await CargarDepartamentosPaises();
            return ;
        }
        private void pnlDatosAnalisis_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCantidadUnidades_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlesUtilidades.camposNumericos(e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnClose_Click(sender, e);
        }

        private  void cbDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbDepartamento.SelectedValue != null)
            {
                Int64 departamentoId = Int64.Parse(cbDepartamento.SelectedValue.ToString());
                CargarCiudadesDepartamentosAsync(departamentoId);
            }
        }
        async void CargarCiudadesDepartamentosAsync(Int64 departamentoId)
        {
            await CargarCiudadesDepartamentos(departamentoId);
        }
        async Task CargarCiudadesDepartamentos(Int64 departamentoId)
        {
            using (BusquedaCiudadesDepartamentosViewDao busquedaCiudadesDepartamentosView = new BusquedaCiudadesDepartamentosViewDao())
            {
                cbCiudad.DataSource = busquedaCiudadesDepartamentosView.ObtenerDesdeFiltros(c => c.DEPARTAMENTO_ID == departamentoId);
                ControlesUtilidades.InicializarComboBox(cbCiudad);
            }
            cbCiudad.Focus();
            return ;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ControlesUtilidades.InicializarComboBox(cbDepartamento);
            ControlesUtilidades.InicializarComboBox(cbCiudad);
            ControlesUtilidades.InicializarComboBox(cbBarrios);
            cbDepartamento.Focus();
        }

        private void cbCiudad_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbCiudad.SelectedValue != null)
            {
                Int64 ciudadId = Int64.Parse(cbCiudad.SelectedValue.ToString());
                CargarBarriosAsync(ciudadId);
            }
        }

        async void CargarBarriosAsync(Int64 ciudadId)
        {
            await CargarBarriosCiudades(ciudadId);
        }

        async Task CargarBarriosCiudades(long ciudadId)
        {
            using (BusquedaBarriosCiudadesDao busquedaBarriosCiudadesDao = new BusquedaBarriosCiudadesDao())
            {

                cbBarrios.DataSource = busquedaBarriosCiudadesDao.ObtenerDesdeFiltros(b => b.CIUDAD_ID == ciudadId);
                ControlesUtilidades.InicializarComboBox(cbBarrios);
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ControlesUtilidades.InicializarComboBox(cbTipoEntidades);
        }

        private void lnkElegirImagen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ofdBuscarImagen.ShowDialog();
            _fileLocation = ofdBuscarImagen.FileName;
            if (!string.IsNullOrEmpty(_fileLocation))
            {
                Cursor.Current = Cursors.WaitCursor;
                if (File.Exists(_fileLocation))
                {
                    //Retreave image from file and binary it to Object image
                    using (FileStream stream = File.Open(_fileLocation, FileMode.Open))
                    {
                        var br = new BinaryReader(stream);
                        byte[] data = br.ReadBytes(_maxImageSize);
                        var ms = new MemoryStream(data);
                        var returnImage = Image.FromStream(ms);
                        byte[] imagen = data;
                        imageList1.ImageSize = new Size(128,128 );


                        ListViewItem item = new ListViewItem();
                        item.ImageIndex = imageList1.Images.Count;
                        listView1.Items.Add(item);
                        listView1.View = View.LargeIcon;
                        imageList1.Images.Add(returnImage);
                        listView1.LargeImageList = imageList1;
                        

                    }
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (Keys.F3.Equals(keyData))
            {
                FrmBusquedaEntidadesInmobiliarias frmBusquedaEntidadesInmobiliarias = new FrmBusquedaEntidadesInmobiliarias(FrmPrincipal);
                if (DialogResult.OK.Equals(frmBusquedaEntidadesInmobiliarias.ShowDialog())){

                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void txtCantidadUnidades_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ControlesUtilidades.camposNumericos(e);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPropietario.Text = String.Empty;
            txtPropietario.Tag = null;
        }

        private void btnBuscadorSocioNegocio_Click(object sender, EventArgs e)
        {
            FrmBuscadorSociosNegocios frmBuscadorSociosNegocios = new FrmBuscadorSociosNegocios(FrmPrincipal, Constantes.TiposSociosNegocios.PROPIETARIO);
            if (DialogResult.OK.Equals(frmBuscadorSociosNegocios.ShowDialog()))
            {
                Propietario = frmBuscadorSociosNegocios.Entity;
                frmBuscadorSociosNegocios.Close();
                txtPropietario.Tag = Propietario.SOCIO_NEGOCIO_ID;
                txtPropietario.Text = Propietario.SOCIO_NEGOCIO;
                tsbtnAgregar_Click(sender,e);
            }
        }

        private void tsbtnAgregar_Click(object sender, EventArgs e)
        {
            
           IList<SOCIOS_NEGOCIOS_VIEW> lista = dgvPropietarios.DataSource as IList<SOCIOS_NEGOCIOS_VIEW>;
            if(lista == null)
            {
                lista = new  List<SOCIOS_NEGOCIOS_VIEW>();
            }
            SOCIOS_NEGOCIOS_VIEW socioNegocio = Propietario;
            lista.Add(socioNegocio);
            
            dgvPropietarios.DataSource = null;
            dgvPropietarios.Rows.Clear();
            dgvPropietarios.DataSource = lista;
            txtPropietario.Text = String.Empty;
            txtPropietario.Tag = null;

        }

        private void tcEntidadesInmobiliarias_Selected(object sender, TabControlEventArgs e)
        {
            if (!tpDatos.Name.Equals(tcEntidadesInmobiliarias.SelectedTab.Name))
            {
                if (!VerificarDatosObligatorios())
                {
                    PysistemasMensajes.ShowInfo("Para cargar datos de propietarios son requeridos datos del edificio/loteamiento");
                    tcEntidadesInmobiliarias.SelectedTab = tpDatos;
                    return;
                }
            }
        }

        private bool VerificarDatosObligatorios()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
                return false;
            if (cbTipoEntidades.SelectedValue == null)
                return false;
            if (cbPaís.SelectedValue == null && cbDepartamento.SelectedValue ==null && cbCiudad.SelectedValue ==null && cbBarrios.SelectedValue == null)
                return false;
            return true;
        }

        private void tsbtnEliminar_Click(object sender, EventArgs e)
        {
            if(dgvPropietarios.CurrentRow != null){
                Int64 socioNegocioId = Int64.Parse(dgvPropietarios.CurrentRow.Cells["sOCIONEGOCIOIDDataGridViewTextBoxColumn"].Value.ToString());
                if (Constantes.Operaciones.NUEVO.Equals(Operacion))
                {
                    using(BusquedaSociosNegociosViewDao busquedaSociosNegociosDao = new BusquedaSociosNegociosViewDao())
                    {
                        IList<SOCIOS_NEGOCIOS_VIEW> listaPropietarioEliminar = busquedaSociosNegociosDao.ObtenerDesdeFiltros(s => s.SOCIO_NEGOCIO_ID.Equals(socioNegocioId));
                        IList<SOCIOS_NEGOCIOS_VIEW> lista = dgvPropietarios.DataSource as IList<SOCIOS_NEGOCIOS_VIEW>;
                        
                        SOCIOS_NEGOCIOS_VIEW itemRemove = listaPropietarioEliminar.FirstOrDefault(u => u.SOCIO_NEGOCIO_ID == socioNegocioId);
                        lista.RemoveAt(dgvPropietarios.CurrentRow.Index);
                        dgvPropietarios.DataSource = null;
                        dgvPropietarios.Rows.Clear();
                        dgvPropietarios.DataSource = lista;
                    }
                    
                }else
                {
                    using(PropietariosEntidadesInmobiliariasDao propietariosEntidadesInmobiliariasDao  = new PropietariosEntidadesInmobiliariasDao())
                    {
                        
                        IList<PROPIETARIOS_ENT_INMOB> lista = propietariosEntidadesInmobiliariasDao.ObtenerDesdeFiltros(p=>p.ENTIDAD_INMOBILIARIA_ID == Entity.ENTIDAD_INMOBILIARIA_ID 
                        && p.PROPIETARIO_ID == socioNegocioId);
                        propietariosEntidadesInmobiliariasDao.Remover(lista[0]);
                        propietariosEntidadesInmobiliariasDao.Guardar();
                        CargarPropietarios();
                    }
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cbTipoEntidades.SelectedValue != null && !String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                using (EntidadesInmobiliariasDao entidadesInmobiliariasDao = new EntidadesInmobiliariasDao())
                {
                    String tipo = cbTipoEntidades.SelectedValue.ToString();
                    IList<ENTIDADES_INMOBILIARIAS> lista = entidadesInmobiliariasDao.ObtenerDesdeFiltros(ei =>
                        ei.NOMBRE.ToUpper().Equals(txtNombre.Text.ToUpper()) && ei.TIPO.Equals(tipo));
                    if (Constantes.Operaciones.NUEVO.Equals(Operacion))
                    {
                        if (lista.Count > 0)
                        {
                            PysistemasMensajes.ShowAlert("Ya existe un " + tipo + " con el nombre " + txtNombre.Text);
                            txtNombre.Focus();
                            return;
                        }
                    }
                }
            }
            if (String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                PysistemasMensajes.ShowAlert("Ël nombre del Edificio/Loteamiento es requerido");
                txtNombre.Focus();
                return;
            }

            if (cbTipoEntidades.SelectedValue == null)
            {
                PysistemasMensajes.ShowAlert("El dato de tipo de entidad de negocio Edicio o Loteamiento es requerido");
                cbTipoEntidades.Focus();
                return;

            }

            if (String.IsNullOrWhiteSpace(txtCantidadUnidades.Text) || txtCantidadUnidades.Text == "0")
            {
                PysistemasMensajes.ShowAlert("La cantidad de unidades es requerida");
                txtCantidadUnidades.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(txtNumeroFinca.Text))
            {
                PysistemasMensajes.ShowAlert("El número de finca o matrícula es requerido");
                txtNumeroFinca.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(txtCuentaCatastral.Text))
            {
                PysistemasMensajes.ShowAlert("El número de cuenta catastral o padrón es requerido");
                txtCuentaCatastral.Focus();
                return;
            }

            if (cbNaturaleza.SelectedItem == null)
            {
                PysistemasMensajes.ShowAlert("La naturaleza Alquiler/Venta es requerida para la entidad de negocio");
                cbNaturaleza.Focus();
                return;
            }

            if (cbPaís.SelectedValue == null)
            {
                PysistemasMensajes.ShowAlert("El país es requerido");
                cbPaís.Focus();
                return;
            }
            if (cbDepartamento.SelectedValue == null)
            {
                PysistemasMensajes.ShowAlert("El departamento es requerido");
                cbDepartamento.Focus();
                return;
            }
            if (cbCiudad.SelectedValue == null)
            {
                PysistemasMensajes.ShowAlert("La ciudad es requerida");
                cbCiudad.Focus();
                return;
            }
            if (cbBarrios.SelectedValue == null)
            {
                PysistemasMensajes.ShowAlert("El barrio es requerido");
                cbBarrios.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                PysistemasMensajes.ShowAlert("La dirección del Edificio/Loteamiento es requerido");
                txtDireccion.Focus();
                return;
            }
            EntidadesInmobiliariaService service = new EntidadesInmobiliariaService();
            List<SOCIOS_NEGOCIOS_VIEW> propietarios = dgvPropietarios.DataSource as List<SOCIOS_NEGOCIOS_VIEW>;
            if (propietarios == null)
                propietarios = new List<SOCIOS_NEGOCIOS_VIEW>();
            if (propietarios.Count == 0)
            {
                PysistemasMensajes.ShowAlert("Los datos del/los propietarios para el Edificio/Loteamiento son requeridos");
                tcEntidadesInmobiliarias.SelectedTab = tpPropietarios;
                txtPropietario.Focus();
                return;
            }
            Entity.NOMBRE = txtNombre.Text;
            Entity.TIPO = cbTipoEntidades.SelectedValue.ToString();
            Entity.CUENTA_CATASTRAL = txtCuentaCatastral.Text;
            Entity.CANTIDAD_UNIDADES = int.Parse(String.IsNullOrWhiteSpace(txtCantidadUnidades.Text)?"0": txtCantidadUnidades.Text);
            Entity.ANO_CONSTRUCCION = int.Parse(String.IsNullOrWhiteSpace(txtAnoContruccion.Text) ? "0" : txtAnoContruccion.Text);
            Entity.M2_CONSTRUCCION = int.Parse(String.IsNullOrWhiteSpace(txtM2Contruccion.Text) ? "0" : txtM2Contruccion.Text);
            Entity.MEDIDAS_LOTE = txtMedidasLote.Text;
            Entity.NUMERO_FINCA = txtNumeroFinca.Text;
            if(cbPaís.SelectedValue != null)
                Entity.PAIS_ID = Int64.Parse(cbPaís.SelectedValue.ToString());
            if(cbDepartamento.SelectedValue != null)
                Entity.DEPARTAMENTO_ID = Int64.Parse(cbDepartamento.SelectedValue.ToString());
            if(cbCiudad.SelectedValue != null)
                Entity.CIUDAD_ID = Int64.Parse(cbCiudad.SelectedValue.ToString());
            if(cbBarrios.SelectedValue != null)
                Entity.BARRIO_ID = Int64.Parse(cbBarrios.SelectedValue.ToString());
            Entity.CARACTERISTICA = txtCaracteristicas.Text;
            Entity.DIRECCION = txtDireccion.Text;
            if (Entity.ESTADO == null)
            {
                Entity.ESTADO = "VIGENTE";
            }
                
            else
            {
                Entity.ESTADO = lblEstado.Text;
            }
            Entity.NATURALEZA = cbNaturaleza.SelectedItem.ToString();
            Entity.EMPRESA_ID = FrmPrincipal.Empresa.EMPRESA_ID;
            if (service.Guardar(Operacion, Entity, propietarios, FrmPrincipal.UsuarioLogueado) != null)
            {
                PysistemasMensajes.ShowInfo("Los datos se han guardado con éxito");
                if (PysistemasMensajes.AskConfirmation("Desea seguir creando registros?"))
                {
                    LimpiarPantalla();
                    tcEntidadesInmobiliarias.SelectedTab = tpDatos;
                    Operacion = Constantes.Operaciones.NUEVO;
                    txtNombre.Focus();
                }
                else
                {
                    DialogResult = DialogResult.Abort;
                    Close();
                }
            }
            
        }

        protected override void LimpiarPantalla()
        {
            ControlesUtilidades.ClearComponents(groupBox1);
            ControlesUtilidades.ClearComponents(groupBox2);
            ControlesUtilidades.ClearComponents(groupBox3);
            dgvPropietarios.DataSource = null;
            dgvPropietarios.Rows.Clear();
            

        }

        private void btnAgregarCiudad_Click(object sender, EventArgs e)
        {
            FrmCiudades frmCiudades = new FrmCiudades(FrmPrincipal,Constantes.Operaciones.NUEVO);
            Int64 departamentoId = Int64.Parse(cbDepartamento.SelectedValue.ToString());
            frmCiudades.cbDepartamento.SelectedValue = departamentoId;

            //if (DialogResult.OK.Equals(frmCiudades.ShowDialog()))
            //{
            frmCiudades.ShowDialog();
            CargarCiudadesDepartamentosAsync(departamentoId);
            cbCiudad.SelectedValue = frmCiudades.Entity.CIUDAD_ID;
            //}
        }
        private void btnAgregarBarrio_Click(object sender, EventArgs e)
        {
            FrmBarrios frmBarrio = new FrmBarrios(FrmPrincipal, Constantes.Operaciones.NUEVO);
            Int64 departamentoId = Int64.Parse(cbDepartamento.SelectedValue.ToString());
            Int64 ciudadId = Int64.Parse(cbCiudad.SelectedValue.ToString());
            frmBarrio.cbDepartamento.SelectedValue = departamentoId;
            frmBarrio.cbCiudad.SelectedValue = ciudadId;
            //if (DialogResult.OK.Equals(frmBarrio.ShowDialog()))
            //{
            frmBarrio.ShowDialog();
            CargarBarriosCiudades(ciudadId);

            cbBarrios.SelectedValue = frmBarrio.Entity.BARRIO_ID;
            //}
        }
        private void cbTipoEntidades_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbTipoEntidades.SelectedValue != null && !String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                using (EntidadesInmobiliariasDao entidadesInmobiliariasDao = new EntidadesInmobiliariasDao())
                {
                    String tipo = cbTipoEntidades.SelectedValue.ToString();
                    IList<ENTIDADES_INMOBILIARIAS> lista = entidadesInmobiliariasDao.ObtenerDesdeFiltros(ei =>
                        ei.NOMBRE.ToUpper().Equals(txtNombre.Text.ToUpper()) && ei.TIPO.Equals(tipo));
                    if (Constantes.Operaciones.NUEVO.Equals(Operacion))
                    {
                        if (lista.Count > 0)
                        {
                            PysistemasMensajes.ShowAlert("Ya existe un " + tipo + " con el nombre " + txtNombre.Text);
                            txtNombre.Focus();
                            return;
                        }
                    }
                    
                }
            }
        }

        private void btnAgregarPropietario_Click(object sender, EventArgs e)
        {
            FrmSociosNegocios frmSociosNegocios = new FrmSociosNegocios(FrmPrincipal, Constantes.Operaciones.NUEVO, Constantes.TiposSociosNegocios.PROPIETARIO);
            frmSociosNegocios.Show(this);
        }

        private void btBuscarCiudad_Click(object sender, EventArgs e)
        {
            if (cbDepartamento.SelectedValue != null)
            {
                FrmBuscadorCiudadPorDepartamento frmBuscadorCiudadPorDepartamento = new FrmBuscadorCiudadPorDepartamento(Int64.Parse(cbDepartamento.SelectedValue.ToString()));
                frmBuscadorCiudadPorDepartamento.ShowDialog();
                cbCiudad.SelectedValue = frmBuscadorCiudadPorDepartamento.CiudadId;

            }
        }

        private void btBuscarBarrio_Click(object sender, EventArgs e)
        {
            if (cbCiudad.SelectedValue != null)
            {
                FrmBuscadorBarrioPorCiudad frmBuscadorBarrioPorCiudad = new FrmBuscadorBarrioPorCiudad(Int64.Parse(cbCiudad.SelectedValue.ToString()));
                frmBuscadorBarrioPorCiudad.ShowDialog();
                cbBarrios.SelectedValue = frmBuscadorBarrioPorCiudad.BarrioId;

            }
        }

        private void txtM2Contruccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlesUtilidades.camposNumericos(e);
        }
    }
}
