using Inmobiliaria.Modelo;
using Inmobiliaria.Modelo.Dao.Mantenimiento;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Inmobiliaria.Modelo.Views;

namespace Inmobiliaria.Services.Configuraciones
{
    public class PysistemasConfiguraciones
    {
        public Dictionary<string, VARIABLES_ENTORNOS> VariablesEntornos { get; set; }
        public string Path;
        string EXE = Assembly.GetExecutingAssembly().GetName().Name;
        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        public PysistemasConfiguraciones(string IniPath = null)
        {
            Path = new FileInfo(IniPath ?? EXE + ".ini").FullName.ToString();
            if (!File.Exists(Path))
            {
                File.Create(Path);
                CrearConfiguracionPorDefecto();
            }
            
            Console.WriteLine(Path);
        }

        public void CrearConfiguracionPorDefecto()
        {
            Write("Servidor","localhost","Conexión");
            Write("Database", @"c:\inmobiliaria.fdb", "Conexión");
            Write("Usuario", "sysdba", "Conexión");
            Write("Password", "masterkey", "Conexión");


        }

        public void CargarVariablesEntorno(string codigoUsuario)
        {
            Dictionary<string, VARIABLES_ENTORNOS> listaVariablesEntornos = new Dictionary<string, VARIABLES_ENTORNOS>();
            using (VariablesEntornosDao variablesEntornosDao = new VariablesEntornosDao())
            {
                IList<VARIABLES_ENTORNOS> lista =
                    variablesEntornosDao.ObtenerDesdeFiltros(v => v.CODIGO_USUARIO.Equals(codigoUsuario));
                foreach (VARIABLES_ENTORNOS variable in lista)
                {
                    listaVariablesEntornos.Add(variable.CLAVE, variable);
                }
            }



            VariablesEntornos = listaVariablesEntornos;
        }

        public VARIABLES_ENTORNOS ObtenerValorVariableEntorno(string key)
        {

            return VariablesEntornos[key];
        }

        public void SetearVariableEntorno(VARIABLES_ENTORNOS variable, string codigoUsuario)
        {
            using (VariablesEntornosDao variablesEntornosDao = new VariablesEntornosDao())
            {
                IList<VARIABLES_ENTORNOS> listaVariableExistente = variablesEntornosDao.ObtenerDesdeFiltros(v => v.CLAVE.Equals(variable.CLAVE));
                if (listaVariableExistente != null && listaVariableExistente.Count > 0)
                {
                    listaVariableExistente[0].CLAVE = variable.CLAVE;
                    listaVariableExistente[0].VALOR = variable.VALOR;

                    variablesEntornosDao.Actualizar(listaVariableExistente[0]);


                }
                else
                {
                    variable.FECHA_CREACION = DateTime.Now;
                    variable.USUARIO_CREACION = codigoUsuario;
                    variable.CODIGO_USUARIO = codigoUsuario;
                    variablesEntornosDao.Agregar(variable);
                }
                variablesEntornosDao.Guardar();
                CargarVariablesEntorno(codigoUsuario);

            }

        }

        public string Read(string Key, string Section = null)
        {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path);
            return RetVal.ToString();
        }

        public void Write(string Key, string Value, string Section = null)
        {
            WritePrivateProfileString(Section ?? EXE, Key, Value, Path);
        }

        public void DeleteKey(string Key, string Section = null)
        {
            Write(Key, null, Section ?? EXE);
        }

        public void DeleteSection(string Section = null)
        {
            Write(null, null, Section ?? EXE);
        }

        public bool KeyExists(string Key, string Section = null)
        {
            return Read(Key, Section).Length > 0;
        }

        public void SetearConexion()
        {
            String servidor = Read("Servidor", "Conexión");//"localhost";
            String urlBase = @"c:\inmobiliaria.fdb";
            String usuario = "sysdba";
            String password = "masterkey";
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStrings = config.ConnectionStrings;
            foreach (ConnectionStringSettings connectionString in connectionStrings.ConnectionStrings)
            {
                if (connectionString.Name.Equals("InmobiliariaEntities"))
                {
                    connectionString.ConnectionString =
                        "metadata=res://*/Modelo.Model.csdl|res://*/Modelo.Model.ssdl|res://*/Modelo.Model.msl;provider=FirebirdSql.Data.FirebirdClient;provider connection string=" + "\"character set=UTF8;data source=" + servidor + ";initial catalog=" + urlBase + ";user id=" + usuario + ";password=" + password + "\"";
                    Utilidades.Seguridad.PysistemasLogger.Log(connectionString.ConnectionString, "Principal");
                }
                

            }
            config.Save(ConfigurationSaveMode.Modified, true);
            ConfigurationManager.RefreshSection(config.ConnectionStrings.SectionInformation.SectionName);
        }

