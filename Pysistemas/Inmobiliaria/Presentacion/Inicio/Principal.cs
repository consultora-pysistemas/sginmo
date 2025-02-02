using System;
using System.IO;
using System.Windows.Forms;
using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Presentacion.Mantenimiento.Empresa;
using Inmobiliaria.Presentacion.Mantenimiento.SociosNegocios;
using Inmobiliaria.Presentacion.Mantenimiento.Sucursales;
using Inmobiliaria.Services.Configuraciones;
using Inmobiliaria.Utilidades.Seguridad;
using Inmobiliaria.Presentacion.EntidadesInmobiliarias.Propiedades;
using Inmobiliaria.Presentacion.EntidadesInmobiliarias.Operaciones;
using Inmobiliaria.Presentacion.EntidadesInmobiliarias.Entidades;
using Inmobiliaria.Presentacion.EntidadesInmobiliarias.Buscadores;
using Inmobiliaria.Presentacion.Gastos.Buscadores;
using Inmobiliaria.Presentacion.Gastos.Gastos;
using Inmobiliaria.Presentacion.Mantenimiento.Buscadores;
using Inmobiliaria.Presentacion.Mantenimiento.UbicacionGeografica;
using Inmobiliaria.Presentacion.Mantenimiento.UbicacionGeografica.Buscadores;
using Inmobiliaria.Presentacion.Mantenimiento.Generales;
using Inmobiliaria.Presentacion.ParametrosReportes;
using System.Collections.Generic;
using System.Globalization;
using CrystalDecisions.Shared;
using Inmobiliaria.Presentacion.Cobros.Cobros;
using Inmobiliaria.Presentacion.Mantenimiento.Seleccionadores;
using Inmobiliaria.Presentacion.Cobros.Buscadores;
using Inmobiliaria.Reportes;
using Inmobiliaria.Utilidades.Controles;
using Inmobiliaria.Presentacion.Procesos;
using Inmobiliaria.Presentacion.Mantenimiento.Parametricos;
using Inmobiliaria.Presentacion.Mantenimiento.Usuarios;

namespace Inmobiliaria.Presentacion.Inicio
{
    public partial class Principal : Form
    {
        public Login Login { get; set; }
        public EMPRESAS Empresa { get; set; }
        public PysistemasConfiguraciones Configuraciones { get; set; }
        public USUARIOS UsuarioLogueado { get; set; }
        public Splash Splash { get; set; }

        public Principal()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            Empresa = new EMPRESAS();
            Configuraciones = new PysistemasConfiguraciones();

            if (!Configuraciones.KeyExists("Servidor", "Conexión"))
            {
                Configuraciones.CrearConfiguracionPorDefecto();

            }


            //SetearConfiguracionPorDefecto();

            PysistemasLogger.Log("Versión " + PysistemasSeguridad.ObtenerVersion(), typeof(Principal).Name);
            InitializeComponent();
            Hide();
            Splash = new Splash();
            Splash.tmSplash.Tick += TmSplash_Tick;
            Splash.ShowDialog(this);
            Login = new Login();

            if (DialogResult.OK.Equals(Login.ShowDialog()))
            {
                UsuarioLogueado = Login.UsuarioLogueado;
                PysistemasLogger.Log("Usuario logueado " + UsuarioLogueado.CODIGO_USUARIO, typeof(Inmobiliaria.Inicio).Name);
                CargarConfiguracionesAsync();
                Login.Close();

                Show();
            }

        }

        private void SetearConfiguracionPorDefecto()
        {
            if (File.Exists(Configuraciones.Path))
            {

            }
        }

        void CargarConfiguracionesAsync()
        {
            tslblUsuario.Text = UsuarioLogueado.CODIGO_USUARIO;

            Configuraciones.CargarVariablesEntorno(UsuarioLogueado.CODIGO_USUARIO);
#if DEBUG
            PysistemasLogger.Log(String.Format("Variable Entornos"), typeof(Principal).Name);
            foreach (KeyValuePair<string, VARIABLES_ENTORNOS> keys in Configuraciones.VariablesEntornos)
            {
                PysistemasLogger.Log(String.Format("Variable {0} valor {1}", keys.Key, keys.Value.VALOR), typeof(Principal).Name);
            }

#endif
            CargarEmpresa();
            CargarSucursal();
            tslblEstacion.Text = PysistemasSeguridad.ObtenerNombreEstacion();
            CargarTooltips();

        }

