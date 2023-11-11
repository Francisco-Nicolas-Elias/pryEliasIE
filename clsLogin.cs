using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;
using System.Security.Policy;

namespace pryEliasIE
{
    internal class clsLogin
    {
        OleDbConnection conexionBD = new OleDbConnection();
        OleDbCommand comandoBD = new OleDbCommand(); //Sirve para datos, editar y borrar 
        OleDbDataReader lectorBD;

        OleDbDataAdapter adaptadorBD;

        DataSet objDS;

        string cadenaConexionBase = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Resources\\BaseDatosUsuarios.accdb";

        string cadenaConexionElClub = @"Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source = ..\\..\\Resources\\EL_CLUB.accdb";

        public string datosTabla = "";

        public string estadoConexion = "";

        public static bool acceso;

        public clsLogin()
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

                estadoConexion = "Conectado";
            }
            catch (Exception error)
            {
                estadoConexion = error.Message;
            }

            // Constructor para inicializar la conexión y el comando.
            conexionBD = new OleDbConnection();
            comandoBD = new OleDbCommand();
        }

        public void ConectarBD()
        {
            try
            {
                conexionBD.ConnectionString = cadenaConexionBase;
                conexionBD.Open();
            }
            catch(Exception error)
            {
                MessageBox.Show(Convert.ToString(error));
            }
        }

        public void BuscarUsuario()
        {
            try
            {
                ConectarBD();

                //Creo una instancia de la clase OleDbCommand para ejecutar los comandos en la base de datos 
                comandoBD = new OleDbCommand();

                //Establezco la conexión, para que cuando se ejecute el comando lo opere en la base de datos que debe hacerse
                comandoBD.Connection = conexionBD;

                //Establezco el tipo de comando, con este comando le indico que voy a leer una tabla en específica
                comandoBD.CommandType = System.Data.CommandType.TableDirect;

                //Le digo que tabla es la que se va a leer
                comandoBD.CommandText = "Usuarios";

                //Ejecuto el comando y leo la los resultados de la consulta
                lectorBD = comandoBD.ExecuteReader();

                //Si tiene filas quiere decir que hay datos 
                if (lectorBD.HasRows)
                {
                    while (lectorBD.Read())
                    {
                        //Almaceno los datos del registro que estoy leyendo en dos variables
                        //Columna[1] (campo Usuario), columna[2] (campo Contraseña)
                        string usuarioBD = lectorBD[1].ToString();
                        string contraseñaBD = lectorBD[2].ToString();

                        //Si las variables del formulario inicio sesión donde esta guardado el usuario
                        //y la contraseña que ingreso el usuario son iguales entonces
                        //la variable booleana acceso va a ser verdadera y rompo el bucle
                        if (usuarioBD == frmLogin.usuario & contraseñaBD == frmLogin.contraseña)
                        {
                            acceso = true;
                            break;
                        }
                        else
                        {
                            acceso = false;
                        }
                    }
                }
            }
            catch (Exception error)
            {
                estadoConexion = error.Message;
            }
        }

        public void ConectarBDElClub()
        {
            try
            {
                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = cadenaConexionElClub;
                conexionBD.Open();
                estadoConexion = "Conectado";
            }
            catch (Exception error)
            {
                estadoConexion = "Error:" + error.Message;
            }
        }

        public void TraerDatosElClub(DataGridView grilla)
        {
            try
            { 
                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "SOCIOS";

                lectorBD = comandoBD.ExecuteReader();

                grilla.Columns.Add("ID", "ID");
                grilla.Columns.Add("Nombre", "Nombre");
                grilla.Columns.Add("Apellido", "Apellido");
                grilla.Columns.Add("Nacionalidad", "Nacionalidad");
                grilla.Columns.Add("Edad", "Edad");
                grilla.Columns.Add("Ingreso", "Ingreso");
                grilla.Columns.Add("Puntaje", "Puntaje");
                grilla.Columns.Add("Estado activo", "Estado activo");
                

                if (lectorBD.HasRows)
                {
                    while (lectorBD.Read())
                    {
                        datosTabla += "-" + lectorBD[0] ; //El 0 muestra la primer columna(Los ID)
                        grilla.Rows.Add(lectorBD[0],lectorBD[1], lectorBD[2], lectorBD[3], lectorBD[4], lectorBD[6], lectorBD[7], lectorBD[8]);
                    }
                }
            }
            catch (Exception error)
            {
                estadoConexion = "Error:" + error.Message;
            }
        }

        public void BuscarPorCodigoDatosElClub(int codigoSocio)
        {
            try
            { 
                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "SOCIOS";

                lectorBD = comandoBD.ExecuteReader();

                bool seEncuentra = false;

                if (lectorBD.HasRows)
                {
                    while (lectorBD.Read())
                    {
                        if (int.Parse(lectorBD[0].ToString()) == codigoSocio)
                        {
                            MessageBox.Show("Cliente existente: \n" + lectorBD[1].ToString() + " " + lectorBD[2].ToString(), "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            seEncuentra = true;
                            break;
                        }
                    }

                    if (seEncuentra == false)
                    {
                        MessageBox.Show("Cliente no existe", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception error)
            {
                estadoConexion = "Error:" + error.Message;
            }
        }

        public void BuscarPorApellidoDatosElClub(string apellidoSocio)
        {
            try
            {
                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "SOCIOS";

                lectorBD = comandoBD.ExecuteReader();

                bool seEncuentra = false;

                if (lectorBD.HasRows)
                {
                    while (lectorBD.Read())
                    {
                        if (lectorBD[2].ToString() == apellidoSocio)
                        {
                            MessageBox.Show("Cliente existente: \n" + lectorBD[1].ToString() + " " + lectorBD[2].ToString(), "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            seEncuentra = true;
                            break;
                        }
                    }

                    if (seEncuentra == false)
                    {
                        MessageBox.Show("Cliente no existe", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception error)
            {
                estadoConexion = "Error:" + error.Message;
            }
        }

        public void CrearCuenta()
        {
            try
            {
                ConectarBD();

                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;

                //Establezco el tipo de comando, con este comando le indico que voy a trabajar con una tabla específica
                comandoBD.CommandType = System.Data.CommandType.TableDirect;

                //Le digo que tabla quiero traer
                comandoBD.CommandText = "Usuarios";

                //Creo el objeto DataAdapter pasando como parámetro el objeto comando que quiero vincular
                adaptadorBD = new OleDbDataAdapter(comandoBD);

                //Ejecuto la lectura de la tabla y almaceno su contenido en el dataAdapter
                adaptadorBD.Fill(objDS, "Usuarios");

                //Obtengo una referencia a la tabla

                DataTable objTabla = objDS.Tables["Usuarios"];

                //Creo el nuevo DataRow con la estructura de campos de la tabla de la cual quiero traer los datos
                DataRow nuevoRegistro = objTabla.NewRow();

                //Asigno los valores a todos los campos del DataRow
                nuevoRegistro["Usuario"] = frmCrearCuenta.usuarioCrearCuenta;               
                nuevoRegistro["Contraseña"] = frmCrearCuenta.lasContraseñasSonIguales;
                nuevoRegistro["Perfil"] = frmCrearCuenta.perfilCrearCuenta;

                //Agrego el DataRow a la tabla
                objTabla.Rows.Add(nuevoRegistro);


                //Creo el objeto OledBCommandBuilder pasando como parámetro el DataAdapter
                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);

                //Actualizo la base con los cambios realizados
                adaptadorBD.Update(objDS, "Usuarios");

                estadoConexion = "Cuenta creada con éxito";
            }
            catch (Exception error)
            {
                estadoConexion = error.Message;
            }
        }
        
        public void ReestablecerContraseña()
        {
            try
            {
                string usuario = frmReestablecerContraseña.usuarioReestablecerContraseña;
                string contraseña = frmReestablecerContraseña.contraseñasIguales;

                string sql = "";

                sql = "UPDATE Usuarios SET Contraseña = contraseña WHERE Usuario = usuario" ;

                ConectarBD();

                comandoBD = new OleDbCommand();

                comandoBD.Parameters.AddWithValue("contraseña", frmReestablecerContraseña.contraseñasIguales);
                comandoBD.Parameters.AddWithValue("usuario", frmReestablecerContraseña.usuarioReestablecerContraseña);

                int filasAfectadas = comandoBD.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Registro actualizado correctamente.");
                }

                estadoConexion = "Contraseña reestablecida con éxito";
            }
            catch(Exception error)
            {
                estadoConexion = "Error:" + error.Message;
            }
        }

        public void ModificarEstadoActivo(int id)
        {
            OleDbCommand comandoBD = new OleDbCommand();
            OleDbDataAdapter adaptadorBD;
            DataSet objDataSet = new DataSet();

            try
            {
                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = cadenaConexionElClub;
                conexionBD.Open();
                estadoConexion = "Conectado";

            }
            catch (Exception ex)
            {
                estadoConexion = "Error" + ex.Message;
            }

            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = CommandType.TableDirect;
            comandoBD.CommandText = "SOCIOS";

            adaptadorBD = new OleDbDataAdapter(comandoBD);

            adaptadorBD.Fill(objDataSet, "SOCIOS");

            DataTable objTabla = objDataSet.Tables["SOCIOS"];

            foreach (DataRow registro in objTabla.Rows)
            {

                if ((int)registro["CODIGO_SOCIO"] == id)
                {
                    registro.BeginEdit();

                    if ((bool)registro["ESTADO"])
                    {
                        registro["ESTADO"] = false;
                    }
                    else
                    {
                        registro["ESTADO"] = true;
                    }

                    registro.EndEdit();
                    break;
                }
            }

            OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);

            adaptadorBD.Update(objDS, "SOCIOS");

            MessageBox.Show("¡Estado cambiado con éxito!");
        }
    }
}
