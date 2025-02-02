using Inmobiliaria.Presentacion.Inicio;
using System;
using System.Windows.Forms;
using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.Mantenimiento;
using Inmobiliaria.Modelo.Views;
using Inmobiliaria.Utilidades.Controles;
using System.Text;
using System.Collections.Generic;
using Inmobiliaria.Utilidades.Seguridad;

namespace Inmobiliaria.Presentacion.Mantenimiento.SociosNegocios
{
    public partial class FrmSociosNegocios : Genericos.FrmMaestro
    {
        public SOCIOS_NEGOCIOS Entity { get; set; }
        public string Operacion { get; set; }
        public string TipoSocioNegocio { get; set; }
        public FrmSociosNegocios(Principal principal,String operacion,String tipo):base(principal)
        {
            InitializeComponent();
            Operacion = operacion;
            TipoSocioNegocio = tipo;
            Entity = new SOCIOS_NEGOCIOS();
            CargarConfiguraciones();
            txtNumeroDocumento.LostFocus += TxtNumeroDocumento_LostFocus;
        }

        public FrmSociosNegocios()
        {
            InitializeComponent();
        }
        private void TxtNumeroDocumento_LostFocus(object sender, EventArgs e)
        {
            
            VerificarSiExiste();

        }

        private void VerificarSiExiste()
        {
            using (SociosNegociosDao socioNegocioView = new SociosNegociosDao())
            {
                
                if (!string.IsNullOrEmpty(txtNumeroDocumento.Text))
                {
                    IList<SOCIOS_NEGOCIOS> listaSoiosNegocios = socioNegocioView.ObtenerDesdeFiltros(it => it.NUMERO_DOCUMENTO.ToUpper().Equals(txtNumeroDocumento.Text.ToUpper()) );
                    if(listaSoiosNegocios.Count > 0)
                    {
                        Entity = listaSoiosNegocios[0];
                        txtRazonSocial.Text = Entity.RAZON_SOCIAL;
                        txtNumeroDocumento.Text = Entity.NUMERO_DOCUMENTO;
                        txtDigitoVerificador.Text = Entity.DIGITO_VERIFICADOR;
                        cbTipoDocumento.SelectedValue = Entity.TIPO_DOCUMENTO;
                        cbTipoPersoneria.SelectedValue = Entity.TIPO_PERSONERIA;
                        txtDireccion.Text = Entity.DIRECCION;
                        txtTelefono.Text = Entity.TELEFONO;
                        txtCorreo.Text = Entity.EMAIL;
                        Operacion = Constantes.Operaciones.EDITAR;
                    }
                }
            }
        }

        private void CargarConfiguraciones()
        {
            using (DominiosDao dominiosDao = new DominiosDao())
            {
                cbTipoPersoneria.DataSource = dominiosDao.ObtenerDesdeFiltros(d =>
                    d.DOMINIO.Equals(Constantes.Dominios.TIPOS_PERSONERIAS));
                cbTipoDocumento.DataSource = dominiosDao.ObtenerDesdeFiltros(d =>
                    d.DOMINIO.Equals(Constantes.Dominios.TIPOS_DOCUMENTOS_IDENTIDAD));
                ControlesUtilidades.InicializarComboBox(cbTipoDocumento);
                ControlesUtilidades.InicializarComboBox(cbTipoPersoneria);
            }
        }

        

        private void FrmSociosNegocios_Load(object sender, EventArgs e)
        {
            String tipo = String.Empty;
            if (Constantes.TiposSociosNegocios.ADMINISTRADOR.Equals(TipoSocioNegocio))
            {
                tipo = "Administradores";
            }else if (Constantes.TiposSociosNegocios.INQUILINO.Equals(TipoSocioNegocio))
            {
                tipo = "Clientes";
            }else if (Constantes.TiposSociosNegocios.PROPIETARIO.Equals(TipoSocioNegocio))
            {
                tipo = "Propietarios";
            }else if (Constantes.TiposSociosNegocios.PORTERO.Equals(TipoSocioNegocio))
            {
                tipo = "Porteros";
            }
            else if (Constantes.TiposSociosNegocios.VENDEDOR.Equals(TipoSocioNegocio))
            {
                tipo = "Vendedores";
            }
            if (Operacion != null && Constantes.Operaciones.NUEVO.Equals(Operacion))
            {
                lblTitulo.Text = "Crear "+tipo;
                gbDatosEmpresa.Text = "Datos " + tipo;
            }
            else
            {
                lblTitulo.Text = "Modificar " + tipo;
                gbDatosEmpresa.Text = "Datos " + tipo;
                //Obtener el id de la empresa que se desea editar
                txtRazonSocial.Text = Entity.RAZON_SOCIAL;
                txtNumeroDocumento.Text = Entity.NUMERO_DOCUMENTO;
                txtDigitoVerificador.Text = Entity.DIGITO_VERIFICADOR;
                cbEsContribuyente.SelectedItem = Entity.ES_CONTRIBUYENTE;
                cbTipoDocumento.SelectedValue = Entity.TIPO_DOCUMENTO;
                cbTipoPersoneria.SelectedValue = Entity.TIPO_PERSONERIA;
                txtDireccion.Text = Entity.DIRECCION;
                txtTelefono.Text = Entity.TELEFONO;
                txtCorreo.Text = Entity.EMAIL;
                txtObservacion.Text = Entity.OBSERVACION;
                cbSexo.SelectedItem = Entity.SEXO;
                
                //lblUbicacion.Text = Entity.UBICACION;
                txtUbicacion.Text = Entity.UBICACION;
               
            }
            txtNumeroDocumento.Focus();
        }