        private void CargarTooltips()
        {

        }

        private void CargarSucursal()
        {
            tslblSucursal.Tag = Configuraciones.ObtenerValorVariableEntorno(Constantes.VariablesEntorno.SUCURSAL_ID) == null ? 0 : Int64.Parse(Configuraciones.ObtenerValorVariableEntorno(Constantes.VariablesEntorno.SUCURSAL_ID).VALOR);
            tslblSucursal.Text = Configuraciones.ObtenerValorVariableEntorno(Constantes.VariablesEntorno.SUCURSAL) == null ? String.Empty : Configuraciones.ObtenerValorVariableEntorno(Constantes.VariablesEntorno.SUCURSAL).VALOR;
        }

        private void CargarEmpresa()
        {
            Empresa.EMPRESA_ID =
                Int64.Parse(Configuraciones.ObtenerValorVariableEntorno(Constantes.VariablesEntorno.EMPRESA_ID).VALOR);
            tslblEmpresa.Tag = Configuraciones.ObtenerValorVariableEntorno(Constantes.VariablesEntorno.EMPRESA_ID) == null ? 0 : Int64.Parse(Configuraciones.ObtenerValorVariableEntorno(Constantes.VariablesEntorno.EMPRESA_ID).VALOR);
            tslblEmpresa.Text = Configuraciones.ObtenerValorVariableEntorno(Constantes.VariablesEntorno.EMPRESA) == null ? String.Empty : Configuraciones.ObtenerValorVariableEntorno(Constantes.VariablesEntorno.EMPRESA).VALOR;
        }

        private void TmSplash_Tick(object sender, EventArgs e)
        {
            Splash.Close();
        }

        private void Principal_Shown(object sender, EventArgs e)
        {
            SetearConfiguraciones();
            Activate();
        }

        private void SetearConfiguraciones()
        {
            tslblVersion.Text = PysistemasSeguridad.ObtenerVersion();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            if ("ADMINISTRADOR".Equals(UsuarioLogueado.PERFIL))
            {
                iNFORMESToolStripMenuItem.Visible = true;
                uSUARIOSToolStripMenuItem.Visible = true;
                pROCESOSToolStripMenuItem.Visible = true;

            }
            else
            {
                iNFORMESToolStripMenuItem.Visible = false;
                uSUARIOSToolStripMenuItem.Visible = false;
                pROCESOSToolStripMenuItem.Visible = false;
                
            }
        }

        private void tmFechaHora_Tick(object sender, EventArgs e)
        {
            tslblFechaHora.Text = DateTime.Now.ToShortDateString() + "-" + DateTime.Now.ToLongTimeString();
        }

