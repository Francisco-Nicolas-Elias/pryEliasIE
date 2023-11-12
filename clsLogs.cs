using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace pryEliasIE
{
    internal class clsLogs
    {
        
        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataReader lectorBD;

        OleDbDataAdapter adaptadorBD;
        DataSet objDS = new DataSet();

        string cadenaConexionBase;

        string cadenaConexionElClub;

        public string estadoDeConexion;
        
        frmLogin frmLogin = new frmLogin();
        public clsLogs()
        {
            
            try
            {
                cadenaConexionBase = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Resources\\BaseDatosUsuarios.accdb";              

                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = cadenaConexionBase;              
                conexionBD.Open();

                objDS = new DataSet();

                estadoDeConexion = "Conectado";
            }
            catch (Exception error)
            {
                estadoDeConexion = error.Message;
            }
            

            // Constructor para inicializar la conexión y el comando.
            conexionBD = new OleDbConnection();
            comandoBD = new OleDbCommand();
        }

        public void ConectarBD()
        {
            try
            {
                string conexion = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Resources\\BaseDatosUsuarios.accdb";

                conexionBD.ConnectionString = conexion;
                conexionBD.Open();

            }
            catch (Exception error)
            {
                MessageBox.Show(Convert.ToString(error));
            }
        }
        
        public void RegistroLogInicioSesionExitoso()
        {
            try
            {  
                ConectarBD();

                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;

                //Establezco el tipo de comando, con este comando le indico que voy a trabajar con una tabla específica
                comandoBD.CommandType = System.Data.CommandType.TableDirect;

                //Le digo que tabla quiero traer
                comandoBD.CommandText = "Logs";

                //Creo el objeto DataAdapter pasando como parámetro el objeto comando que quiero vincular
                adaptadorBD = new OleDbDataAdapter(comandoBD);

                //Ejecuto la lectura de la tabla y almaceno su contenido en el dataAdapter
                adaptadorBD.Fill(objDS, "Logs");

                //Obtengo una referencia a la tabla

                DataTable objTabla = objDS.Tables["Logs"];

                //Creo el nuevo DataRow con la estructura de campos de la tabla de la cual quiero traer los datos
                DataRow nuevoRegistro = objTabla.NewRow();

                //Asigno los valores a todos los campos del DataRow
                nuevoRegistro["Categoria"] = "Inicio Sesión";
                nuevoRegistro["FechaHora"] = DateTime.Now;
                nuevoRegistro["Descripcion"] = "Inicio exitoso";
                nuevoRegistro["Usuario"] = frmLogin.usuario;

                //Agrego el DataRow a la tabla
                objTabla.Rows.Add(nuevoRegistro);


                //Creo el objeto OledBCommandBuilder pasando como parámetro el DataAdapter
                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);

                //Actualizo la base con los cambios realizados
                adaptadorBD.Update(objDS, "Logs");

                estadoDeConexion = "Registro exitoso de log";
            }
            catch (Exception error)
            {
                estadoDeConexion = error.Message;
            }
        }
        
        public void RegistroLogInicioSesionFallido()
        {
            try
            {
                ConectarBD();
                
                comandoBD = new OleDbCommand();


                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "Logs";

                adaptadorBD = new OleDbDataAdapter(comandoBD);

                adaptadorBD.Fill(objDS, "Logs");

                DataTable objTabla = objDS.Tables["Logs"];
                DataRow nuevoRegistro = objTabla.NewRow();

                nuevoRegistro["Categoria"] = "Inicio Sesión";
                nuevoRegistro["FechaHora"] = DateTime.Now;
                nuevoRegistro["Descripcion"] = "Inicio fallido";
                nuevoRegistro["Usuario"] = frmLogin.usuario;

                objTabla.Rows.Add(nuevoRegistro);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);
                adaptadorBD.Update(objDS, "Logs");

                estadoDeConexion = "Registro exitoso de log";
            }
            catch (Exception error)
            {

                estadoDeConexion = error.Message;
            }
        }

        public void RegistroLogReestablecerContraseñaExitoso()
        {
            try
            {
                ConectarBD();
                
                comandoBD = new OleDbCommand();
                

                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "Logs";

                adaptadorBD = new OleDbDataAdapter(comandoBD);

                adaptadorBD.Fill(objDS, "Logs");

                DataTable objTabla = objDS.Tables["Logs"];
                DataRow nuevoRegistro = objTabla.NewRow();

                nuevoRegistro["Categoria"] = "Reestablecer contraseña";
                nuevoRegistro["FechaHora"] = DateTime.Now;
                nuevoRegistro["Descripcion"] = "Exitoso";
                nuevoRegistro["Usuario"] = frmReestablecerContraseña.usuarioReestablecerContraseña;

                objTabla.Rows.Add(nuevoRegistro);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);
                adaptadorBD.Update(objDS, "Logs");

                estadoDeConexion = "Registro exitoso de log";
            }
            catch (Exception error)
            {
                estadoDeConexion = error.Message;
            }
        }

        public void RegistroLogReestablecerContraseñaFallido()
        {
            try
            {
                ConectarBD();

                comandoBD = new OleDbCommand();


                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "Logs";

                adaptadorBD = new OleDbDataAdapter(comandoBD);

                adaptadorBD.Fill(objDS, "Logs");

                DataTable objTabla = objDS.Tables["Logs"];
                DataRow nuevoRegistro = objTabla.NewRow();

                nuevoRegistro["Categoria"] = "Reestablecer contraseña";
                nuevoRegistro["FechaHora"] = DateTime.Now;
                nuevoRegistro["Descripcion"] = "Fallido";
                nuevoRegistro["Usuario"] = frmReestablecerContraseña.usuarioReestablecerContraseña;

                objTabla.Rows.Add(nuevoRegistro);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);
                adaptadorBD.Update(objDS, "Logs");

                estadoDeConexion = "Registro exitoso de log";
            }
            catch (Exception error)
            {
                estadoDeConexion = error.Message;
            }
        }


        public void RegistroLogVisitaCarpetas()
        {
            try
            {
                ConectarBD();
                
                comandoBD = new OleDbCommand();

  
                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "Logs";

                adaptadorBD = new OleDbDataAdapter(comandoBD);

                adaptadorBD.Fill(objDS, "Logs");

                DataTable objTabla = objDS.Tables["Logs"];
                DataRow nuevoRegistro = objTabla.NewRow();

                nuevoRegistro["Categoria"] = "Carpetas";
                nuevoRegistro["FechaHora"] = DateTime.Now;
                nuevoRegistro["Descripcion"] = "Exitoso";
                nuevoRegistro["Usuario"] = frmLogin.usuario;

                objTabla.Rows.Add(nuevoRegistro);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);
                adaptadorBD.Update(objDS, "Logs");

                estadoDeConexion = "Registro exitoso de log";
            }
            catch (Exception error)
            {
                estadoDeConexion = error.Message;
            }
        }

        public void RegistroLogCrearCuentaExitoso()
        {
            try
            {
                ConectarBD();

                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "Logs";

                adaptadorBD = new OleDbDataAdapter(comandoBD);

                adaptadorBD.Fill(objDS, "Logs");

                DataTable objTabla = objDS.Tables["Logs"];
                DataRow nuevoRegistro = objTabla.NewRow();

                nuevoRegistro["Categoria"] = "Crear cuenta";
                nuevoRegistro["FechaHora"] = DateTime.Now;
                nuevoRegistro["Descripcion"] = "Exitoso";
                nuevoRegistro["Usuario"] = frmCrearCuenta.usuarioCrearCuenta;

                objTabla.Rows.Add(nuevoRegistro);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);
                adaptadorBD.Update(objDS, "Logs");

                estadoDeConexion = "Registro exitoso de log";
            }
            catch (Exception error)
            {
                estadoDeConexion = error.Message;
            }
        }

        public void RegistroLogCrearCuentaFallido()
        {
            try
            {
                ConectarBD();

                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "Logs";

                adaptadorBD = new OleDbDataAdapter(comandoBD);

                adaptadorBD.Fill(objDS, "Logs");

                DataTable objTabla = objDS.Tables["Logs"];
                DataRow nuevoRegistro = objTabla.NewRow();

                nuevoRegistro["Categoria"] = "Crear cuenta";
                nuevoRegistro["FechaHora"] = DateTime.Now;
                nuevoRegistro["Descripcion"] = "Fallido";
                nuevoRegistro["Usuario"] = frmCrearCuenta.usuarioCrearCuenta;

                objTabla.Rows.Add(nuevoRegistro);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);
                adaptadorBD.Update(objDS, "Logs");

                estadoDeConexion = "Registro exitoso de log";
            }
            catch (Exception error)
            {
                estadoDeConexion = error.Message;
            }
        }

        public void RegistroLogVerCarpetasProveedoresYAseguradores()
        {
            try
            {
                ConectarBD();

                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "Logs";

                adaptadorBD = new OleDbDataAdapter(comandoBD);

                adaptadorBD.Fill(objDS, "Logs");

                DataTable objTabla = objDS.Tables["Logs"];
                DataRow nuevoRegistro = objTabla.NewRow();

                nuevoRegistro["Categoria"] = "Ver carpetas y archivos";
                nuevoRegistro["FechaHora"] = DateTime.Now;
                nuevoRegistro["Descripcion"] = "Exitoso";
                nuevoRegistro["Usuario"] = frmLogin.usuario;

                objTabla.Rows.Add(nuevoRegistro);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);
                adaptadorBD.Update(objDS, "Logs");

                estadoDeConexion = "Registro exitoso de log";
            }
            catch (Exception error)
            {
                estadoDeConexion = error.Message;
            }
        }

        public void RegistroLogGrabarRegistro()
        {
            try
            {
                ConectarBD();

                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "Logs";

                adaptadorBD = new OleDbDataAdapter(comandoBD);

                adaptadorBD.Fill(objDS, "Logs");

                DataTable objTabla = objDS.Tables["Logs"];
                DataRow nuevoRegistro = objTabla.NewRow();

                nuevoRegistro["Categoria"] = "Grabar registro";
                nuevoRegistro["FechaHora"] = DateTime.Now;
                nuevoRegistro["Descripcion"] = "Exitoso";
                nuevoRegistro["Usuario"] = frmLogin.usuario;

                objTabla.Rows.Add(nuevoRegistro);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);
                adaptadorBD.Update(objDS, "Logs");

                estadoDeConexion = "Registro exitoso de log";
            }
            catch (Exception error)
            {
                estadoDeConexion = error.Message;
            }
        }

        public void RegistroLogModificarRegistro()
        {
            try
            {
                ConectarBD();

                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "Logs";

                adaptadorBD = new OleDbDataAdapter(comandoBD);

                adaptadorBD.Fill(objDS, "Logs");

                DataTable objTabla = objDS.Tables["Logs"];
                DataRow nuevoRegistro = objTabla.NewRow();

                nuevoRegistro["Categoria"] = "Modificar registro";
                nuevoRegistro["FechaHora"] = DateTime.Now;
                nuevoRegistro["Descripcion"] = "Exitoso";
                nuevoRegistro["Usuario"] = frmLogin.usuario;

                objTabla.Rows.Add(nuevoRegistro);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);
                adaptadorBD.Update(objDS, "Logs");

                estadoDeConexion = "Registro exitoso de log";
            }
            catch (Exception error)
            {
                estadoDeConexion = error.Message;
            }
        }


        public void RegistroLogBorrarRegistro()
        {
            try
            {
                ConectarBD();

                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "Logs";

                adaptadorBD = new OleDbDataAdapter(comandoBD);

                adaptadorBD.Fill(objDS, "Logs");

                DataTable objTabla = objDS.Tables["Logs"];
                DataRow nuevoRegistro = objTabla.NewRow();

                nuevoRegistro["Categoria"] = "Borrar registro";
                nuevoRegistro["FechaHora"] = DateTime.Now;
                nuevoRegistro["Descripcion"] = "Exitoso";
                nuevoRegistro["Usuario"] = frmLogin.usuario;

                objTabla.Rows.Add(nuevoRegistro);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);
                adaptadorBD.Update(objDS, "Logs");

                estadoDeConexion = "Registro exitoso de log";
            }
            catch (Exception error)
            {
                estadoDeConexion = error.Message;
            }
        }


        public void RegistroLogBuscarClientePorId()
        {
            try
            {
                ConectarBD();

                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "Logs";

                adaptadorBD = new OleDbDataAdapter(comandoBD);

                adaptadorBD.Fill(objDS, "Logs");

                DataTable objTabla = objDS.Tables["Logs"];
                DataRow nuevoRegistro = objTabla.NewRow();

                nuevoRegistro["Categoria"] = "Buscar socio por ID";
                nuevoRegistro["FechaHora"] = DateTime.Now;
                nuevoRegistro["Descripcion"] = "Exitoso";
                nuevoRegistro["Usuario"] = frmLogin.usuario;

                objTabla.Rows.Add(nuevoRegistro);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);
                adaptadorBD.Update(objDS, "Logs");

                estadoDeConexion = "Registro exitoso de log";
            }
            catch (Exception error)
            {
                estadoDeConexion = error.Message;
            }
        }

        public void RegistroLogBuscarClientePorApellido()
        {
            try
            {
                ConectarBD();

                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "Logs";

                adaptadorBD = new OleDbDataAdapter(comandoBD);

                adaptadorBD.Fill(objDS, "Logs");

                DataTable objTabla = objDS.Tables["Logs"];
                DataRow nuevoRegistro = objTabla.NewRow();

                nuevoRegistro["Categoria"] = "Buscar socio por apellido";
                nuevoRegistro["FechaHora"] = DateTime.Now;
                nuevoRegistro["Descripcion"] = "Exitoso";
                nuevoRegistro["Usuario"] = frmLogin.usuario;

                objTabla.Rows.Add(nuevoRegistro);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);
                adaptadorBD.Update(objDS, "Logs");

                estadoDeConexion = "Registro exitoso de log";
            }
            catch (Exception error)
            {
                estadoDeConexion = error.Message;
            }
        }

        public void RegistroLogVerSociosDelClub()
        {
            try
            {
                ConectarBD();

                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "Logs";

                adaptadorBD = new OleDbDataAdapter(comandoBD);

                adaptadorBD.Fill(objDS, "Logs");

                DataTable objTabla = objDS.Tables["Logs"];
                DataRow nuevoRegistro = objTabla.NewRow();

                nuevoRegistro["Categoria"] = "Ver socios del club";
                nuevoRegistro["FechaHora"] = DateTime.Now;
                nuevoRegistro["Descripcion"] = "Exitoso";
                nuevoRegistro["Usuario"] = frmLogin.usuario;

                objTabla.Rows.Add(nuevoRegistro);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);
                adaptadorBD.Update(objDS, "Logs");

                estadoDeConexion = "Registro exitoso de log";
            }
            catch (Exception error)
            {
                estadoDeConexion = error.Message;
            }
        }


        public void RegistroLogCerrarSesion()
        {
            try
            {
                ConectarBD();

                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "Logs";

                adaptadorBD = new OleDbDataAdapter(comandoBD);

                adaptadorBD.Fill(objDS, "Logs");

                DataTable objTabla = objDS.Tables["Logs"];
                DataRow nuevoRegistro = objTabla.NewRow();

                nuevoRegistro["Categoria"] = "Cerrar sesión";
                nuevoRegistro["FechaHora"] = DateTime.Now;
                nuevoRegistro["Descripcion"] = "Exitoso";
                nuevoRegistro["Usuario"] = frmLogin.usuario;

                objTabla.Rows.Add(nuevoRegistro);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);
                adaptadorBD.Update(objDS, "Logs");

                estadoDeConexion = "Registro exitoso de log";
            }
            catch (Exception error)
            {
                estadoDeConexion = error.Message;
            }
        }

        public void RegistroLogCambiarEstado()
        {
            try
            {
                ConectarBD();

                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "Logs";

                adaptadorBD = new OleDbDataAdapter(comandoBD);

                adaptadorBD.Fill(objDS, "Logs");

                DataTable objTabla = objDS.Tables["Logs"];
                DataRow nuevoRegistro = objTabla.NewRow();

                nuevoRegistro["Categoria"] = "Cambiar estado de socio";
                nuevoRegistro["FechaHora"] = DateTime.Now;
                nuevoRegistro["Descripcion"] = "Exitoso";
                nuevoRegistro["Usuario"] = frmLogin.usuario;

                objTabla.Rows.Add(nuevoRegistro);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);
                adaptadorBD.Update(objDS, "Logs");

                estadoDeConexion = "Registro exitoso de log";
            }
            catch (Exception error)
            {
                estadoDeConexion = error.Message;
            }
        }
    }
}
