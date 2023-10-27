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

        string cadenaConexion = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Resources\\BaseDatosUsuarios.accdb";

        public string datosTabla = "";

        public static bool acceso;

        public void ConectarBD()
        {
            conexionBD = new OleDbConnection();
            conexionBD.ConnectionString = cadenaConexion;
            conexionBD.Open();
        }

        public void BuscarUsuario()
        {
            conexionBD = new OleDbConnection();
            conexionBD.ConnectionString = cadenaConexion;
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

    }
}
