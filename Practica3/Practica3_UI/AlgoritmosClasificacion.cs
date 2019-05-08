using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Algoritmia;

namespace Practica3_UI
{
    public partial class AlgoritmosClasificacion : Form
    {
        private string RutaFichero;
        private List<Algoritmia.Clase> Data;
        private List<Algoritmia.Muestra> Muestras;
        private Algoritmia.Kmedias Kmedias;
        private Algoritmia.Bayes Bayes;
        private Algoritmia.Lloyd Lloyd;

        public AlgoritmosClasificacion()
        {
            InitializeComponent();
        }

        private void btnCargarFichero_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog
                {
                    Title = "Fichero de entrada",

                    RestoreDirectory = true,
                    CheckFileExists = true,
                    CheckPathExists = true,

                    DefaultExt = "txt",
                    Filter = "txt files (*.txt)|*.txt|csv files (*.csv)|*.csv",
                };

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    CargaFichero(openFileDialog1.FileName);

                openFileDialog1.Dispose();
            }
            catch (Exception ex)
            {
                Helper.TreatErrorException(ex);
            }
        }

        private void CargaFichero(string fileName)
        {
            try
            {
                if (!System.IO.File.Exists(fileName))
                    Helper.ShowMessage("Debe seleccionar un fichero existente.");
                else
                {
                    this.RutaFichero = fileName;
                    this.Cursor = Cursors.WaitCursor;
                    bwCargarFichero.RunWorkerAsync();
                }
            }
            catch (Exception ex)
            {
                Helper.TreatErrorException(ex);
            }
        }

        private void bwCargarFichero_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (System.IO.File.Exists(RutaFichero))
                    Data = ManejadorCSV.ImportFromCsvFile(RutaFichero, out Muestras);

                if (Data == null)
                    Helper.TreatErrorMessage("Error importando el fichero.");
            }
            catch (Exception ex)
            {
                Helper.TreatErrorException(ex);
            }
        }

        private void bwCargarFichero_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Cursor = Cursors.Default;
            this.btnKmediasEntrenar.Enabled = true;
            this.btnBayesEntrenar.Enabled = true;
            this.btnLloydEntrenar.Enabled = true;
            this.btnTodosEntrenar.Enabled = true;
        }

        private void btnKmediasFichero_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog
                {
                    Title = "Fichero de entrada",

                    RestoreDirectory = true,
                    CheckFileExists = true,
                    CheckPathExists = true,

                    DefaultExt = "txt",
                    Filter = "txt files (*.txt)|*.txt|csv files (*.csv)|*.csv",
                };

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    ManejadorCSV.LeerMuestra(openFileDialog1.FileName, txtKmediasFichero, txtKmediasMuestra1, txtKmediasMuestra2, txtKmediasMuestra3, txtKmediasMuestra4);

                openFileDialog1.Dispose();
            }
            catch (Exception ex)
            {
                Helper.TreatErrorException(ex);
            }
        }

        private void btnBayesFichero_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog
                {
                    Title = "Fichero de entrada",

                    RestoreDirectory = true,
                    CheckFileExists = true,
                    CheckPathExists = true,

                    DefaultExt = "txt",
                    Filter = "txt files (*.txt)|*.txt|csv files (*.csv)|*.csv",
                };

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    ManejadorCSV.LeerMuestra(openFileDialog1.FileName, txtBayesFichero, txtBayesMuestra1, txtBayesMuestra2, txtBayesMuestra3, txtBayesMuestra4);

                openFileDialog1.Dispose();
            }
            catch (Exception ex)
            {
                Helper.TreatErrorException(ex);
            }
        }

        private void btnLloydFichero_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog
                {
                    Title = "Fichero de entrada",

                    RestoreDirectory = true,
                    CheckFileExists = true,
                    CheckPathExists = true,

                    DefaultExt = "txt",
                    Filter = "txt files (*.txt)|*.txt|csv files (*.csv)|*.csv",
                };

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    ManejadorCSV.LeerMuestra(openFileDialog1.FileName, txtLloyFichero, txtLloydMuestra1, txtLloydMuestra2, txtLloydMuestra3, txtLloydMuestra4);

                openFileDialog1.Dispose();
            }
            catch (Exception ex)
            {
                Helper.TreatErrorException(ex);
            }
        }

        private void btnKmediasEntrenar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Data == null || Data.Count == 0)
                    Helper.ShowMessage("Debe cargar un fichero para realizar el entrenamiento.");
                else
                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        bwKmedias.RunWorkerAsync();
                    }
                    catch (Exception ex)
                    {
                        Helper.TreatErrorException(ex);
                    }
            }
            catch (Exception ex)
            {
                Helper.TreatErrorException(ex);
            }
        }

        private void btnBayesEntrenar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Data == null || Data.Count == 0)
                    Helper.ShowMessage("Debe cargar un fichero para realizar el entrenamiento.");
                else
                {
                    this.Cursor = Cursors.WaitCursor;
                    bwBayes.RunWorkerAsync();
                }
            }
            catch (Exception ex)
            {
                Helper.TreatErrorException(ex);
            }
        }

        private void btnLloydEntrenar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Data == null || Data.Count == 0)
                    Helper.ShowMessage("Debe cargar un fichero para realizar el entrenamiento.");
                else
                {
                    this.Cursor = Cursors.WaitCursor;
                    bwLloyd.RunWorkerAsync();
                }
            }
            catch (Exception ex)
            {
                Helper.TreatErrorException(ex);
            }
        }

        private void btnEntrenarTodos_Click(object sender, EventArgs e)
        {
            try
            {
                if (Data == null || Data.Count == 0)
                    Helper.ShowMessage("Debe cargar un fichero para realizar el entrenamiento.");
                else
                {
                    this.Cursor = Cursors.WaitCursor;
                    bwKmedias.RunWorkerAsync();
                    bwBayes.RunWorkerAsync();
                    bwLloyd.RunWorkerAsync();
                }
            }
            catch (Exception ex)
            {
                Helper.TreatErrorException(ex);
            }
        }

        private List<Clase> CopiarDatos(List<Clase> data)
        {
            List<Clase> resultado = new List<Clase>();

            foreach (var item in data)
            {
                Clase nueva = new Clase();
                nueva.Nombre = item.Nombre;
                nueva.Centro = new Muestra();
                foreach (var item2 in item.Centro.Medidas)
                {
                    nueva.Centro.Medidas.Add(item2);
                }
                resultado.Add(nueva);
            }

            return resultado;
        }

        private void bwKmedias_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Kmedias = new Algoritmia.Kmedias()
                {
                    Tolerancia = float.Parse(txtKmediasTolerancia.Text.Replace('.', ',')),
                    PesoExponencialB = float.Parse(txtKmediasb.Text.Replace('.', ',')),
                    Centros = new List<Algoritmia.Muestra>() {
                    new Algoritmia.Muestra() {
                        Medidas = new List<double>() {
                            double.Parse(txtClase1Centro1.Text.Replace('.', ',')),
                            double.Parse(txtClase1Centro2.Text.Replace('.', ',')),
                            double.Parse(txtClase1Centro3.Text.Replace('.', ',')),
                            double.Parse(txtClase1Centro4.Text.Replace('.', ','))
                        }
                    },
                    new Algoritmia.Muestra() {
                        Medidas = new List<double>() {
                            double.Parse(txtClase2Centro1.Text.Replace('.', ',')),
                            double.Parse(txtClase2Centro2.Text.Replace('.', ',')),
                            double.Parse(txtClase2Centro3.Text.Replace('.', ',')),
                            double.Parse(txtClase2Centro4.Text.Replace('.', ','))
                        }
                    }
                },
                    Datos = CopiarDatos(Data),
                    Muestras = this.Muestras
                };
                Kmedias.Entrenar();
            }
            catch (Exception ex)
            {
                Helper.TreatErrorException(ex);
            }
        }

        private void bwKmedias_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Cursor = Cursors.Default;
            this.gbKmedias.Enabled = true;
        }

        private void bwBayes_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Bayes = new Algoritmia.Bayes()
                {
                    Centros = new List<Algoritmia.Muestra>() {
                    new Algoritmia.Muestra() {
                        Medidas = new List<double>() {
                            double.Parse(txtClase1Centro1.Text.Replace('.', ',')),
                            double.Parse(txtClase1Centro2.Text.Replace('.', ',')),
                            double.Parse(txtClase1Centro3.Text.Replace('.', ',')),
                            double.Parse(txtClase1Centro4.Text.Replace('.', ','))
                        }
                    },
                    new Algoritmia.Muestra() {
                        Medidas = new List<double>() {
                            double.Parse(txtClase2Centro1.Text.Replace('.', ',')),
                            double.Parse(txtClase2Centro2.Text.Replace('.', ',')),
                            double.Parse(txtClase2Centro3.Text.Replace('.', ',')),
                            double.Parse(txtClase2Centro4.Text.Replace('.', ','))
                        }
                    }
                },
                    Datos = CopiarDatos(Data),
                    Muestras = this.Muestras
                };
                Bayes.Entrenar();
            }
            catch (Exception ex)
            {
                Helper.TreatErrorException(ex);
            }
        }

        private void bwBayes_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Cursor = Cursors.Default;
            this.gbBayes.Enabled = true;
        }

        private void bwLloyd_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Lloyd = new Algoritmia.Lloyd()
                {
                    Tolerancia = float.Parse(txtLloydTolerancia.Text.Replace('.', ',')),
                    Iteraciones = int.Parse(txtLloydIteraciones.Text),
                    Aprendizaje = float.Parse(txtLloydAprendizaje.Text.Replace('.', ',')),
                    Centros = new List<Algoritmia.Muestra>() {
                    new Algoritmia.Muestra() {
                        Medidas = new List<double>() {
                            double.Parse(txtClase1Centro1.Text.Replace('.', ',')),
                            double.Parse(txtClase1Centro2.Text.Replace('.', ',')),
                            double.Parse(txtClase1Centro3.Text.Replace('.', ',')),
                            double.Parse(txtClase1Centro4.Text.Replace('.', ','))
                        }
                    },
                    new Algoritmia.Muestra() {
                        Medidas = new List<double>() {
                            double.Parse(txtClase2Centro1.Text.Replace('.', ',')),
                            double.Parse(txtClase2Centro2.Text.Replace('.', ',')),
                            double.Parse(txtClase2Centro3.Text.Replace('.', ',')),
                            double.Parse(txtClase2Centro4.Text.Replace('.', ','))
                        }
                    }
                },
                    Datos = CopiarDatos(Data),
                    Muestras = this.Muestras
                };
                Lloyd.Entrenar();
            }
            catch (Exception ex)
            {
                Helper.TreatErrorException(ex);
            }
        }

        private void bwLloyd_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Cursor = Cursors.Default;
            this.gbLloyd.Enabled = true;
        }

        private void bwKmedias_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void bwBayes_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void bwLloyd_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void btnKmediasComprobar_Click(object sender, EventArgs e)
        {
            try
            {
                Algoritmia.Muestra MuestraComprobar = new Algoritmia.Muestra()
                {
                    Medidas = new List<double>() {
                            double.Parse(txtKmediasMuestra1.Text.Replace('.', ',')),
                            double.Parse(txtKmediasMuestra2.Text.Replace('.', ',')),
                            double.Parse(txtKmediasMuestra3.Text.Replace('.', ',')),
                            double.Parse(txtKmediasMuestra4.Text.Replace('.', ','))
                        }
                };

                lblKmediasResultado.Text = Kmedias.Clasificar(MuestraComprobar);
            }
            catch (Exception ex)
            {
                Helper.TreatErrorException(ex);
            }
        }

        private void btnBayesComprobar_Click(object sender, EventArgs e)
        {
            try
            {
                Algoritmia.Muestra MuestraComprobar = new Algoritmia.Muestra()
                {
                    Medidas = new List<double>() {
                            double.Parse(txtBayesMuestra1.Text.Replace('.', ',')),
                            double.Parse(txtBayesMuestra2.Text.Replace('.', ',')),
                            double.Parse(txtBayesMuestra3.Text.Replace('.', ',')),
                            double.Parse(txtBayesMuestra4.Text.Replace('.', ','))
                        }
                };

                lblBayesResultado.Text = Bayes.Clasificar(MuestraComprobar);
            }
            catch (Exception ex)
            {
                Helper.TreatErrorException(ex);
            }
        }

        private void btnLloydComprobar_Click(object sender, EventArgs e)
        {
            try
            {
                Algoritmia.Muestra MuestraComprobar = new Algoritmia.Muestra()
                {
                    Medidas = new List<double>() {
                            double.Parse(txtLloydMuestra1.Text.Replace('.', ',')),
                            double.Parse(txtLloydMuestra2.Text.Replace('.', ',')),
                            double.Parse(txtLloydMuestra3.Text.Replace('.', ',')),
                            double.Parse(txtLloydMuestra4.Text.Replace('.', ','))
                        }
                };

                lblLloydResultado.Text = Lloyd.Clasificar(MuestraComprobar);
            }
            catch (Exception ex)
            {
                Helper.TreatErrorException(ex);
            }
        }
    }
}