        private void eMPRESAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmEmpresa frmEmpresa = new FrmEmpresa(this,Constantes.Operaciones.NUEVO);
            //frmEmpresa.Show(this);
        }

        private void sUCURSALESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmSucursales frmSucursales = new FrmSucursales(this,Constantes.Operaciones.NUEVO);
            //frmSucursales.Show(this);
        }

        private void pROPIETARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void iNQUILINOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmSociosNegocios frmSociosNegocios = new FrmSociosNegocios(this, Constantes.Operaciones.NUEVO, Constantes.TiposSociosNegocios.INQUILINO);
            //frmSociosNegocios.Show(this);
        }

        private void aDMINISTRADORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmSociosNegocios frmSociosNegocios = new FrmSociosNegocios(this, Constantes.Operaciones.NUEVO, Constantes.TiposSociosNegocios.ADMINISTRADOR);
            //frmSociosNegocios.Show(this);
        }

        private void pORTEROSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmSociosNegocios frmSociosNegocios = new FrmSociosNegocios(this, Constantes.Operaciones.NUEVO, Constantes.TiposSociosNegocios.PORTERO);
            //frmSociosNegocios.Show(this);
        }

        private void eNTIDADESINMOBILIARIASToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //FrmBusquedaEntidadesInmobiliarias frmBusquedaEntidadesInmobiliarias = new FrmBusquedaEntidadesInmobiliarias(this);
            //frmBusquedaEntidadesInmobiliarias.Show();


        }

        private void iNMUEBLESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPropiedades frmPropiedades = new FrmPropiedades(this, Constantes.Operaciones.NUEVO);
            frmPropiedades.Show(this);
        }

        private void oPERACIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEntidadesInmobiliarias frmEntidadesInmobiliarias = new FrmEntidadesInmobiliarias(this, Constantes.Operaciones.NUEVO);
            frmEntidadesInmobiliarias.FormClosed += FrmBusquedaEntidadesInmobiliarias_FormClosed;
            frmEntidadesInmobiliarias.Show(this);


        }

        private void eDITARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBusquedaEntidadesInmobiliarias frmBusquedaEntidadesInmobiliarias = new FrmBusquedaEntidadesInmobiliarias(this);
            frmBusquedaEntidadesInmobiliarias.FormClosed += FrmBusquedaEntidadesInmobiliarias_FormClosed;
            frmBusquedaEntidadesInmobiliarias.Show(this);

        }

        private void FrmBusquedaEntidadesInmobiliarias_FormClosed(object sender, FormClosedEventArgs e)
        {
            Activate();
        }

        private void nUEVOToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FrmSociosNegocios frmSociosNegocios = new FrmSociosNegocios(this, Constantes.Operaciones.NUEVO, Constantes.TiposSociosNegocios.PROPIETARIO);
            frmSociosNegocios.Show(this);
            Activate();
        }

        private void mODIFICARToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmBusquedaSociosNegocios frmBusquedaSociosNegocios = new FrmBusquedaSociosNegocios(Constantes.TiposSociosNegocios.PROPIETARIO, this);
            frmBusquedaSociosNegocios.Show(this);
            Activate();
        }

        private void nUEVOToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            FrmSociosNegocios frmSociosNegocios = new FrmSociosNegocios(this, Constantes.Operaciones.NUEVO, Constantes.TiposSociosNegocios.INQUILINO);
            frmSociosNegocios.Show(this);
            Activate();
        }

        private void mODIFICARToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FrmBusquedaSociosNegocios frmBusquedaSociosNegocios = new FrmBusquedaSociosNegocios(Constantes.TiposSociosNegocios.INQUILINO, this);
            frmBusquedaSociosNegocios.Show(this);
            Activate();
        }

        private void nUEVOToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            FrmSociosNegocios frmSociosNegocios = new FrmSociosNegocios(this, Constantes.Operaciones.NUEVO, Constantes.TiposSociosNegocios.PORTERO);
            frmSociosNegocios.Show(this);
            Activate();
        }

        private void mODIFICARToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            FrmBusquedaSociosNegocios frmBusquedaSociosNegocios = new FrmBusquedaSociosNegocios(Constantes.TiposSociosNegocios.PORTERO, this);
            frmBusquedaSociosNegocios.Show(this);
            Activate();
        }

        private void nUEVOToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            FrmSociosNegocios frmSociosNegocios = new FrmSociosNegocios(this, Constantes.Operaciones.NUEVO, Constantes.TiposSociosNegocios.ADMINISTRADOR);
            frmSociosNegocios.Show(this);
            Activate();
        }

        private void mODIFICARToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            FrmBusquedaSociosNegocios frmBusquedaSociosNegocios = new FrmBusquedaSociosNegocios(Constantes.TiposSociosNegocios.ADMINISTRADOR, this);
            frmBusquedaSociosNegocios.Show(this);
            Activate();
        }

        private void nUEVOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPropiedades frmPropiedades = new FrmPropiedades(this, Constantes.Operaciones.NUEVO);
            frmPropiedades.FormClosed += FrmBusquedaEntidadesInmobiliarias_FormClosed;
            frmPropiedades.Show(this);

        }

        private void nUEVOToolStripMenuItem18_Click(object sender, EventArgs e)
        {
            FrmBarrios frmBarrios = new FrmBarrios(this, Constantes.Operaciones.NUEVO);
            frmBarrios.Show(this);
            Activate();

        }

        private void mODIFICARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBusquedaPropiedades frmBusquedaPropiedades = new FrmBusquedaPropiedades(Constantes.TiposEntidades.EDIFICIO, this);
            frmBusquedaPropiedades.Show(this);
        }

        private void mODIFICARToolStripMenuItem16_Click(object sender, EventArgs e)
        {
            FrmBusquedaBarrios frmBusquedaBarrios = new FrmBusquedaBarrios(this);
            frmBusquedaBarrios.Show(this);
            Activate();

        }

        private void nUEVOToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            FrmMonedas frmMonedas = new FrmMonedas(this, Constantes.Operaciones.NUEVO);
            frmMonedas.Show(this);
            Activate();
        }

        private void nUEVOToolStripMenuItem13_Click(object sender, EventArgs e)
        {
            FrmFormasPagos frmFormasPagos = new FrmFormasPagos(this, Constantes.Operaciones.NUEVO);
            frmFormasPagos.Show(this);
            Activate();
        }

        private void nUEVOToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmOperaciones frmOperacion = new FrmOperaciones(this, Constantes.Operaciones.NUEVO);
            frmOperacion.Show(this);

        }

        private void mODIFICARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmBusquedaOperaciones frmBusquedaOperaciones = new FrmBusquedaOperaciones(this);
            frmBusquedaOperaciones.Show(this);


        }

        private void nUEVOToolStripMenuItem17_Click(object sender, EventArgs e)
        {
            FrmCiudades frmCiudades = new FrmCiudades(this, Constantes.Operaciones.NUEVO);
            frmCiudades.Show(this);
            Activate();
        }

        private void mODIFICARToolStripMenuItem17_Click(object sender, EventArgs e)
        {
            FrmBusquedaCiudades frmBusquedaCiudades = new FrmBusquedaCiudades(this);
            frmBusquedaCiudades.Show(this);
            Activate();
        }

        private void nUEVOToolStripMenuItem16_Click(object sender, EventArgs e)
        {
            FrmDepartamentos frmDepartamentos = new FrmDepartamentos(this, Constantes.Operaciones.NUEVO);
            frmDepartamentos.Show(this);
            Activate();
        }

        private void mODIFICARToolStripMenuItem15_Click(object sender, EventArgs e)
        {
            FrmBusquedaDepartamentos frmBusquedaDepartamento = new FrmBusquedaDepartamentos(this);
            frmBusquedaDepartamento.Show(this);
            Activate();
        }

        private void nUEVOToolStripMenuItem15_Click(object sender, EventArgs e)
        {
            FrmPaises frmPaises = new FrmPaises(this, Constantes.Operaciones.NUEVO);
            frmPaises.Show(this);
            Activate();
        }

        private void mODIFICARToolStripMenuItem14_Click(object sender, EventArgs e)
        {
            FrmBusquedaPaises frmBusquedaPais = new FrmBusquedaPaises(this);
            frmBusquedaPais.Show(this);
            Activate();
        }

        private void mODIFICARToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            FrmBusquedaMonedas frmBusquedaMoneda = new FrmBusquedaMonedas(this);
            frmBusquedaMoneda.Show(this);
            Activate();
        }

        private void mODIFICARToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            FrmBusquedaFormasPagos frmBusquedaformaPago = new FrmBusquedaFormasPagos(this);
            frmBusquedaformaPago.Show(this);
            Activate();
        }

        private void nUEVOToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmItemIngresoEgreso frmItemIngresoEgreso = new FrmItemIngresoEgreso(this, Constantes.Operaciones.NUEVO);
            frmItemIngresoEgreso.Show(this);
            Activate();

        }

        private void mODIFICARToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmBusquedaItemIngresosEgresos frmBusquedaItemIngresosEgresos = new FrmBusquedaItemIngresosEgresos(this);
            frmBusquedaItemIngresosEgresos.Show(this);
            Activate();
        }

        private void nUEVOToolStripMenuItem14_Click(object sender, EventArgs e)
        {
            FrmIngresosEgresos frmIngresosEgresos = new FrmIngresosEgresos(this, Constantes.Operaciones.NUEVO, Constantes.TiposIngresosEgresos.INGRESO);
            frmIngresosEgresos.Show(this);
            Activate();
        }

        private void nUEVOToolStripMenuItem19_Click(object sender, EventArgs e)
        {
            FrmSociosNegocios frmSociosNegocios = new FrmSociosNegocios(this, Constantes.Operaciones.NUEVO, Constantes.TiposSociosNegocios.VENDEDOR);
            frmSociosNegocios.Show(this);
            Activate();
        }

        private void mODIFICARToolStripMenuItem18_Click(object sender, EventArgs e)
        {
            FrmBusquedaSociosNegocios frmBusquedaSociosNegocios = new FrmBusquedaSociosNegocios(Constantes.TiposSociosNegocios.VENDEDOR, this);
            frmBusquedaSociosNegocios.Show(this);
            Activate();
        }

        private void nUEVOToolStripMenuItem20_Click(object sender, EventArgs e)
        {
            FrmIngresosEgresos frmIngresosEgresos = new FrmIngresosEgresos(this, Constantes.Operaciones.NUEVO, Constantes.TiposIngresosEgresos.EGRESO);
            frmIngresosEgresos.Show(this);
        }

        private void datosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteDatosPropiedades frmReporteDatosPropiedades = new FrmReporteDatosPropiedades();
            frmReporteDatosPropiedades.lblTitulo.Text = "Informe de datos de Inmuebles";
            frmReporteDatosPropiedades.Show();
        }

        private void informeDeEstadoDeDeptpCasaSalonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteDatosPropiedadesSituacion frmReporteDatosPropiedadesSituacion = new FrmReporteDatosPropiedadesSituacion();
            frmReporteDatosPropiedadesSituacion.lblTitulo.Text = "Informe de Situacion de Inmuebles";
            frmReporteDatosPropiedadesSituacion.Show();
        }

        private void ingresosFijosPorEntidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteIngresosFijosPorEntidades frmReporteIngresoFijosPorEntidades = new FrmReporteIngresosFijosPorEntidades();
            frmReporteIngresoFijosPorEntidades.lblTitulo.Text = "Informe de Ingresos Fijos por Predios";
            frmReporteIngresoFijosPorEntidades.Show();
        }

        private void informeDeContratosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportePropiedadesContratosVencimiento frmReportesPropiedadesContratosVencimiento = new FrmReportePropiedadesContratosVencimiento();
            frmReportesPropiedadesContratosVencimiento.lblTitulo.Text = "Informe de Inmuebles con contratos a vencer";
            frmReportesPropiedadesContratosVencimiento.Show();
        }

        private void eDITARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmBusquedaIngresosEgresos frmBusquedaIngresosEgresos = new FrmBusquedaIngresosEgresos(this, Constantes.TiposIngresosEgresos.EGRESO);
            frmBusquedaIngresosEgresos.Show(this);
            Activate();
        }

        private void nUEVOToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmCobros frmCobros = new FrmCobros(this, Constantes.Operaciones.NUEVO);
            frmCobros.Show(this);
        }

        private void lIQUIDACIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLiquidaciones frmLiquidacion = new FrmLiquidaciones(this, Constantes.Operaciones.NUEVO);
            frmLiquidacion.Show(this);
        }

        private void ventaDePropiedadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteVentasPropiedades frmReporteVentasPropiedades = new FrmReporteVentasPropiedades();
            frmReporteVentasPropiedades.lblTitulo.Text = "Informe de Ventas de Inmuebles";
            frmReporteVentasPropiedades.Show();
        }

        private void mODIFICARToolStripMenuItem13_Click(object sender, EventArgs e)
        {
            FrmBusquedaIngresosEgresos frmBusquedaIngresosEgresos = new FrmBusquedaIngresosEgresos(this, Constantes.TiposIngresosEgresos.INGRESO);
            frmBusquedaIngresosEgresos.Show(this);
        }

        private void rESUMENDECUOTASCOBRADASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteCuotasCobradas frmReporteCuotasCobradas = new FrmReporteCuotasCobradas();
            frmReporteCuotasCobradas.lblTitulo.Text = "Resumen de cuotas cobradas";
            frmReporteCuotasCobradas.Show();
        }

        private void rESUMENDECUENTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteResumenCuenta frmReporteResumenCuenta = new FrmReporteResumenCuenta();
            frmReporteResumenCuenta.lblTitulo.Text = "Resumen de cuenta";
            frmReporteResumenCuenta.Show();
        }

        private void pLANILLADECOBROSDEALQUILERESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteCobroAlquileres frmReporteCobroAlquileres = new FrmReporteCobroAlquileres();
            frmReporteCobroAlquileres.lblTitulo.Text = "Planilla de Cobros";
            frmReporteCobroAlquileres.Show();
        }

        private void pLANILLADEEGRESOSPORITEMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportePagosPorItems frmReportePagosPorItems = new FrmReportePagosPorItems();
            frmReportePagosPorItems.lblTitulo.Text = "Planilla de Egresos por Items";
            frmReportePagosPorItems.Show();
        }

        private void nUEVOToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            FrmEmpresa frmEmpresa = new FrmEmpresa(this, Constantes.Operaciones.NUEVO);
            frmEmpresa.Show();
        }

        private void tslblEmpresa_Click(object sender, EventArgs e)
        {
            FrmSeleccionarEmpresa frmSeleccionarEmpresa = new FrmSeleccionarEmpresa(this);
            if (DialogResult.OK.Equals(frmSeleccionarEmpresa.ShowDialog(this)))
            {
                CargarEmpresa();
                CargarSucursal();
            }
        }

        private void mODIFICARToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            FrmBusquedaEmpresas frmBusquedaEmpresas = new FrmBusquedaEmpresas(this);
            frmBusquedaEmpresas.Show(this);
        }

        private void sELECCIONARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSeleccionarEmpresa frmSeleccionarEmpresa = new FrmSeleccionarEmpresa(this);
            if (DialogResult.OK.Equals(frmSeleccionarEmpresa.ShowDialog(this)))
            {
                CargarEmpresa();
                CargarSucursal();
            }
        }

        private void tslblSucursal_Click(object sender, EventArgs e)
        {
            FrmSeleccionarSucursales frmSeleccionarSucursales = new FrmSeleccionarSucursales(this);
            if (DialogResult.OK.Equals(frmSeleccionarSucursales.ShowDialog(this)))
            {
                CargarSucursal();
            }

        }

        private void nUEVOToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            FrmSucursales frmSucursales = new FrmSucursales(this, Constantes.Operaciones.NUEVO);
            frmSucursales.Show(this);
        }

        private void mODIFICARToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            FrmBusquedaSucursales frmBusquedaSucursales = new FrmBusquedaSucursales(this);
            frmBusquedaSucursales.Show(this);
        }

        private void sELECCIONARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tslblSucursal_Click(sender, null);
        }

        private void nUEVOToolStripMenuItem21_Click(object sender, EventArgs e)
        {
            FrmLotes frmLotes = new FrmLotes(this, Constantes.Operaciones.NUEVO);
            frmLotes.Show(this);
        }

        private void mODIFICARToolStripMenuItem19_Click(object sender, EventArgs e)
        {
            FrmBusquedaPropiedades frmBusquedaPropiedades = new FrmBusquedaPropiedades(Constantes.TiposEntidades.LOTEAMIENTO, this);
            frmBusquedaPropiedades.Show(this);
        }

        private void vENDEDORESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mODIFICARToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmBusquedaCobros frmBusquedaCobros = new FrmBusquedaCobros(this);
            frmBusquedaCobros.Show(this);
        }

        private void pLANILLADECUOTASPORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteCronogramaCuotas frmReporteCronogramaCuotas = new FrmReporteCronogramaCuotas();
            frmReporteCronogramaCuotas.lblTitulo.Text = "Planilla de Cuotas por Edificio/Loteamiento";
            frmReporteCronogramaCuotas.Show();
        }

        private void pLANILLADEVENCIMIENTODECUOTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteCronogramaCuotasPorFechas frmReporteCronogramaCuotasPorFechas = new FrmReporteCronogramaCuotasPorFechas(Empresa.EMPRESA_ID);
            frmReporteCronogramaCuotasPorFechas.lblTitulo.Text = "Planilla de Cuotas Pendientes";
            frmReporteCronogramaCuotasPorFechas.Show();
        }

        private void iNGRESOSVSEGRESOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteIngresosEgresos frmReporteIngresosEgresos = new FrmReporteIngresosEgresos(this);
            frmReporteIngresosEgresos.lblTitulo.Text = "Ingresos vs Egresos";
            frmReporteIngresosEgresos.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            var cronogramaCuotasPorFechas = new cronograma_cuotas_semanal();
            FrmReporte frmReporte = new FrmReporte();
            frmReporte.lblTitulo.Text = "Cuentas a cobrar";
            Int64 empresaId = Int64.Parse(Configuraciones.VariablesEntornos[Constantes.VariablesEntorno.EMPRESA_ID].VALOR);
            int thisWeekNumber = ControlesUtilidades.GetIso8601WeekOfYear(DateTime.Today);
            DateTime firstDayOfWeek = ControlesUtilidades.FirstDateOfWeek(DateTime.Today.Year, thisWeekNumber, CultureInfo.CurrentCulture);
            DateTime fechaFin = firstDayOfWeek.AddDays(5);

            Console.WriteLine(firstDayOfWeek.AddDays(1));

            Console.WriteLine(firstDayOfWeek.AddDays(5));
            cronogramaCuotasPorFechas.SetParameterValue("EMPRESA_ID_IN", empresaId);
            cronogramaCuotasPorFechas.SetParameterValue("ENTIDAD_INMOBILIARIA_ID_IN", -1);
            cronogramaCuotasPorFechas.SetParameterValue("PROPIEDAD_ID_IN", -1);

            cronogramaCuotasPorFechas.SetParameterValue("FECHA_DESDE_INI", firstDayOfWeek);
            cronogramaCuotasPorFechas.SetParameterValue("FECHA_HASTA_INI", fechaFin);
            frmReporte.crystalReportViewer1.ReportSource = cronogramaCuotasPorFechas;

            ExportOptions exportOptions = cronogramaCuotasPorFechas.ExportOptions;
            exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
            frmReporte.Show();
            frmReporte.crystalReportViewer1.Show();
        }

        private void pLANILLADERECAUDACIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportePlanillaRecaudacion frmReportePlanillaRecaudacion = new FrmReportePlanillaRecaudacion(Empresa.EMPRESA_ID);
            frmReportePlanillaRecaudacion.lblTitulo.Text = "Planilla de Recaudacion";
            frmReportePlanillaRecaudacion.Show();
        }

        private void rENOVACIONESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRenovacionContratos frmRenovacionContratos = new FrmRenovacionContratos(this);
            frmRenovacionContratos.Show();
        }
        private void gENERARLOTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGenerarLotes frmGenerarLotes = new FrmGenerarLotes();
            frmGenerarLotes.Show();

        }

        private void pLANILLADEEGRESOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportePlanillaEgresos frmReportePlanillaEgresos = new FrmReportePlanillaEgresos();
            frmReportePlanillaEgresos.lblTitulo.Text = "Planilla de Egresos";
            frmReportePlanillaEgresos.Show();
        }

        private void mODIFICARToolStripMenuItem20_Click(object sender, EventArgs e)
        {
            FrmBusquedaLiquidaciones frmBusquedaLiquidaciones = new FrmBusquedaLiquidaciones(this);
            frmBusquedaLiquidaciones.lblTitulo.Text = "Busqueda de Liquidaciones";
            frmBusquedaLiquidaciones.Show();

        }

        private void pARAMETROSDELSISTEMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UsuarioLogueado.PERFIL.Equals("ADMINISTRADOR"))
            {
                FrmParametrosSistema frmParametrosSistema = new FrmParametrosSistema(this, "E");
                frmParametrosSistema.lblTitulo.Text = "";
                frmParametrosSistema.Show();
            }
            else
            {
                PysistemasMensajes.ShowInfo("No tiene permisos para ingresar a esta opcion.");
                return;
            }
        }

        private void rEGENERARCUOTASToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (UsuarioLogueado.PERFIL.Equals("ADMINISTRADOR"))
            {
                FrmBuscadorOperaciones frmBuscadorOperaciones = new FrmBuscadorOperaciones(this, "R");
                frmBuscadorOperaciones.Show();
            }
            else
            {
                PysistemasMensajes.ShowInfo("No tiene permisos para ingresar a esta opcion.");
                return;
            }

        }

        private void nUEVOToolStripMenuItem22_Click(object sender, EventArgs e)
        {
            if (UsuarioLogueado.PERFIL.Equals("ADMINISTRADOR"))
            {
                FrmUsuarios frmUsuarios = new FrmUsuarios(this, "N");
                frmUsuarios.lblTitulo.Text = "";
                frmUsuarios.Show();
            }
            else
            {
                PysistemasMensajes.ShowInfo("No tiene permisos para ingresar a esta opcion.");
                return;
            }
        }

        private void mODIFICARToolStripMenuItem21_Click(object sender, EventArgs e)
        {
            if (UsuarioLogueado.PERFIL.Equals("ADMINISTRADOR"))
            {

                FrmBusquedaUsuarios frmBusquedaUsuarios = new FrmBusquedaUsuarios(this);
                frmBusquedaUsuarios.Show();
            }
            else
            {
                PysistemasMensajes.ShowInfo("No tiene permisos para ingresar a esta opcion.");
                return;
            }
        }

        private void iNFORMESToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void cUENTASAPAGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteGastosAdministracion frmReporteGastosAdministracion = new FrmReporteGastosAdministracion(this);
            frmReporteGastosAdministracion.lblTitulo.Text = "Cuentas a pagar "+ tslblEmpresa.Text;
            frmReporteGastosAdministracion.Show();
        }
    }
    }

