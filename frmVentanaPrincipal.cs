using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace pryEliasIE
{
    public partial class frmVentanaPrincipal : Form
    {
        public frmVentanaPrincipal()
        {
            InitializeComponent();
            LlenarTreeView();

            this.trvMostrar.NodeMouseClick += new TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
        }

        public string rutaActual = "";

        private void LlenarTreeView()
        {
            TreeNode nodoMadre;

            DirectoryInfo directorioCarpeta = new DirectoryInfo(@"../../Resources/Proveedores y aseguradores");
            if (directorioCarpeta.Exists)
            {
                nodoMadre = new TreeNode(directorioCarpeta.Name);
                nodoMadre.Tag = directorioCarpeta;
                obtenerCarpetas(directorioCarpeta.GetDirectories(), nodoMadre);
                trvMostrar.Nodes.Add(nodoMadre);
            }
        }
        //Desde directorioCarpeta.GetDirectories() nos da todos los nombres de carpetas

        private void obtenerCarpetas(DirectoryInfo[] subDirs,TreeNode nodeToAddTo)
        {
            //aNode se utiliza para crear nodos para cada subcarpeta
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";

                //Recursiva - se llama a sí mismo para buscar más carpetas

                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    obtenerCarpetas(subSubDirs, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }
        
        void treeView1_NodeMouseClick(object sender,TreeNodeMouseClickEventArgs e)
        {
            //Guardo el nodo seleccionado en una variable de la clase TreeNode
            TreeNode nodoSeleccionado = e.Node;
            lstMostrar.Items.Clear();

            //Guardo el directorio del nodo seleccionado en una variable de la clase DirectoryInfo
            DirectoryInfo directorioNodoSeleccionado = (DirectoryInfo)nodoSeleccionado.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;
            
            //Foreach que recorre las carpetas dentro del directorio y
            //crea elementos para después mostrar los items (Carpetas) en la listView

            //También se agrega una etiqueta indicando que es un directorio y la fecha del último acceso del directorio
            foreach (DirectoryInfo carpetas in directorioNodoSeleccionado.GetDirectories())
            {
                item = new ListViewItem(carpetas.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[]
                    {new ListViewItem.ListViewSubItem(item, "Directory"),new ListViewItem.ListViewSubItem(item,carpetas.LastAccessTime.ToShortDateString())};
                item.SubItems.AddRange(subItems);
                lstMostrar.Items.Add(item);
            }
            
            //Foreach que recorre los archivos dentro del directorio y
            //crea elementos para después mostrar los items (Archivos) en la listView

            //También se agrega una etiqueta indicando que es un archivo y la fecha del último acceso del archivo
            foreach (FileInfo archivos in directorioNodoSeleccionado.GetFiles())
            {
                item = new ListViewItem(archivos.Name, 1);
                subItems = new ListViewItem.ListViewSubItem[]
                    { new ListViewItem.ListViewSubItem(item, "File"),new ListViewItem.ListViewSubItem(item,archivos.LastAccessTime.ToShortDateString())};

                item.SubItems.AddRange(subItems);
                lstMostrar.Items.Add(item);
            }
           
            //Ajusta el ancho de las columnas en la listView asi se ven los nombres de los archivos completos
            lstMostrar.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        

        private void btnSeleccionarCarpeta_Click(object sender, EventArgs e)
        {
            
        }

        private void frmVentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnGrabarArchivo_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVolverVentanaPrincipal_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.Show();
            this.Close();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            //Obtengo el texto que tiene el item seleccionado lstView
            string a = lstMostrar.SelectedItems[0].Text.ToString();       

            //En una variable concateno la ruta del nodo seleccionado en el treeview + el nombre del archivo 
            string rutaArchivoParcial = Path.Combine(rutaActual, a); 

            //Aca esta la ruta final del archivo
            string rutaArchivoFinal = Path.Combine(@"../../Resources", rutaArchivoParcial); 

            //Instanciar la ventana de la grilla
            frmVentanaGrilla frmVentanaGrilla = new frmVentanaGrilla(); 

            // Abre el archivo para lectura
            using (StreamReader reader = new StreamReader(rutaArchivoFinal))
            {
                // Lee y descarta la primera línea (encabezado)
                reader.ReadLine();

                // Lee el resto de las líneas
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    // Procesa la línea actual aquí
                    string[] parametros = linea.Split(';');
                    //agregar a la datagrid
                    frmVentanaGrilla.dtvMostrarArchivo.Rows.Add(parametros);
                }
            }

            frmVentanaGrilla.rutaArchivoGrilla = rutaArchivoFinal;

            frmVentanaGrilla.Show();
            this.Hide();
            
        }

        //Función para obtener la ruta completa del nodo seleccionado
        private string GetNodePath(TreeNode node)
        {
            //Recorre los nodos ascendentes para construir la ruta completa
            string rutaNodoSeleccionado = node.Text;
            TreeNode currentNode = node.Parent;

            while (currentNode != null)
            {
                rutaNodoSeleccionado = currentNode.Text + "\\" + rutaNodoSeleccionado;
                currentNode = currentNode.Parent;
            }

            return rutaNodoSeleccionado;
        }
        

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            //Obtener el nodo seleccionado
            TreeNode selectedNode = e.Node;

            //Actualizar la ruta actual con la ruta del nodo seleccionado
            rutaActual = GetNodePath(selectedNode);
        }
    }
}
