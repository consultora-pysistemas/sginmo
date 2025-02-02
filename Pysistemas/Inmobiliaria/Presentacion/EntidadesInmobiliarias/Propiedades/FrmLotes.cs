using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.EntidadesInmobiliarias;
using Inmobiliaria.Modelo.Dao.Mantenimiento;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Presentacion.Inicio;
using Inmobiliaria.Services.EntidadesInmobiliarias;
using Inmobiliaria.Utilidades.Controles;

namespace Inmobiliaria.Presentacion.EntidadesInmobiliarias.Propiedades
{
    public partial class FrmLotes : Inmobiliaria.Presentacion.Genericos.FrmMaestro
    {
        public string Operacion { get; set; }
        public PROPIEDADES Entity { get; set; }
        private String precioVenta { get; set; }
        private String precioAlquiler { get; set; }
        public FrmLotes(Principal frmPrincipal,String operacion):base(frmPrincipal)
        {
            InitializeComponent();
            Operacion = operacion;
            Entity = new PROPIEDADES();
            ConfiguracionesGrid(dgvPropietarios);
            CargarDatos();
            tcAnalisis.TabPages.Remove(tabPage1);

        }
        
        async void CargarDatos()
        {
            await CargarPaises();

            await CargarTiposPropiedades();
            await CargarEntidadesInmobiliarias();
            cbTipoPropiedad.SelectedValue = Constantes.TiposPropiedades.LOTE;
            CargarPorcentajeComisionVenta();

        }

        async Task CargarEntidadesInmobiliarias()
        {
            using (EntidadesInmobiliariasDao entidadesInmobiliariasDao = new EntidadesInmobiliariasDao())
            {
                cbUnidadInmobiliaria.DataSource = entidadesInmobiliariasDao.ObtenerDesdeFiltros(c => "LOTEAMIENTO".Equals(c.TIPO));
                ControlesUtilidades.InicializarComboBox(cbUnidadInmobiliaria);
                //cbUnidadInmobiliaria.SelectedIndex = -1;
            }
            

            return;
        }

