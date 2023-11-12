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
        //Creo una instancia de la clase OleDbConnection, que utilizaré para establecer la conexión con la base de datos 
        OleDbConnection conexionBD = new OleDbConnection();

        //Creo una instancia de la clase OleDbCommand que sirve para enviar comandos a la base de datos, consultas, actualizaciones, etc
        OleDbCommand comandoBD = new OleDbCommand(); 

        //Declaro una variable de tipo OleDbDataReader que voy a utilizar para leer un conjunto de datos obtenidos de la base de datos 
        OleDbDataReader lectorBD;

        //Declaro una variable de tipo OleDbDataAdapter que voy a utilizar para llenar un conjunto de datos (Ej: DataSet) y 
        //actualizar la base de datos con los cambios realizados en dicho conjunto
        OleDbDataAdapter adaptadorBD;

        //Delaro una variable de tipo DataSet que voy a utilizar como contenedor de datos de las tablas de la base de datos 
        DataSet objDS;

        string cadenaConexionBase = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Resources\\BaseDatosUsuarios.accdb";

        string cadenaConexionElClub = @"Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source = ..\\..\\Resources\\EL_CLUB.accdb";

        public string estadoConexion = "";

        public static bool acceso;

        public clsLogin()
        {
            try
            {
                //Creo una nueva instancia de la clase OleDbConecction
                conexionBD = new OleDbConnection();

                //Establezco la cadena de conexión del objeto creado 
                conexionBD.ConnectionString = cadenaConexionElClub;

                //Abro la conexión con la base de datos 
                conexionBD.Open();

                //Creo una instancia de la clase DataSet que voy a usar para contener datos 
                objDS = new DataSet();

                estadoConexion = "Conectado";
            }
            catch (Exception error)
            {
                estadoConexion = error.Message;
            }

            //Creo las instancias para la conexión y el comando.
            conexionBD = new OleDbConnection();
            comandoBD = new OleDbCommand();
        }

        public void ConectarBD()
        {
            try
            {
                //Establezco la cadena de conexión con la base de datos 
                conexionBD.ConnectionString = cadenaConexionBase;
                //Abro la conexión con la base de datos 
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
            string estadoCliente = "";
            string sexo = "";

            try
            { 
                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "SOCIOS";

                //Ejecuto un comando y creo un lector de datos para leer los resultados 
                lectorBD = comandoBD.ExecuteReader();

                grilla.Columns.Add("ID", "ID");
                grilla.Columns.Add("Nombre", "Nombre");
                grilla.Columns.Add("Apellido", "Apellido");
                grilla.Columns.Add("Nacionalidad", "Nacionalidad");
                grilla.Columns.Add("Edad", "Edad");
                grilla.Columns.Add("Sexo", "Sexo");
                grilla.Columns.Add("Ingreso", "Ingreso");
                grilla.Columns.Add("Puntaje", "Puntaje");
                grilla.Columns.Add("Estado", "Estado");

                if (lectorBD.HasRows)
                {
                    while (lectorBD.Read())
                    {
                        if (lectorBD.GetBoolean(8) == true)
                        {
                            estadoCliente = "Activo";
                        }
                        else
                        {
                            estadoCliente = "Inactivo";
                        }
                        
                        if (lectorBD.GetBoolean(5) == true)
                        {
                            sexo = "Masculino";
                        }
                        else
                        {
                            sexo = "Femenino";
                        }

                        grilla.Rows.Add(lectorBD[0], lectorBD[1], lectorBD[2], lectorBD[3], lectorBD[4], sexo, lectorBD[6], lectorBD[7], estadoCliente);   
                        
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

                //Ejecuto la lectura de la tabla y almaceno su contenido en el dataSet
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

        public void ModificarEstadoSocio(int id)
        {

            //Creo una instancia de la clase OleDbCommand, que voy a utilizar para mandar comandos a la base
            OleDbCommand comandoBD = new OleDbCommand();

            //Declaro una variable de tipo OleDbDataAdapter para luego llenar un conjunto de datos (objDataSet) con datos de la base de datos 
            OleDbDataAdapter objAdaptador;

            //Creo una instancia de la clase DataSet, que usaré como contenedor de los datos de la base de datos 
            DataSet objDataSet = new DataSet();

            try
            {
                //Creo una instancia de la clase OleDbConecction que representa una conexión a la base de datos 
                conexionBD = new OleDbConnection();

                //Establezco la cadena de conexión
                conexionBD.ConnectionString = cadenaConexionElClub;

                //Abro la conexión a la base de datos
                conexionBD.Open();
                
                //Si abre correctamente estadoConexion va a valer "Conectado"
                estadoConexion = "Conectado";

            }
            catch (Exception ex)
            {
                //Si no se logra la conexión estadoConexión va a valer "Error"
                estadoConexion = "Error" + ex.Message;
            }

            //Establezco la conexión, para que cuando se ejecute el comando lo opere en la base de datos que debe hacerse
            comandoBD.Connection = conexionBD;

            //Establezco el tipo de comando, con este comando le indico que voy a modificar una tabla en específica
            comandoBD.CommandType = CommandType.TableDirect;

            //Le digo que tabla es la que se va a modificar 
            comandoBD.CommandText = "SOCIOS";

            //Creo el objeto DataAdapter pasando como parámetro el objeto comando que quiero vincular
            objAdaptador = new OleDbDataAdapter(comandoBD);

            //Ejecuto la lectura de la tabla y almaceno su contenido en el dataSet
            objAdaptador.Fill(objDataSet, "SOCIOS");

            //Obtengo la referencia a la tabla del conjunto de datos 
            DataTable dt = objDataSet.Tables["SOCIOS"];

            //Itero sobre cada fila de la tabla
            foreach (DataRow registro in dt.Rows)
            { 
                //Comparo si el valor de la columna código socio es igual al id ingresado por el usuario
                if ((int)registro["CODIGO_SOCIO"] == id)
                {
                    //Comienzo a editar la fila 
                    registro.BeginEdit();

                    //Cambio el valor de true a false o viceversa dependiendo el estado actual del socio
                    if ((bool)registro["ESTADO"])
                    {
                        registro["ESTADO"] = false;
                    }
                    else
                    {
                        registro["ESTADO"] = true;
                    }

                    //Finalizo la edición de la fila 
                    registro.EndEdit();

                    //Salgo del bucle después de modificar al socio
                    break;
                }
            }

            //Creo un constructor de comandos para actualizar la base de datos con las nuevas actualizaciones 
            OleDbCommandBuilder constructor = new OleDbCommandBuilder(objAdaptador);

            //Actualiza la base de datos con los cambios realizados 
            objAdaptador.Update(objDataSet, "SOCIOS");

            MessageBox.Show("¡Estado cambiado con éxito!");
        }

        public void ReestablecerContraseña(string usuario)
        {

            OleDbCommand comandoBD = new OleDbCommand();
            OleDbDataAdapter objAdaptador;
            DataSet objDataSet = new DataSet();

            try
            {
                ConectarBD();
                estadoConexion = "Conectado";

            }
            catch (Exception ex)
            {
                estadoConexion = "Error" + ex.Message;
            }

            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = CommandType.TableDirect;
            comandoBD.CommandText = "Usuarios";

            objAdaptador = new OleDbDataAdapter(comandoBD);

            objAdaptador.Fill(objDataSet, "USUARIOS");


            DataTable dt = objDataSet.Tables["USUARIOS"];


            foreach (DataRow registro in dt.Rows)
            {

                if (registro["Usuario"].ToString() == usuario)
                {
                    registro.BeginEdit();

                    registro["Contraseña"] = frmReestablecerContraseña.contraseñasIguales;

                    registro.EndEdit();
                    break;
                }
            }
            OleDbCommandBuilder constructor = new OleDbCommandBuilder(objAdaptador);

            objAdaptador.Update(objDataSet, "Usuarios");

        }
    }
}
