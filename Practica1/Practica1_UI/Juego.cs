using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1_UI
{
    public partial class Juego : Form
    {
        private int _inicio;
        private int _meta;
        private Algoritmia.AEstrellaResultado _resultado = null;
        private int _pasos;
        private int _actual;
        private double _coste;
        private Algoritmia.Punto[,] _mapa = null;
        private List<Algoritmia.Coordenada> _waypoints = null;

        public Juego()
        {
            InitializeComponent();
            ImagenesEnGrid();
            MarcarMovimiento();
            _inicio = 0;
            _meta = 0;
            _pasos = 0;
            _actual = 0;
            _waypoints = new List<Algoritmia.Coordenada>();
            _mapa = new Algoritmia.Punto[tableLayoutPanel1.ColumnCount - 1, tableLayoutPanel1.RowCount - 1];
            for (int i = 0; i < tableLayoutPanel1.ColumnCount - 1; i++)
                for (int j = 0; j < tableLayoutPanel1.RowCount - 1; j++)
                {
                    _mapa[i, j] = new Algoritmia.Punto(i, j);
                    ((PictureBox)tableLayoutPanel1.GetControlFromPosition(i, j)).Tag = (int)Algoritmia.Terreno.Hierba;
                }
            ResumeLayout();
        }

        private void MarcarMovimiento()
        {
            movimientosRover.SetItemChecked(0, true);
            movimientosRover.SetItemChecked(1, true);
        }

        private void ImagenesEnGrid()
        {
            foreach (PictureBox item in tableLayoutPanel1.Controls)
            {
                item.Click += button_Click;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                int indiceImagen = listView1.FocusedItem.ImageIndex;
                ((PictureBox)sender).Tag = indiceImagen;
                ((PictureBox)sender).Image = terrenos2.Images[indiceImagen];
                int i = tableLayoutPanel1.GetColumn((PictureBox)sender);
                int j = tableLayoutPanel1.GetRow((PictureBox)sender);

                Algoritmia.Punto seleccionado = _mapa[i, j];

                seleccionado.Permitido = true;

                // Si la celda que borramos era un way point la quitamos de la lista
                if (seleccionado.Valor == (int)Algoritmia.Terreno.WayPoint) // Way Point
                { _waypoints.Remove(new Algoritmia.Coordenada() { X = i, Y = j }); }

                if (indiceImagen == (int)Algoritmia.Terreno.Nucelar) // Nucelar
                { seleccionado.Permitido = false; }
                else if (indiceImagen == (int)Algoritmia.Terreno.WayPoint) // // Way Point
                { _waypoints.Add(new Algoritmia.Coordenada() { X = i, Y = j }); }

                seleccionado.Valor = indiceImagen;
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tableLayoutPanel1.ColumnCount - 1; i++)
            {
                for (int j = 0; j < tableLayoutPanel1.RowCount - 1; j++)
                {
                    ((PictureBox)tableLayoutPanel1.GetControlFromPosition(i, j)).Tag = (int)Algoritmia.Terreno.Hierba;
                    ((PictureBox)tableLayoutPanel1.GetControlFromPosition(i, j)).Image
                        = global::Practica1_UI.Properties.Resources.hierba;
                    _mapa[i, j] = new Algoritmia.Punto(i, j);
                }
            }
            _waypoints = new List<Algoritmia.Coordenada>();
            LimpiarLocales();
            btnStart.Enabled = true;
        }

        private void LimpiarLocales()
        {
            _inicio = 0;
            _meta = 0;
            _pasos = 0;
            _actual = 0;
        }

        private void start_Click(object sender, EventArgs e)
        {

            LimpiarLocales();

            Algoritmia.Coordenada inicio = null;
            Algoritmia.Coordenada meta = null;

            bool diagonal = true;
            bool ortogonal = true;
            bool nadar = false;
            bool escalar = false;

            ortogonal = movimientosRover.GetItemChecked(0);
            diagonal = movimientosRover.GetItemChecked(1);
            nadar = movimientosRover.GetItemChecked(2);
            escalar = movimientosRover.GetItemChecked(3);

            for (int i = 0; i < tableLayoutPanel1.ColumnCount - 1; i++)
                for (int j = 0; j < tableLayoutPanel1.RowCount - 1; j++)
                    if (_mapa[i, j].Valor == (int)Algoritmia.Terreno.Inicio)
                    {
                        _inicio++;
                        inicio = new Algoritmia.Coordenada() { X = i, Y = j };
                    }
                    else if (_mapa[i, j].Valor == (int)Algoritmia.Terreno.Fin)
                    {
                        _meta++;
                        meta = new Algoritmia.Coordenada() { X = i, Y = j };
                    }


            if (_inicio == 1 && _meta == 1)
            {
                if (ortogonal || diagonal)
                {
                    _resultado = Algoritmia.Algoritmia.CalculoAEstrella(inicio, meta, diagonal, ortogonal, nadar, escalar, _mapa, _waypoints.ToArray());

                    if (_resultado.Coste > 0)
                    {
                        btnStart.Enabled = false;
                        _pasos = _resultado.Camino.Count();
                        _actual = 0;
                        _coste = _resultado.Coste;
                        timer1.Start();
                    }
                    else
                        MessageBox.Show("No se ha encontrado una ruta.");

                }
                else
                {
                    MessageBox.Show("Debe seleccionar al menos un movimiento Ortogonal - Diagonal.");
                }
            }
            else
                MessageBox.Show("Debe seleccionar un único inicio y fin para el recorrido.");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Obtenemos el paso
            Algoritmia.Coordenada paso = _resultado.Camino[_actual];

            //Vemos que celda tiene el siguiente paso
            PictureBox celda = (PictureBox)tableLayoutPanel1.GetControlFromPosition(paso.X, paso.Y);
            int indice = (int)celda.Tag;

            //Ponemos la imagen que corresponda
            switch (indice)
            {
                case (int)Algoritmia.Terreno.Agua:
                    celda.Image = global::Practica1_UI.Properties.Resources.rover2_agua;
                    break;
                case (int)Algoritmia.Terreno.Roca:
                    celda.Image = global::Practica1_UI.Properties.Resources.rover2_roca;
                    break;
                case (int)Algoritmia.Terreno.Fin:
                    celda.Image = global::Practica1_UI.Properties.Resources.rover2_llegada;
                    break;
                case (int)Algoritmia.Terreno.WayPoint:
                    celda.Image = global::Practica1_UI.Properties.Resources.rover2_waypoint;
                    break;
                default:
                    celda.Image = global::Practica1_UI.Properties.Resources.rover2_hierba;
                    break;
            }

            // Incrementamos el contador
            _actual++;

            if (_actual >= _pasos)
            {
                timer1.Stop();
                MessageBox.Show(String.Format("Camino encontrado con {0} pasos y coste {1}.", _pasos, _coste), "Camino encontrado", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }
    }
}