        async Task CargarTiposPropiedades()
        {

            using (DominiosDao dominiosDao = new DominiosDao())
            {
                cbTipoPropiedad.DataSource = dominiosDao.ObtenerDesdeFiltros(d => d.DOMINIO.Equals(Constantes.Dominios.TIPOS_PROPIEDADES) && "LOTE".Equals(d.CODIGO_DOMINIO));
                ControlesUtilidades.InicializarComboBox(cbTipoPropiedad);
            }

            return;
        }
        private void CargarPorcentajeComisionVenta()
        {
            using (DominiosDao dominiosDao = new DominiosDao())
            {
                txtPorcentajeComision.Text = dominiosDao.ObtenerDesdeFiltros(d => d.DOMINIO.Equals(Constantes.Dominios.PORCENTAJE_COMISION_VENTA))[0].VALOR_DOMINIO;
                
            }
        }
        async Task CargarPaises()
        {
            using (PaisDao paisDao = new PaisDao())
            {
                cbPaís.DataSource = paisDao.ObtenerLista();

            }
            await CargarDepartamentosPaises();
            return;
        }
        async Task<int> CargarDepartamentosPaises()
        {
            using (BusquedaDepartamentosPaisesViewDao busquedaDepartamentosPaisesView = new BusquedaDepartamentosPaisesViewDao())
            {
                if (cbPaís.SelectedValue != null)
                {
                    Int64 paisId = Int64.Parse(cbPaís.SelectedValue.ToString());
                    cbDepartamentos.DataSource = busquedaDepartamentosPaisesView.ObtenerDesdeFiltros(d => d.PAIS_ID == paisId);
                    ControlesUtilidades.InicializarComboBox(cbDepartamentos);
                }
            }
            return 1;
        }
        private void cbDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbDepartamentos.SelectedValue != null)
            {
                Int64 departamentoId = Int64.Parse(cbDepartamentos.SelectedValue.ToString());
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
                cbCiudades.DataSource = busquedaCiudadesDepartamentosView.ObtenerDesdeFiltros(c => c.DEPARTAMENTO_ID == departamentoId);
                ControlesUtilidades.InicializarComboBox(cbCiudades);
            }
            //cbCiudades.Focus();
            return;
        }
        private void cbCiudad_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbCiudades.SelectedValue != null)
            {
                Int64 ciudadId = Int64.Parse(cbCiudades.SelectedValue.ToString());
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
            return;
        }

        private void CargarPropietarios()
        {


            using (PropietariosEntidadesInmobiliariasDao propietariosEntidadesDao = new PropietariosEntidadesInmobiliariasDao())
            {
                IList<PROPIETARIOS_ENT_INMOB> listaPropietarios = new List<PROPIETARIOS_ENT_INMOB>();
                listaPropietarios = propietariosEntidadesDao.ObtenerDesdeFiltros(p => p.PROPIEDAD_ID == Entity.PROPIEDAD_ID);
                List<SOCIOS_NEGOCIOS_VIEW> listaSociosNegociosPropietarios = new List<SOCIOS_NEGOCIOS_VIEW>();
                if (listaPropietarios.Count > 0)
                {
                    listaSociosNegociosPropietarios = new List<SOCIOS_NEGOCIOS_VIEW>();
                    using (BusquedaSociosNegociosViewDao busquedaSocioNegocioDao = new BusquedaSociosNegociosViewDao())
                    {
                        foreach (PROPIETARIOS_ENT_INMOB propEntidad in listaPropietarios)
                        {
                            int propietarioID = int.Parse(propEntidad.PROPIETARIO_ID.ToString());
                            IList<SOCIOS_NEGOCIOS_VIEW> socio = busquedaSocioNegocioDao.ObtenerDesdeFiltros(p => p.SOCIO_NEGOCIO_ID == propietarioID);
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

        private void FrmLotes_Load(object sender, EventArgs e)
        {
            if (Constantes.Operaciones.NUEVO.Equals(Operacion))
            {
                lblTitulo.Text = "Crear Lotes";
            }
            else
            {
                lblTitulo.Text = "Editar Lotes";
                if (Entity != null)
                {
                    txtNombre.Text = Entity.NUMERO_LOTE;
                    txtManzana.Text = Entity.NUMERO_MANZANA;
                    cbTipoPropiedad.SelectedValue = Entity.TIPO;
                    txtCuentaCatastral.Text = Entity.CUENTA_CATASTRAL;
                    txtNroFinca.Text = Entity.NUMERO_FINCA;
                    txtNroResolucion.Text = Entity.RESOLUCION;
                    txtDimensiones.Text = Entity.DIMENSIONES;
                    txtObservacion.Text = Entity.OBSERVACION;
                    txtSuperficie.Text = Entity.MEDIDA_LOTE;
                    cbPaís.SelectedValue = Entity.PAIS_ID;
                    cbDepartamentos.SelectedValue = Entity.DEPARTAMENTO_ID;
                    cbCiudades.SelectedValue = Entity.CIUDAD_ID;
                    cbBarrios.SelectedValue = Entity.BARRIO_ID;
                    txtDireccion.Text = Entity.DIRECCION;
                    txtPorcentajeComision.Text = Entity.COMISION.ToString();
                    txtPrecio.Text = Entity.PRECIO.ToString();
                    
                    //txtDimensiones.Text = Entity.CARACTERISTICAS;

                    if (Entity.ENTIDAD_INMOBILIARIA_ID != null)
                        cbUnidadInmobiliaria.SelectedValue = Entity.ENTIDAD_INMOBILIARIA_ID;

                 

                    if (Constantes.EstadosUnidadesInmobiliarias.LIBRE.Equals(Entity.ESTADO))
                    {
                        lblEstado.Text = "LIBRE";
                        lblEstado.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        lblEstado.Text = Entity.ESTADO.ToUpper();
                        lblEstado.ForeColor = System.Drawing.Color.Red;
                    }
                    CargarPropietarios();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnClose_Click(sender,e);
        }

        private void FrmLotes_Shown(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                PysistemasMensajes.ShowInfo("El número de lote es requerido");
                txtNombre.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(txtManzana.Text))
            {
                PysistemasMensajes.ShowInfo("El número de manzana es requerido");
                txtManzana.Focus();
                return;
            }
            if (cbTipoPropiedad.SelectedValue == null)
            {
                PysistemasMensajes.ShowInfo("El tipo de propiedad es requerido");
                cbTipoPropiedad.Focus();
                return;
            }
            if (cbUnidadInmobiliaria.SelectedValue == null)
            {
                PysistemasMensajes.ShowInfo("El loteamiento es requerido");
                cbUnidadInmobiliaria.Focus();
                return;
            }
            /*if (String.IsNullOrWhiteSpace(txtCuentaCatastral.Text))
            {
                PysistemasMensajes.ShowInfo("El número de cuenta catastral/padrón es requerido");
                txtCuentaCatastral.Focus();
                return;
            }*/
            /*if (String.IsNullOrWhiteSpace(txtNroFinca.Text))
            {
                PysistemasMensajes.ShowInfo("El número de finca/matrícula es requerido");
                txtNroFinca.Focus();
                return;
            }*/
            /*if (String.IsNullOrWhiteSpace(txtNroResolucion.Text))
            {
                PysistemasMensajes.ShowInfo("El número de resolución es requerido");
                txtNroResolucion.Focus();
                return;
            }*/
            if (String.IsNullOrWhiteSpace(txtSuperficie.Text))
            {
                PysistemasMensajes.ShowInfo("La superficie del lote es requerido");
                txtSuperficie.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                PysistemasMensajes.ShowInfo("El precio del lote es requerido");
                txtPrecio.Focus();
                return;
            }
            if (String.IsNullOrWhiteSpace(txtPorcentajeComision.Text))
            {
                PysistemasMensajes.ShowInfo("El porcentaje de la comisión del lote es requerido");
                txtPorcentajeComision.Focus();
                return;
            }
            if (cbTipoPropiedad.SelectedValue != null && !String.IsNullOrWhiteSpace(txtNombre.Text) && cbUnidadInmobiliaria.SelectedValue != null)
            {
                using (PropiedadesDao propiedadesDao = new PropiedadesDao())
                {
                    String tipo = cbTipoPropiedad.SelectedValue.ToString();
                    Int64 entidadId = Int64.Parse(cbUnidadInmobiliaria.SelectedValue.ToString());
                    IList<PROPIEDADES> lista = propiedadesDao.ObtenerDesdeFiltros(p =>
                        p.TIPO.Equals(tipo) && p.NOMBRE.ToUpper().Equals(txtNombre.Text.ToUpper()) && p.ENTIDAD_INMOBILIARIA_ID == entidadId && p.NUMERO_MANZANA.Equals(txtManzana.Text));
                    if (Constantes.Operaciones.NUEVO.Equals(Operacion))
                    {
                        if (lista.Count > 0)
                        {
                            PysistemasMensajes.ShowAlert("Ya existe un " + tipo + " con el nombre " + txtNombre.Text + " para la entidad " + cbUnidadInmobiliaria.Text);
                            txtNombre.Focus();
                            return;
                        }
                    }
                }
            }
            List<SOCIOS_NEGOCIOS_VIEW> propietarios = dgvPropietarios.DataSource as List<SOCIOS_NEGOCIOS_VIEW>;
            if (propietarios == null)
                propietarios = new List<SOCIOS_NEGOCIOS_VIEW>();
            Entity.NUMERO_LOTE = txtNombre.Text;
            Entity.NOMBRE = "L"+txtNombre.Text+"M"+txtManzana.Text;
            Entity.TIPO = cbTipoPropiedad.SelectedValue.ToString();
            Entity.CUENTA_CATASTRAL = txtCuentaCatastral.Text;
            Entity.NUMERO_MANZANA = txtManzana.Text;

            if (cbUnidadInmobiliaria.SelectedValue != null)
                Entity.ENTIDAD_INMOBILIARIA_ID = Int64.Parse(cbUnidadInmobiliaria.SelectedValue.ToString());

            
            Entity.MEDIDA_LOTE = txtSuperficie.Text;
            Entity.NUMERO_FINCA = txtNroFinca.Text;
            if (cbPaís.SelectedValue != null)
                Entity.PAIS_ID = Int64.Parse(cbPaís.SelectedValue.ToString());
            if (cbDepartamentos.SelectedValue != null)
                Entity.DEPARTAMENTO_ID = Int64.Parse(cbDepartamentos.SelectedValue.ToString());
            if (cbCiudades.SelectedValue != null)
                Entity.CIUDAD_ID = Int64.Parse(cbCiudades.SelectedValue.ToString());
            if (cbBarrios.SelectedValue != null)
                Entity.BARRIO_ID = Int64.Parse(cbBarrios.SelectedValue.ToString());
            Entity.DIMENSIONES = txtDimensiones.Text;
            Entity.DIRECCION = txtDireccion.Text;
            if (Constantes.Operaciones.NUEVO.Equals(Operacion))
            {
                Entity.ESTADO = "LIBRE";
            }
                
            else
            {
                Entity.ESTADO = lblEstado.Text.ToUpper();
            }
            

           

            if (String.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                txtPrecio.Text = "0";
            }

            if (Decimal.Parse(txtPrecio.Text) == 0)
            {
                if (!PysistemasMensajes.AskConfirmation(
                    "El precio del inmueble es 0. Está seguro que desea guardar el inmueble con precio 0?"))
                {
                    txtPrecio.Focus();
                    return;
                }
            }


            Entity.PRECIO = decimal.Parse(txtPrecio.Text.Replace(".", ""));
            Entity.COMISION = decimal.Parse(txtPorcentajeComision.Text);
            Entity.ALQUILADA = Constantes.Booleano.NO;
            Entity.SENADO = Constantes.Booleano.NO;
            Entity.VENDIDA = Constantes.Booleano.NO;
            Entity.TIENE_COCHERA = Constantes.Booleano.NO;
            Entity.EMPRESA_ID = FrmPrincipal.Empresa.EMPRESA_ID;

            //Entity.EMPRESA_ID = Constantes.VariablesEntorno.EMPRESA_ID;

           

            try
            {
                PropiedadesService service = new PropiedadesService();
                service.Guardar(Operacion, Entity, propietarios, FrmPrincipal.UsuarioLogueado);
                PysistemasMensajes.ShowInfo("Sus datos han sido guardados con éxito");
                if (PysistemasMensajes.AskConfirmation("Desea cargar otro registro?"))
                {
                    LimpiarPantalla();                                     
                    txtNombre.Focus();
                    Operacion = Constantes.Operaciones.NUEVO;
                }
                else
                {
                    DialogResult = DialogResult.Abort;
                    Close();
                }

                
                //Close();

            }
            catch (Exception exception)
            {
                PysistemasMensajes.ShowError(exception.Message);

            }



        }

        protected override void LimpiarPantalla()
        {
            ControlesUtilidades.ClearComponents(gbDatosLotes);
            ControlesUtilidades.ClearComponents(gbDatosUbicacion);
            ControlesUtilidades.ClearComponents(gbDatosComerciales);
            ControlesUtilidades.ClearComponents(gbDatosPropietarios);
            
            txtPrecio.Text = "0";
            txtPorcentajeComision.Text = "0";
            CargarPorcentajeComisionVenta();
            
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlesUtilidades.camposNumericos(e);
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (!txtPrecio.Text.Equals(String.Empty))
            {
                double numero = Convert.ToDouble(txtPrecio.Text);
                txtPrecio.Text = numero.ToString("N0");
                txtPrecio.SelectionStart = txtPrecio.TextLength;
            }
        }

        private void txtPrecio_MouseClick(object sender, MouseEventArgs e)
        {
            txtPrecio.SelectAll();
        }

        private void cbUnidadInmobiliaria_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbUnidadInmobiliaria.SelectedValue != null)
            {
                ENTIDADES_INMOBILIARIAS entidadInmobiliaria = new ENTIDADES_INMOBILIARIAS();
                using (EntidadesInmobiliariasDao entidadInmobiliariaDao = new EntidadesInmobiliariasDao())
                {
                    Int64 entidadInmobiliariaId = Int64.Parse(cbUnidadInmobiliaria.SelectedValue.ToString());
                    entidadInmobiliaria = entidadInmobiliariaDao.ObtenerDesdePk(entidadInmobiliariaId);

                    if (entidadInmobiliaria.NATURALEZA.Equals("ALQUILER"))
                    {

                    }
                    else if (entidadInmobiliaria.NATURALEZA.Equals("VENTA"))
                    {

                    }
                    

                    if (entidadInmobiliariaId != 0)
                    {
                        if (entidadInmobiliaria.PAIS_ID != 0)
                            cbPaís.SelectedValue = entidadInmobiliaria.PAIS_ID;
                        if (entidadInmobiliaria.DEPARTAMENTO_ID != 0)
                        {
                            cbDepartamentos.SelectedValue = entidadInmobiliaria.DEPARTAMENTO_ID;
                            CargarCiudades(entidadInmobiliaria.DEPARTAMENTO_ID);
                        }

                        if (entidadInmobiliaria.CIUDAD_ID != 0)
                        {
                            cbCiudades.SelectedValue = entidadInmobiliaria.CIUDAD_ID;
                            CargarBarrios(entidadInmobiliaria.CIUDAD_ID);
                        }
                        if (entidadInmobiliaria.BARRIO_ID != 0)
                            cbBarrios.SelectedValue = entidadInmobiliaria.BARRIO_ID;
                        txtDireccion.Text = entidadInmobiliaria.DIRECCION;
                        CargarPropietariosEntidadInmobiliaria();

                    }
                }
            }
            cbUnidadInmobiliaria.Focus();
        }
        private void CargarPropietariosEntidadInmobiliaria()
        {
            using (PropietariosEntidadesInmobiliariasDao propietariosEntidadesDao = new PropietariosEntidadesInmobiliariasDao())
            {
                int entidadInmobiliariaId = Int32.Parse(cbUnidadInmobiliaria.SelectedValue.ToString());
                IList<PROPIETARIOS_ENT_INMOB> listaPropietarios = propietariosEntidadesDao.ObtenerDesdeFiltros(p => p.ENTIDAD_INMOBILIARIA_ID == entidadInmobiliariaId && p.PROPIEDAD_ID.HasValue == false);
                List<SOCIOS_NEGOCIOS_VIEW> listaSociosNegociosPropietarios = new List<SOCIOS_NEGOCIOS_VIEW>();
                if (listaPropietarios.Count > 0)
                {
                    listaSociosNegociosPropietarios = new List<SOCIOS_NEGOCIOS_VIEW>();
                    using (BusquedaSociosNegociosViewDao busquedaSocioNegocioDao = new BusquedaSociosNegociosViewDao())
                    {
                        foreach (PROPIETARIOS_ENT_INMOB propEntidad in listaPropietarios)
                        {
                            int propietarioID = int.Parse(propEntidad.PROPIETARIO_ID.ToString());
                            IList<SOCIOS_NEGOCIOS_VIEW> socio = busquedaSocioNegocioDao.ObtenerDesdeFiltros(p => p.SOCIO_NEGOCIO_ID == propietarioID);
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
        private void CargarBarrios(long? cIUDAD_ID)
        {
            using (BusquedaBarriosCiudadesDao busquedaBarriosCiudadesDao = new BusquedaBarriosCiudadesDao())
            {
                cbBarrios.DataSource = busquedaBarriosCiudadesDao.ObtenerDesdeFiltros(b => b.CIUDAD_ID == cIUDAD_ID);
            }
        }

        private void CargarCiudades(long? dEPARTAMENTO_ID)
        {
            using (BusquedaCiudadesDepartamentosViewDao busquedaCiudadesDepartamentosDao = new BusquedaCiudadesDepartamentosViewDao())
            {
                cbCiudades.DataSource = busquedaCiudadesDepartamentosDao.ObtenerDesdeFiltros(c => c.DEPARTAMENTO_ID == dEPARTAMENTO_ID);

            }
        }

        private void txtPorcentajeComision_MouseClick(object sender, MouseEventArgs e)
        {
            txtPorcentajeComision.SelectAll();
        }

        private void cbTipoPropiedad_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbTipoPropiedad.SelectedValue != null && !String.IsNullOrWhiteSpace(txtNombre.Text) && cbUnidadInmobiliaria.SelectedValue != null)
            {
                using (PropiedadesDao propiedadesDao = new PropiedadesDao())
                {
                    String tipo = cbTipoPropiedad.SelectedValue.ToString();
                    Int64 entidadId = Int64.Parse(cbUnidadInmobiliaria.SelectedValue.ToString());
                    IList<PROPIEDADES> lista = propiedadesDao.ObtenerDesdeFiltros(p =>
                        p.TIPO.Equals(tipo) && p.NOMBRE.ToUpper().Equals(txtNombre.Text.ToUpper()) && p.ENTIDAD_INMOBILIARIA_ID == entidadId && p.NUMERO_MANZANA.Equals(txtManzana.Text));
                    if (Constantes.Operaciones.NUEVO.Equals(Operacion))
                    {
                        if (lista.Count > 0)
                        {
                            PysistemasMensajes.ShowAlert("Ya existe un " + tipo + " con el nombre " + txtNombre.Text + " para la entidad " + cbUnidadInmobiliaria.Text);
                            txtNombre.Focus();
                            return;
                        }
                    }
                }
            }
        }

        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            if (txtPrecio.Text == "")
            {
                txtPrecio.Text = "0";
            }
        }

        private void txtPorcentajeComision_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlesUtilidades.camposNumericos(e);
        }

        private void txtPorcentajeComision_Leave(object sender, EventArgs e)
        {
            if (txtPorcentajeComision.Text == "")
            {
                CargarPorcentajeComisionVenta();
            }

        }
    }
}
