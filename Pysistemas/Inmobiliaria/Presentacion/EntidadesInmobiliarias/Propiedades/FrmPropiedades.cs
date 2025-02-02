using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.EntidadesInmobiliarias;
using Inmobiliaria.Modelo.Dao.Mantenimiento;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Presentacion.Genericos;
using Inmobiliaria.Presentacion.Inicio;
using Inmobiliaria.Presentacion.Mantenimiento.Buscadores;
using Inmobiliaria.Services.EntidadesInmobiliarias;
using Inmobiliaria.Utilidades.Controles;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inmobiliaria.Presentacion.EntidadesInmobiliarias.Propiedades
{
    public partial class FrmPropiedades : Inmobiliaria.Presentacion.Genericos.FrmMaestro
    {
        public String Operacion { get; set; }
        public PROPIEDADES Entity { get; set; }
        public SOCIOS_NEGOCIOS_VIEW Propietario { get; set; }

        private String precioVenta { get; set; }
        private String precioAlquiler { get; set; }

        public FrmPropiedades(Principal principal,String operacion):base(principal)
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
            Entity = new PROPIEDADES();
            ConfiguracionesGrid(dgvPropietarios);
            CargarDatos();
            tcAnalisis.TabPages.Remove(tabPage1);

        }
        private void EsperaCargaDatos()
        {
            Thread.Sleep(500);
        }

        async void CargarDatos()
        {
            await CargarPaises();
            
            await CargarTiposPropiedades();
            await CargarEntidadesInmobiliarias();

            CargarPorcentajeComisionAlquiler();



        }

        async Task CargarEntidadesInmobiliarias()
        {
            using(EntidadesInmobiliariasDao entidadesInmobiliariasDao = new EntidadesInmobiliariasDao())
            {
                cbUnidadInmobiliaria.DataSource = entidadesInmobiliariasDao.ObtenerDesdeFiltros(c => !"LOTEAMIENTO".Equals(c.TIPO));
            }
            ControlesUtilidades.InicializarComboBox(cbUnidadInmobiliaria);

            return;
        }

        async Task CargarTiposPropiedades()
        {

            using (DominiosDao dominiosDao = new DominiosDao())
            {
                cbTipoPropiedad.DataSource = dominiosDao.ObtenerDesdeFiltros(d => d.DOMINIO.Equals(Constantes.Dominios.TIPOS_PROPIEDADES) && !"LOTE".Equals(d.CODIGO_DOMINIO));
                ControlesUtilidades.InicializarComboBox(cbTipoPropiedad);
            }

            return;
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
        private void CargarPorcentajeComisionAlquiler()
        {
            using (DominiosDao dominiosDao = new DominiosDao())
            {
                txtPorcentajeComision.Text = dominiosDao.ObtenerDesdeFiltros(d => d.DOMINIO.Equals(Constantes.Dominios.PORCENTAJE_COMISION_ALQUILER))[0].VALOR_DOMINIO;

            }
        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlesUtilidades.camposNumericos(e);            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnClose_Click(sender, e);
        }

        private void FrmPropiedades_Load(object sender, EventArgs e)
        {
            if (Constantes.Operaciones.NUEVO.Equals(Operacion))
            {
                lblTitulo.Text = "Crear Departamentos/Casas/Dúplex";
            }else
            {
                lblTitulo.Text = "Modificar Departamentos/Casas/Dúplex";
                if(Entity != null)
                {
                    txtNombre.Text = Entity.NOMBRE;
                    cbTipoPropiedad.SelectedValue = Entity.TIPO;
                    txtCuentaCatastral.Text = Entity.CUENTA_CATASTRAL;
                    txtNroFinca.Text = Entity.NUMERO_FINCA;
                    txtMedidasLote.Text = Entity.MEDIDA_LOTE;
                    txtM2Contruccion.Text = Entity.M2_CONSTRUCCION.ToString();
                    txtAnoContruccion.Text = Entity.ANO_CONSTRUCCION.ToString();
                    txtNis.Text = Entity.NIS;
                    chkTieneCochera.Checked = Constantes.Booleano.SI.Equals(Entity.TIENE_COCHERA) ? true : false;
                    txtCantidadCochera.Text = Entity.CANTIDAD_COCHERA == null?"0":Entity.CANTIDAD_COCHERA.ToString();
                    cbPaís.SelectedValue = Entity.PAIS_ID;
                    cbDepartamentos.SelectedValue = Entity.DEPARTAMENTO_ID;
                    cbCiudades.SelectedValue = Entity.CIUDAD_ID;
                    cbBarrios.SelectedValue = Entity.BARRIO_ID;
                    txtDireccion.Text = Entity.DIRECCION;
                    txtPorcentajeComision.Text = Entity.COMISION_ALQUILER.ToString();
                    txtPrecio.Text = Entity.PRECIO_ALQUILER.ToString();
                    txtCtaCteEssap.Text = Entity.CTA_CTE_ESSAP;
                    txtMedidorEssap.Text = Entity.NUMERO_MEDIDOR_ESSAP;
                    txtCaracteristicas.Text = Entity.CARACTERISTICAS;

                    if (Entity.ENTIDAD_INMOBILIARIA_ID != null)
                        cbUnidadInmobiliaria.SelectedValue = Entity.ENTIDAD_INMOBILIARIA_ID;

                    txtAnoContruccion.Text = Entity.ANO_CONSTRUCCION.ToString();
                    txtMedidor.Text = Entity.NUMERO_MEDIDOR;

                    if (Constantes.EstadosUnidadesInmobiliarias.LIBRE.Equals(Entity.ESTADO))
                    {
                        lblEstado.Text = "LIBRE";
                        lblEstado.ForeColor = System.Drawing.Color.Green;
                    }else
                    {
                        lblEstado.Text = "OCUPADO";
                        lblEstado.ForeColor = System.Drawing.Color.Red;
                    }
                    CargarPropietarios();
                }

            }
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
                    listaPropietarios = propietariosEntidadesDao.ObtenerDesdeFiltros(p => p.PROPIEDAD_ID == Entity.PROPIEDAD_ID );
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

        private void FrmPropiedades_Shown(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }

        private void btnLimpiarEntidad_Click(object sender, EventArgs e)
        {
            ControlesUtilidades.InicializarComboBox(cbUnidadInmobiliaria);
            ControlesUtilidades.InicializarComboBox(cbDepartamentos);
            ControlesUtilidades.InicializarComboBox(cbCiudades);
            ControlesUtilidades.InicializarComboBox(cbBarrios);
            txtDireccion.Text = String.Empty;
            LimpiarPropietarios();
            
        }

        private void LimpiarPropietarios()
        {
            dgvPropietarios.DataSource = null;
            dgvPropietarios.Rows.Clear();

        }

        private void cbUnidadInmobiliaria_SelectedValueChanged(object sender, EventArgs e)
        {
            
            if(cbUnidadInmobiliaria.SelectedValue != null)
            {
                ENTIDADES_INMOBILIARIAS entidadInmobiliaria = new ENTIDADES_INMOBILIARIAS();
                using(EntidadesInmobiliariasDao entidadInmobiliariaDao = new EntidadesInmobiliariasDao())
                {
                    Int64 entidadInmobiliariaId = Int64.Parse(cbUnidadInmobiliaria.SelectedValue.ToString());
                    entidadInmobiliaria = entidadInmobiliariaDao.ObtenerDesdePk(entidadInmobiliariaId);

                    if (entidadInmobiliaria.NATURALEZA.Equals("ALQUILER"))
                    {
                       
                    }
                    else if (entidadInmobiliaria.NATURALEZA.Equals("VENTA"))
                    {
                        
                    }
                    // cargamos los datos de la entidad que son genericos para todos los depto/salon/duplex 
                    // cuando son propiedades tienen que estan todos habilitados los campos
                    //txtMedidasLote.ReadOnly = txtAnoContruccion.ReadOnly = txtM2Contruccion.ReadOnly = txtNroFinca.ReadOnly = txtCuentaCatastral.ReadOnly = true;
                    //traer los datos de la entidad pero permitir modificar 20190518

                    txtCuentaCatastral.Text = entidadInmobiliaria.CUENTA_CATASTRAL;
                    txtNroFinca.Text = entidadInmobiliaria.NUMERO_FINCA;
                    txtM2Contruccion.Text = entidadInmobiliaria.M2_CONSTRUCCION.ToString();
                    txtAnoContruccion.Text = entidadInmobiliaria.ANO_CONSTRUCCION.ToString();
                    txtMedidasLote.Text = entidadInmobiliaria.MEDIDAS_LOTE;
                    //txtMedidor.Focus();

                    if (entidadInmobiliariaId != 0)
                    {
                        if(entidadInmobiliaria.PAIS_ID != 0)
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
                        if(entidadInmobiliaria.BARRIO_ID != 0)
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
            using(BusquedaCiudadesDepartamentosViewDao busquedaCiudadesDepartamentosDao = new BusquedaCiudadesDepartamentosViewDao())
            {
                cbCiudades.DataSource = busquedaCiudadesDepartamentosDao.ObtenerDesdeFiltros(c => c.DEPARTAMENTO_ID == dEPARTAMENTO_ID);
                
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cbTipoPropiedad.SelectedValue != null && !String.IsNullOrWhiteSpace(txtNombre.Text) && cbUnidadInmobiliaria.SelectedValue !=null)
            {
                using (PropiedadesDao propiedadesDao = new PropiedadesDao())
                {
                    String tipo = cbTipoPropiedad.SelectedValue.ToString();
                    Int64 entidadId = Int64.Parse(cbUnidadInmobiliaria.SelectedValue.ToString());
                    IList<PROPIEDADES> lista = propiedadesDao.ObtenerDesdeFiltros(p =>
                        p.TIPO.Equals(tipo) && p.NOMBRE.ToUpper().Equals(txtNombre.Text.ToUpper()) && p.ENTIDAD_INMOBILIARIA_ID == entidadId);
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
                PysistemasMensajes.ShowAlert("Ël nombre del inmueble es requerido");
                txtNombre.Focus();
                return;
            }

            if (cbTipoPropiedad.SelectedValue == null)
            {
                PysistemasMensajes.ShowAlert("El dato de tipo de entidad de negocio Edicio o Loteamiento es requerido");
                cbTipoPropiedad.Focus();
                return;

            }

            /*if (String.IsNullOrWhiteSpace(txtMedidor.Text))
            {
                PysistemasMensajes.ShowAlert("Ël número de medidor de ANDE del inmueble es requerido");
                txtMedidor.Focus();
                return;
            }*/

            /* if (String.IsNullOrWhiteSpace(txtNis.Text))
             {
                 PysistemasMensajes.ShowAlert("Ël número de NIS de ANDE del inmueble es requerido");
                 txtNis.Focus();
                 return;
             }
             if (String.IsNullOrWhiteSpace(txtMedidorEssap.Text))
             {
                 PysistemasMensajes.ShowAlert("Ël número de medidor de ESSAP del inmueble es requerido");
                 txtMedidorEssap.Focus();
                 return;
             }

             if (String.IsNullOrWhiteSpace(txtCtaCteEssap.Text))
             {
                 PysistemasMensajes.ShowAlert("Ël número de cuenta corriente de ESSAP del inmueble es requerido");
                 txtCtaCteEssap.Focus();
                 return;
             }*/

            if (cbPaís.SelectedValue == null)
            {
                PysistemasMensajes.ShowAlert("El país es requerido");
                cbPaís.Focus();
                return;
            }
            if (cbDepartamentos.SelectedValue == null)
            {
                PysistemasMensajes.ShowAlert("El departamento es requerido");
                cbDepartamentos.Focus();
                return;
            }
            if (cbCiudades.SelectedValue == null)
            {
                PysistemasMensajes.ShowAlert("La ciudad es requerida");
                cbCiudades.Focus();
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
                PysistemasMensajes.ShowAlert("La dirección del inmueble es requerido");
                txtDireccion.Focus();
                return;
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


            List<SOCIOS_NEGOCIOS_VIEW> propietarios = dgvPropietarios.DataSource as List<SOCIOS_NEGOCIOS_VIEW>;
            if (propietarios == null)
                propietarios = new List<SOCIOS_NEGOCIOS_VIEW>();
            Entity.NOMBRE = txtNombre.Text;
            Entity.TIPO = cbTipoPropiedad.SelectedValue.ToString();
            Entity.CUENTA_CATASTRAL = txtCuentaCatastral.Text;

            if (cbUnidadInmobiliaria.SelectedValue!=null)
                Entity.ENTIDAD_INMOBILIARIA_ID = Int64.Parse(cbUnidadInmobiliaria.SelectedValue.ToString());

            Entity.ANO_CONSTRUCCION = int.Parse(String.IsNullOrWhiteSpace(txtAnoContruccion.Text) ? "0" : txtAnoContruccion.Text);

            Entity.M2_CONSTRUCCION = int.Parse(String.IsNullOrWhiteSpace(txtM2Contruccion.Text) ? "0" : txtM2Contruccion.Text);

            Entity.MEDIDA_LOTE = txtMedidasLote.Text;
            Entity.NUMERO_FINCA = txtNroFinca.Text;
            if (cbPaís.SelectedValue != null)
                Entity.PAIS_ID = Int64.Parse(cbPaís.SelectedValue.ToString());
            if (cbDepartamentos.SelectedValue != null)
                Entity.DEPARTAMENTO_ID = Int64.Parse(cbDepartamentos.SelectedValue.ToString());
            if (cbCiudades.SelectedValue != null)
                Entity.CIUDAD_ID = Int64.Parse(cbCiudades.SelectedValue.ToString());
            if (cbBarrios.SelectedValue != null)
                Entity.BARRIO_ID = Int64.Parse(cbBarrios.SelectedValue.ToString());
            Entity.CARACTERISTICAS = txtCaracteristicas.Text;
            Entity.DIRECCION = txtDireccion.Text;
            if(String.IsNullOrWhiteSpace(Entity.ESTADO))
                Entity.ESTADO = "LIBRE";
            Entity.NUMERO_MEDIDOR = txtMedidor.Text;
            Entity.NIS = txtNis.Text;
            Entity.CTA_CTE_ESSAP = txtCtaCteEssap.Text;
            Entity.NUMERO_MEDIDOR_ESSAP = txtMedidorEssap.Text;

            if (txtPrecio.Text == "")
            {
                txtPrecio.Text = "0";
                
            }
            

            precioAlquiler = txtPrecio.Text;
            precioVenta = txtPrecio.Text;

            Entity.PRECIO_ALQUILER = decimal.Parse(precioAlquiler.Replace(".",""));
            Entity.PRECIO_VENTA = 0;

            // por si lo que quiera es quitar la comision y en vez de colocar cero le pone vacio
            if (txtPorcentajeComision.Text == "")
            {
                txtPorcentajeComision.Text = "0";
            }
            Entity.COMISION_ALQUILER = decimal.Parse(txtPorcentajeComision.Text);
            Entity.COMISION_VENTA = 0;
            Entity.PRECIO = Entity.PRECIO_ALQUILER;
            Entity.COMISION = Entity.COMISION_ALQUILER;
            Entity.ALQUILADA = Constantes.Booleano.NO;
            Entity.SENADO = Constantes.Booleano.NO;
            Entity.VENDIDA = Constantes.Booleano.NO;
            Entity.TIENE_COCHERA = chkTieneCochera.Checked ? Constantes.Booleano.SI : Constantes.Booleano.NO;
            Entity.CANTIDAD_COCHERA = String.IsNullOrWhiteSpace(txtCantidadCochera.Text) ? 0 : Int32.Parse(txtCantidadCochera.Text);
            Entity.EMPRESA_ID = FrmPrincipal.Empresa.EMPRESA_ID;

            //Entity.EMPRESA_ID = Constantes.VariablesEntorno.EMPRESA_ID;

            if (!VerificarDatosObligatorios())
            {
                PysistemasMensajes.ShowInfo("Favor complete los campos requeridos");
                return;
            }

            try
            {
                PropiedadesService service = new PropiedadesService();
                service.Guardar(Operacion, Entity, propietarios, FrmPrincipal.UsuarioLogueado);
                PysistemasMensajes.ShowInfo("Sus datos han sido guardados con éxito");

                if (PysistemasMensajes.AskConfirmation("Desea cargar otro registro?"))
                {
                    LimpiarPantalla();                    
                    Operacion = Constantes.Operaciones.NUEVO;
                    txtPrecio.Text = "0";
                    txtPorcentajeComision.Text = "0";
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
            ControlesUtilidades.ClearComponents(gbDatosInmobiliarios);
            ControlesUtilidades.ClearComponents(gbDatosUbicacion);
            ControlesUtilidades.ClearComponents(gbDatosComerciales);
            ControlesUtilidades.ClearComponents(gbDatosPropietarios);
            txtPrecio.Text = "0";
            txtPorcentajeComision.Text = "0";
            CargarPorcentajeComisionAlquiler();
            txtNombre.Focus();
        }
        private bool VerificarDatosObligatorios()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
                return false;
            if (cbTipoPropiedad.SelectedValue == null)
                return false;
            if (cbPaís.SelectedValue == null && cbDepartamentos.SelectedValue == null && cbCiudades.SelectedValue == null && cbBarrios.SelectedValue == null)
                return false;
            return true;
        }

        private void chkTieneCochera_CheckedChanged(object sender, EventArgs e)
        {
            txtCantidadCochera.Enabled = chkTieneCochera.Checked;
        }

        private void txtPrecioVenta_TextChanged(object sender, EventArgs e)
        {
            if (!txtPrecio.Text.Equals(String.Empty))
            {
                double numero = Convert.ToDouble(txtPrecio.Text);
                txtPrecio.Text = numero.ToString("N0");
                txtPrecio.SelectionStart = txtPrecio.TextLength;
            }
            
        }
        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlesUtilidades.camposNumericos(e);
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

            }
        }

        private void tsbtnAgregar_Click(object sender, EventArgs e)
        {
            IList<SOCIOS_NEGOCIOS_VIEW> lista = dgvPropietarios.DataSource as IList<SOCIOS_NEGOCIOS_VIEW>;
            if (lista == null)
            {
                lista = new List<SOCIOS_NEGOCIOS_VIEW>();
            }
            SOCIOS_NEGOCIOS_VIEW socioNegocio = Propietario;
            lista.Add(socioNegocio);

            dgvPropietarios.DataSource = null;
            dgvPropietarios.Rows.Clear();
            dgvPropietarios.DataSource = lista;
            txtPropietario.Text = String.Empty;
            txtPropietario.Tag = null;
        }

        private void cbUnidadInmobiliaria_Leave(object sender, EventArgs e)
        {
            txtMedidor.Focus();          
        }

        private void txtPrecioVenta_MouseClick(object sender, MouseEventArgs e)
        {
            txtPrecio.SelectAll();
        }

        private void txtPorcentajeComisionVenta_MouseClick(object sender, MouseEventArgs e)
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
                        p.TIPO.Equals(tipo) && p.NOMBRE.ToUpper().Equals(txtNombre.Text.ToUpper()) && p.ENTIDAD_INMOBILIARIA_ID == entidadId);
                    if (Constantes.Operaciones.NUEVO.Equals(Operacion))
                    {
                        if (lista.Count > 0)
                        {
                            PysistemasMensajes.ShowAlert("Ya existe un " + tipo + " con el nombre " + txtNombre.Text+" para la entidad "+cbUnidadInmobiliaria.Text);
                            txtNombre.Focus();
                            return;
                        }
                    }
                }
            }
            
        }

        private void txtCantidadCochera_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlesUtilidades.camposNumericos(e);
        }

        private void txtAnoContruccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlesUtilidades.camposNumericos(e);
        }

        private void txtM2Contruccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlesUtilidades.camposNumericos(e);
        }

        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            if (txtPrecio.Text == "")
            {
                txtPrecio.Text = "0";
            }
        }

        private void txtPorcentajeComision_Leave(object sender, EventArgs e)
        {
            if (txtPorcentajeComision.Text == "")
            {
                CargarPorcentajeComisionAlquiler();
            }

        }
    }
}
