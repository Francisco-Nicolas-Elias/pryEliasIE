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

        string cadenaConexionBase = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Resources\\BaseDatosUsuarios.accdb";

        string cadenaConexionElClub = @"Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source = ..\\..\\Resources\\EL_CLUB.accdb";

        public string datosTabla = "";

        public string estadoConexion = "";

        public static bool acceso;

        public void ConectarBD()
        {
            conexionBD = new OleDbConnection();
            conexionBD.ConnectionString = cadenaConexionBase;
            conexionBD.Open();
        }

        public void BuscarUsuario()
        {
            conexionBD = new OleDbConnection();
            conexionBD.ConnectionString = cadenaConexionBase;
            conexionBD.Open();
            comandoBD = new OleDbCommand();

            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "Usuarios";

            lectorBD = comandoBD.ExecuteReader();

            if (lectorBD.HasRows)
            {

                while (lectorBD.Read())
                {
                    string usuarioBD = lectorBD[1].ToString();
                    string contraseñaBD = lectorBD[2].ToString();

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

        public void ConectarBDElClub()
        {
            try
            {
                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = cadenaConexionElClub;
                conexionBD.Open();
                estadoConexion = "Conectado";

            }
            catch (Exception EX)
            {
                estadoConexion = "Error:" + EX.Message;
            }
        }

        public void TraerDatosElClub()
        {
            comandoBD = new OleDbCommand();

            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "SOCIOS";

            lectorBD = comandoBD.ExecuteReader();

            if (lectorBD.HasRows)
            {
                while (lectorBD.Read())
                {
                    datosTabla += "-" + lectorBD[0]; //El 0 muestra la primer columna(Los ID)
                }
            }
        }

        public void TraerDatosElClub(DataGridView grilla)
        {
            comandoBD = new OleDbCommand();

            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "SOCIOS";

            lectorBD = comandoBD.ExecuteReader();

            grilla.Columns.Add("Nombre", "Nombre");
            grilla.Columns.Add("Apellido", "Apellido");
            grilla.Columns.Add("Nacionalidad", "Nacionalidad");
            grilla.Columns.Add("Edad", "Edad");
            grilla.Columns.Add("Ingreso", "Ingreso");
            grilla.Columns.Add("Puntaje", "Puntaje");


            if (lectorBD.HasRows)
            {
                while (lectorBD.Read())
                {
                    datosTabla += "-" + lectorBD[0] ; //El 0 muestra la primer columna(Los ID)
                    grilla.Rows.Add(lectorBD[1], lectorBD[2], lectorBD[3], lectorBD[4], lectorBD[6], lectorBD[7]);
                }
            }            
        }

        public void BuscarPorCodigoDatosElClub(int codigoSocio)
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
                        MessageBox.Show("Cliente existe", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void BuscarPorApellidoDatosElClub(string apellidoSocio)
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
                    if (lectorBD[3].ToString() == apellidoSocio)
                    {
                        MessageBox.Show("Cliente existe", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

    }
}