        private void FrmSociosNegocios_Shown(object sender, EventArgs e)
        {
            txtNumeroDocumento.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnClose_Click(sender,e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                if (String.IsNullOrWhiteSpace(txtRazonSocial.Text))
                {
                    if (!String.IsNullOrWhiteSpace(sb.ToString()))
                    {
                        sb.Append("La razón social del propietario es requerido");
                    }else
                    {
                        sb.AppendLine("La razón social del propietario es requerido");
                    }
                }
                if (String.IsNullOrWhiteSpace(txtNumeroDocumento.Text))
                {
                    if (!String.IsNullOrWhiteSpace(sb.ToString()))
                    {
                        sb.Append("El número de documento del propietario es requerido");
                    }
                    else
                    {
                        sb.AppendLine("El número de documento del propietario es requerido");
                    }
                }
                if (cbTipoPersoneria.SelectedValue == null)
                {
                    if (!String.IsNullOrWhiteSpace(sb.ToString()))
                    {
                        sb.Append("El tipo de personeria del propietario es requerido");
                    }
                    else
                    {
                        sb.AppendLine("El tipo de personeria del propietario es requerido");
                    }
                }
                if (cbTipoDocumento.SelectedValue == null)
                {
                    if (!String.IsNullOrWhiteSpace(sb.ToString()))
                    {
                        sb.Append("El tipo de documento del propietario es requerido");
                    }
                    else
                    {
                        sb.AppendLine("El tipo de documento del propietario es requerido");
                    }
                }
                if (String.IsNullOrWhiteSpace(txtDireccion.Text))
                {
                    if (!String.IsNullOrWhiteSpace(sb.ToString()))
                    {
                        sb.Append("La dirección del propietario es requerido");
                    }
                    else
                    {
                        sb.AppendLine("La dirección del propietario es requerido");
                    }
                }
                if (String.IsNullOrWhiteSpace(txtTelefono.Text))
                {
                    if (!String.IsNullOrWhiteSpace(sb.ToString()))
                    {
                        sb.Append("El teléfono del propietario es requerido");
                    }
                    else
                    {
                        sb.AppendLine("El teléfono del propietario es requerido");
                    }
                }
                if (cbTipoDocumento.SelectedItem == null)
                {
                    if ("PERFIS".Equals(cbTipoPersoneria.SelectedValue.ToString()))
                    {
                        if (!String.IsNullOrWhiteSpace(sb.ToString()))
                        {
                            sb.Append("El sexo de la persona es requerido");
                        }
                        else
                        {
                            sb.AppendLine("El sexo de la persona es requerido");
                        }
                    }
                    
                }

                if (!String.IsNullOrWhiteSpace(sb.ToString()))
                {
                    PysistemasMensajes.ShowAlert(sb.ToString());
                    
                }else
                {
                    using (SociosNegociosDao sociosNegociosDao = new SociosNegociosDao())
                    {
                        if (Constantes.Operaciones.EDITAR.Equals(Operacion))
                        {
                            Entity = sociosNegociosDao.ObtenerDesdePk(Entity.SOCIO_NEGOCIO_ID);
                        }

                        Entity.ES_ADMINISTRADOR = Constantes.Booleano.NO;
                        Entity.ES_CLIENTE = Constantes.Booleano.NO;
                        Entity.ES_EMPRESA = Constantes.Booleano.NO;
                        Entity.ES_INQUILINO = Constantes.Booleano.NO;
                        Entity.ES_PORTERO = Constantes.Booleano.NO;
                        Entity.ES_PROPIETARIO = Constantes.Booleano.NO;
                        Entity.ES_PROVEEDOR = Constantes.Booleano.NO;
                        Entity.ES_VENDEDOR = Constantes.Booleano.NO;                                              
                        //Entity.UBICACION = lblUbicacion.Text;
                        Entity.UBICACION = txtUbicacion.Text;
                        Entity.OBSERVACION = txtObservacion.Text;
                        Entity.RAZON_SOCIAL = txtRazonSocial.Text;
                        Entity.NUMERO_DOCUMENTO = txtNumeroDocumento.Text;
                        Entity.DIGITO_VERIFICADOR = txtDigitoVerificador.Text;
                        Entity.ACTIVO = Constantes.Booleano.SI;
                        Entity.DIRECCION = txtDireccion.Text;
                        Entity.TELEFONO = txtTelefono.Text;
                        Entity.EMAIL = txtCorreo.Text;
                        Entity.TIPO_DOCUMENTO = cbTipoDocumento.SelectedValue.ToString();
                        Entity.TIPO_PERSONERIA = cbTipoPersoneria.SelectedValue.ToString();
                        Entity.CLASIFICACION_FISCAL = "GRAVADA";
                        Entity.ES_CONTRIBUYENTE = Constantes.Booleano.SI;
                        Entity.UBICACION = txtUbicacion.Text;
                        if (Constantes.TiposSociosNegocios.ADMINISTRADOR.Equals(TipoSocioNegocio))
                        {
                            Entity.ES_ADMINISTRADOR = Constantes.Booleano.SI;
                        }
                        else if (Constantes.TiposSociosNegocios.INQUILINO.Equals(TipoSocioNegocio))
                        {
                            Entity.ES_INQUILINO = Constantes.Booleano.SI;
                        }
                        else if (Constantes.TiposSociosNegocios.PROPIETARIO.Equals(TipoSocioNegocio))
                        {
                            Entity.ES_PROPIETARIO = Constantes.Booleano.SI;
                        }
                        else if (Constantes.TiposSociosNegocios.PORTERO.Equals(TipoSocioNegocio))
                        {
                            Entity.ES_PORTERO = Constantes.Booleano.SI;
                        }
                        else if (Constantes.TiposSociosNegocios.VENDEDOR.Equals(TipoSocioNegocio))
                        {
                            Entity.ES_VENDEDOR = Constantes.Booleano.SI;
                        }
                        if (cbSexo.SelectedItem == null)
                            Entity.SEXO = "MASCULINO";
                        else
                            Entity.SEXO = cbSexo.SelectedItem.ToString();
                        if (Constantes.Operaciones.NUEVO.Equals(Operacion))
                        {
                            Entity.USUARIO_CREACION = FrmPrincipal.UsuarioLogueado.CODIGO_USUARIO;
                            Entity.FECHA_CREACION = System.DateTime.Now;
                            sociosNegociosDao.Agregar(Entity);

                        }

                        
                        else
                        {
                            Entity.USUARIO_MODIFICACION = FrmPrincipal.UsuarioLogueado.CODIGO_USUARIO;
                            Entity.FECHA_MODIFICACION = System.DateTime.Now;
                            sociosNegociosDao.Actualizar(Entity);
                        }
                        sociosNegociosDao.Guardar();
                        PysistemasMensajes.ShowInfo("Sus datos se guardaron con éxito");
                        if (PysistemasMensajes.AskConfirmation("Desea cargar otro registro?"))
                        {
                            ControlesUtilidades.ClearComponents(gbDatosEmpresa);
                            txtNumeroDocumento.Focus();
                            Operacion = Constantes.Operaciones.NUEVO;
                        }
                        else
                        {
                            btnClose_Click(null, null);
                        }
                        
                    }
                   
                    
                }



            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void txtNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlesUtilidades.camposNumericos(e);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmVerUbicacion frmVerUbicacion = new FrmVerUbicacion();
            if (!String.IsNullOrEmpty(lblUbicacion.Text))
            {
                Uri url = new Uri(lblUbicacion.Text);
                frmVerUbicacion.url = url;
            }


            if (DialogResult.OK.Equals(frmVerUbicacion.ShowDialog(this)))
            {
                Entity.UBICACION = frmVerUbicacion.url.AbsoluteUri;
                lblUbicacion.Text = Entity.UBICACION;
                PysistemasLogger.Log(Entity.UBICACION,this.Name);
                frmVerUbicacion.Close();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbEsContribuyente_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbEsContribuyente.SelectedItem != null)
            {
                if (Constantes.Booleano.SI.Equals(cbEsContribuyente.SelectedItem))
                {
                    if (String.IsNullOrWhiteSpace(txtNumeroDocumento.Text))
                    {
                        txtDigitoVerificador.Text = String.Empty;
                    }
                    else
                    {
                        txtDigitoVerificador.Text = ControlesUtilidades.calcularDigitoVerificador(long.Parse(txtNumeroDocumento.Text)).ToString();                      

                    }
                }
                else
                {
                    txtDigitoVerificador.Text = String.Empty;
                }
               
            }
        }

        private void txtObservacion_TextChanged(object sender, EventArgs e)
        {
            txtObservacion.SelectionStart = txtObservacion.Text.Length;
            txtObservacion.ScrollToCaret();
            txtObservacion.Refresh();
        }
    }
}
