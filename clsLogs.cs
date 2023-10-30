using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Data;

namespace pryEliasIE
{
    internal class clsLogs
    {
        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataReader lectorBD;

        OleDbDataAdapter adaptadorBD;
        DataSet objDS;

        string cadenaConexionBase;

        string cadenaConexionElClub;

        public string estadoDeConexion;

        public clsLogs()
        {
            try
            {
                cadenaConexionBase = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Resources\\BaseDatosUsuarios.accdb";

                cadenaConexionElClub = @"Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source = ..\\..\\Resources\\EL_CLUB.accdb";

                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = cadenaConexionBase;
                conexionBD.ConnectionString = cadenaConexionElClub;
                conexionBD.Open();

                objDS = new DataSet();

                estadoDeConexion = "Conectado";
            }
            catch (Exception error)
            {
                estadoDeConexion = error.Message;
            }
        }

        public void RegistroLogInicioSesionExitoso()
        {
            try
            {
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
                nuevoRegistro["Descripcion"] = "Inicio exitoso";

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

        public void ValidarUsuario(string nombreUsuario, string contraseñaUsuario)
        {
            try
            {
                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "Usuarios";

                lectorBD = comandoBD.ExecuteReader();

                if (lectorBD.HasRows)
                {
                    while (lectorBD.Read())
                    {
                        if (lectorBD[1].ToString() == nombreUsuario && lectorBD[2].ToString() == contraseñaUsuario)
                        {
                            estadoDeConexion = "Usuario EXISTE";
                        }
                    }
                }
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

        public void RegistroLogReestablecerContraseña()
        {
            try
            {
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
