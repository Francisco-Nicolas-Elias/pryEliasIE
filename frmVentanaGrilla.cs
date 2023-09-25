using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryEliasIE
{
    public partial class frmVentanaGrilla : Form
    {
        public frmVentanaGrilla()
        {
            InitializeComponent();
        }

        public static string rutaArchivoGrilla;

        private void btnVolverVentanaGrilla_Click(object sender, EventArgs e)
        {
            frmVentanaPrincipal frmVentanaPrincipal = new frmVentanaPrincipal();
            frmVentanaPrincipal.Show();
            this.Close();

            dtvMostrarArchivo.Rows.Clear();
        }

        private void btnMostrarGrilla_Click(object sender, EventArgs e)
        {
            
        }

        private void frmVentanaGrilla_Load(object sender, EventArgs e)
        {

        }

        private void dtvMostrarArchivo_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void btnGrabarGrilla_Click(object sender, EventArgs e)
        {
            

            frmABM frmABM = new frmABM();
            frmABM.Show();
            this.Hide();
        }

        private void btnModificarGrilla_Click(object sender, EventArgs e)
        {
            int n = dtvMostrarArchivo.CurrentCell.RowIndex;

            frmABM frmABM = new frmABM();
               
            //El ReadOnly solo deja ver el contenido del txt no deja que se modifique
            frmABM.txtNumero.ReadOnly = true;
            frmABM.txtNumero.Text = dtvMostrarArchivo.Rows[n].Cells[0].Value.ToString();
            frmABM.txtEntidad.Text = dtvMostrarArchivo.Rows[n].Cells[1].Value.ToString();
            frmABM.txtApertura.Text = dtvMostrarArchivo.Rows[n].Cells[2].Value.ToString();
            frmABM.txtNumeroDeExpediente.Text = dtvMostrarArchivo.Rows[n].Cells[3].Value.ToString();
            frmABM.txtJuzgado.Text = dtvMostrarArchivo.Rows[n].Cells[4].Value.ToString();
            frmABM.txtJurisdiccion.Text = dtvMostrarArchivo.Rows[n].Cells[5].Value.ToString();
            frmABM.txtDireccion.Text = dtvMostrarArchivo.Rows[n].Cells[6].Value.ToString();
            frmABM.txtLiquidadorResponsable.Text = dtvMostrarArchivo.Rows[n].Cells[7].Value.ToString();

            string ID = Convert.ToString(dtvMostrarArchivo.Rows[n].Cells[0].Value);

            frmABM.Show();
            this.Hide();
        }

        private void btnBorrarGrilla_Click(object sender, EventArgs e)
        {
            //n es el número de fila seleccionado 
            int n = dtvMostrarArchivo.CurrentCell.RowIndex;

            if (n != -1)
            {               
                //ID es el número de la celda 0 de la fila seleccionada 
                string ID = Convert.ToString(dtvMostrarArchivo.Rows[n].Cells[0].Value);

                //Es una lista que funciona igual que un vector pero tiene métodos propios
                List<string> lineasArchivo = new List<string>();

                using (StreamReader reader = new StreamReader(rutaArchivoGrilla))
                {
                    // Lee y descarta la primera línea (encabezado)
                    reader.ReadLine();

                    // Lee el resto de las líneas
                    string linea;
                    while ((linea = reader.ReadLine()) != null)
                    {
                        // Procesa la línea actual aquí
                        string[] parametros = linea.Split(';');
                        //Copia todas las lineas que no coincide con el ID para sobreescribir el archivo sin la linea que quiero borrar
                        if (parametros[0] != ID)
                        {
                            lineasArchivo.Add(linea);
                        }                      
                    }
                }

                using (StreamWriter writer = new StreamWriter(rutaArchivoGrilla))
                {
                    foreach (string elemento in lineasArchivo)
                    {
                        writer.WriteLine(elemento); // Escribe cada elemento en una línea del archivo
                    }
                }

                MessageBox.Show("El registro fue eliminado correctamente.");

                dtvMostrarArchivo.Rows.RemoveAt(n);
            }
        }
    }
}
