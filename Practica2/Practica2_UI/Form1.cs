using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Practica2_UI
{
    public partial class Form1 : Form
    {
        private Algoritmia.Tree MyTree { get; set; }

        private DataTable Data { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Fichero de entrada",

                RestoreDirectory = true,
                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "csv",
                Filter = "csv files (*.csv)|*.csv",
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                toolStripStatusLabel1.Text = "Cargado fichero " + openFileDialog1.SafeFileName;
            }

            openFileDialog1.Dispose();
        }

        private void BtnCrearArbol_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text != "" && System.IO.File.Exists(textBox1.Text)))
                Helper.ShowMessage("Debe seleccionar un fichero antes de cargar el arbol");
            else
                try
                {
                    Data = null;
                    MyTree = null;

                    toolStripStatusLabel2.Text = "Cargando el arbol";
                    backgroundWorker1.RunWorkerAsync();
                }
                catch (Exception ex)
                {
                    Helper.TreatErrorException(ex);
                }
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (Data == null || MyTree == null)
                MessageBox.Show("Debe crear el arbol antes de poder consultarlo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (!(textBox1.Text != "" && System.IO.File.Exists(textBox1.Text)))
                MessageBox.Show("Debe cargar un fichero csv y crear el arbol antes de poder consultarlo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                try
                {
                    var valuesForQuery = new Dictionary<string, string>();

                    foreach (var item in Data.Columns)
                    {
                        if (Data.Columns.IndexOf((DataColumn)item) != Data.Columns.Count - 1)
                        {
                            string input = "";
                            input = Interaction.InputBox(string.Format("Introduzca el valor para el campo {0}", item.ToString()), "Entrada de datos",
                                "Valor", -1, -1);
                            valuesForQuery.Add(item.ToString(), input);
                        }
                    }

                    var resultado = Algoritmia.Tree.CalcularResultado(MyTree.Root, valuesForQuery, "");

                    label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    if (resultado == "Attributo no encontrado")
                    {
                        label1.ForeColor = Color.Red;
                        label1.Text = "Error";
                        MessageBox.Show("Se ha introducido una opción no válida y no ha sido posible realizar el cálculo.");
                    }
                    else
                    {
                        label1.ForeColor = SystemColors.ControlText;
                        label1.Text = (resultado.Split('>')[resultado.Split('>').Length - 1]).Trim();
                    }
                }
                catch (Exception ex) { Helper.TreatErrorException(ex); }
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (MyTree != null)
            {
                toolStripStatusLabel2.Text = "Creado el arbol";
            }
            else
            {
                toolStripStatusLabel2.Text = "Error al crear el arbol";
            }
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string input = "";

                if (textBox1.Text != "" && System.IO.File.Exists(textBox1.Text))
                {
                    input = textBox1.Text;
                    Data = ManejadorCSV.ImportFromCsvFile(input);
                }
                if (Data == null)
                {
                    Helper.TreatErrorMessage("Error importando el fichero csv.");
                }
                else
                {
                    MyTree = Algoritmia.Arbol.CreateTreeAndHandleUserOperation(Data);
                }
            }
            catch (Exception ex)
            {
                Helper.TreatErrorException(ex);
            }
        }

        private void BtnMostrarArbol_Click(object sender, EventArgs e)
        {
            if (Data == null || MyTree == null)
                MessageBox.Show("Debe crear el arbol antes de poder consultarlo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (!(textBox1.Text != "" && System.IO.File.Exists(textBox1.Text)))
                MessageBox.Show("Debe cargar un fichero csv y crear el arbol antes de poder consultarlo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                try
                {
                    string cadena = "";
                    cadena = Algoritmia.Tree.Print(MyTree.Root, MyTree.Root.Nombre.ToUpper());
                    label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    label1.Text = cadena;
                }
                catch (Exception ex) { Helper.TreatErrorException(ex); }
        }

    }
}