        public void CambiarVariablesEntorno(EMPRESAS empresa,String codigoUsuario)
        {
            using (VariablesEntornosDao variablesEntornosDao = new VariablesEntornosDao())
            {
                //Obtener variable entorno empresaId
                VARIABLES_ENTORNOS variableEmpresaId = variablesEntornosDao.ObtenerDesdeFiltros(v =>
                        v.CODIGO_USUARIO.Equals(codigoUsuario) &&
                        v.CLAVE.Equals(Constantes.VariablesEntorno.EMPRESA_ID))
                    .SingleOrDefault();
                if (variableEmpresaId != null)
                {
                    variableEmpresaId.VALOR = empresa.EMPRESA_ID.ToString();
                    variablesEntornosDao.Actualizar(variableEmpresaId);
                    variablesEntornosDao.Guardar();
                }
                //Obtener variable entorno empresa
                VARIABLES_ENTORNOS variableEmpresa = variablesEntornosDao.ObtenerDesdeFiltros(v =>
                        v.CODIGO_USUARIO.Equals(codigoUsuario) &&
                        v.CLAVE.Equals(Constantes.VariablesEntorno.EMPRESA))
                    .SingleOrDefault();
                if (variableEmpresa != null)
                {
                    variableEmpresa.VALOR = empresa.RAZON_SOCIAL;
                    variablesEntornosDao.Actualizar(variableEmpresa);
                    variablesEntornosDao.Guardar();
                }

                //Obtener sucursal por defecto de la empresa
                using (SucursalesDao sucursalesDao = new SucursalesDao())
                {
                    SUCURSALES sucursal = sucursalesDao.ObtenerDesdeFiltros(s=>s.EMPRESA_ID == empresa.EMPRESA_ID && s.POR_DEFECTO.Equals(Constantes.Booleano.SI)).SingleOrDefault();
                    if (sucursal != null)
                    {
                        //Obtener variable entorno sucursalId
                        VARIABLES_ENTORNOS variableSucursalId = variablesEntornosDao.ObtenerDesdeFiltros(v =>
                                v.CODIGO_USUARIO.Equals(codigoUsuario) &&
                                v.CLAVE.Equals(Constantes.VariablesEntorno.SUCURSAL_ID))
                            .SingleOrDefault();
                        if (variableSucursalId != null)
                        {
                            variableSucursalId.VALOR = sucursal.SUCURSAL_ID.ToString();
                            variablesEntornosDao.Actualizar(variableSucursalId);
                            variablesEntornosDao.Guardar();
                        }

                        //Obtener variable entorno sucursal
                        VARIABLES_ENTORNOS variableSucursal = variablesEntornosDao.ObtenerDesdeFiltros(v =>
                                v.CODIGO_USUARIO.Equals(codigoUsuario) &&
                                v.CLAVE.Equals(Constantes.VariablesEntorno.SUCURSAL))
                            .SingleOrDefault();
                        if (variableSucursal != null)
                        {
                            variableSucursal.VALOR = sucursal.SUCURSAL;
                            variablesEntornosDao.Actualizar(variableSucursal);
                            variablesEntornosDao.Guardar();
                        }
                    }
                    
                }


            }
        }

        public void CambiarSucursales(SUCURSALES sucursal,String codigoUsuario)
        {
            using (VariablesEntornosDao variablesEntornosDao = new VariablesEntornosDao())
            {
                
                //Obtener sucursal por defecto de la empresa
                using (SucursalesDao sucursalesDao = new SucursalesDao())
                {
                    
                    
                        //Obtener variable entorno sucursalId
                        VARIABLES_ENTORNOS variableSucursalId = variablesEntornosDao.ObtenerDesdeFiltros(v =>
                                v.CODIGO_USUARIO.Equals(codigoUsuario) &&
                                v.CLAVE.Equals(Constantes.VariablesEntorno.SUCURSAL_ID))
                            .SingleOrDefault();
                        if (variableSucursalId != null)
                        {
                            variableSucursalId.VALOR = sucursal.SUCURSAL_ID.ToString();
                            variablesEntornosDao.Actualizar(variableSucursalId);
                            variablesEntornosDao.Guardar();
                        }

                        //Obtener variable entorno sucursal
                        VARIABLES_ENTORNOS variableSucursal = variablesEntornosDao.ObtenerDesdeFiltros(v =>
                                v.CODIGO_USUARIO.Equals(codigoUsuario) &&
                                v.CLAVE.Equals(Constantes.VariablesEntorno.SUCURSAL))
                            .SingleOrDefault();
                        if (variableSucursal != null)
                        {
                            variableSucursal.VALOR = sucursal.SUCURSAL;
                            variablesEntornosDao.Actualizar(variableSucursal);
                            variablesEntornosDao.Guardar();
                        }
                    

                }


            }
        }



    }
}
