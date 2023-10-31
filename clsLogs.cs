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
        /*
        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataReader lectorBD;

        OleDbDataAdapter adaptadorBD;
        DataSet objDS = new DataSet();

        string cadenaConexionBase;

        string cadenaConexionElClub;

        public string estadoDeConexion;
        */

        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataAdapter objDataAdap;
        DataSet objDataSet = new DataSet();

        public clsLogs()
        {
            /*
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
            */

            // Constructor para inicializar la conexión y el comando.
            conexionBD = new OleDbConnection();
            comandoBD = new OleDbCommand();
        }

        public void ConectarBD()
        {
            try
            {
                string conexion = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Resources\\BaseDatosUsuarios.accdb";
                string cadenaConexionElClub = @"Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source = ..\\..\\Resources\\EL_CLUB.accdb";
                conexionBD.ConnectionString = conexion;
                conexionBD.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        public void RegistroLogInicioSesionExitoso()
        {
            ConectarBD();
            comandoBD = new OleDbCommand();

            comandoBD.Connection = conexionBD;


            // Establece el tipo de comando y la tabla
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            //Que tabla traigo
            comandoBD.CommandText = "Logs";
            // crear el objeto DataAdapter pasando como parámetro el objeto comando que queremos vincular
            objDataAdap = new OleDbDataAdapter(comandoBD);
            // ejecutar la lectura de la tabla y almacenar su contenido en el dataAdapter
            objDataAdap.Fill(objDataSet, "Logs");
            // obtenemos una referencia a la tabla


            DataTable dt = objDataSet.Tables["Logs"];

            // creamos el nuevo DataRow con la estructura de campos de la tabla
            DataRow dr = dt.NewRow();
            // asignamos los valores a todos los campos del DataRow
            dr["Categoria"] = "Inicio Sesión";
            dr["FechaHora"] = DateTime.Now;
            dr["Descripcion"] = "Inicio exitoso";

            // agregamos el DataRow a la tabla

            dt.Rows.Add(dr);

            // creamos el objeto OledBCommandBuilder pasando como parámetro el DataAdapter
            OleDbCommandBuilder cb = new OleDbCommandBuilder(objDataAdap);

            // actualizamos la base con los cambios realizados
            objDataAdap.Update(objDataSet, "Logs");
            conexionBD.Close();
        }
        /*
        public void RegistroLogInicioSesionExitoso()
        {
            try
            {  
                conexionBD = new OleDbConnection();
                comandoBD = new OleDbCommand();
                conexionBD.Open();

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
                conexionBD = new OleDbConnection();
                comandoBD = new OleDbCommand();
                conexionBD.Open();

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
                conexionBD = new OleDbConnection();
                
                comandoBD = new OleDbCommand();

                

                conexionBD.Open();


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
                conexionBD = new OleDbConnection();
                comandoBD = new OleDbCommand();
                conexionBD.Open();

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
                conexionBD = new OleDbConnection();
                comandoBD = new OleDbCommand();
                conexionBD.Open();

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
        */
    }
}
