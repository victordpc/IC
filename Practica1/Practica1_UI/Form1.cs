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
    public partial class Form1 : Form
    {
        private int _inicio;
        private int _meta;
        private Algoritmia.AEstrellaResultado resultado = null;
        private Algoritmia.Punto[,] mapa = null;
        private List<Algoritmia.Coordenada> waypoints = null;

        public Form1()
        {
            InitializeComponent();
            ImagenesEnGrid();
            MarcarMovimiento();
            _inicio = 0;
            _meta = 0;
            waypoints = new List<Algoritmia.Coordenada>();
            mapa = new Algoritmia.Punto[tableLayoutPanel1.ColumnCount, tableLayoutPanel1.RowCount];
            for (int i = 0; i < tableLayoutPanel1.ColumnCount; i++)
                for (int j = 0; j < tableLayoutPanel1.RowCount; j++)
                    mapa[i, j] = new Algoritmia.Punto(i, j);

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
                ((PictureBox)sender).Image = terrenos2.Images[indiceImagen];
                int i = tableLayoutPanel1.GetColumn((PictureBox)sender);
                int j = tableLayoutPanel1.GetRow((PictureBox)sender);

                Algoritmia.Punto seleccionado = mapa[i, j];

                seleccionado.Permitido = true;

                // Si la celda que borramos era un way point la quitamos de la lista
                if (seleccionado.Valor == 6) // Way Point
                { waypoints.Remove(new Algoritmia.Coordenada() { X = i, Y = j }); }

                if (indiceImagen == 3) // Nucelar
                { seleccionado.Permitido = false; }
                else if (indiceImagen == 6) // // Way Point
                { waypoints.Add(new Algoritmia.Coordenada() { X = i, Y = j }); }

                seleccionado.Valor = indiceImagen;
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tableLayoutPanel1.ColumnCount; i++)
            {
                for (int j = 0; j < tableLayoutPanel1.RowCount; j++)
                {
                    ((PictureBox)tableLayoutPanel1.GetControlFromPosition(i, j)).Image
                        = global::Practica1_UI.Properties.Resources.hierba;
                    mapa[i, j].Valor = 0;
                    mapa[i, j].Permitido = true;
                }
            }
            _inicio = 0;
            _meta = 0;
            waypoints = new List<Algoritmia.Coordenada>();
        }

        private void start_Click(object sender, EventArgs e)
        {
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

            for (int i = 0; i < tableLayoutPanel1.ColumnCount; i++)
                for (int j = 0; j < tableLayoutPanel1.RowCount; j++)
                    if (mapa[i, j].Valor == 4)
                    {
                        _inicio++;
                        inicio = new Algoritmia.Coordenada() { X = i, Y = j };
                    }
                    else if (mapa[i, j].Valor == 5)
                    {
                        _meta++;
                        meta = new Algoritmia.Coordenada() { X = i, Y = j };
                    }


            if (_inicio == 1 && _meta == 1)
            {
                if (ortogonal || diagonal)
                {
                    resultado = Algoritmia.Algoritmia.CalculoAEstrella(inicio, meta, diagonal, ortogonal, nadar, escalar, mapa, waypoints.ToArray());
                }
                else
                {
                    MessageBox.Show("Debe seleccionar al menos un movimiento Ortogonal - Diagonal.");
                }
            }
            else
                MessageBox.Show("Debe seleccionar un único inicio y fin para el recorrido.");
        }
    }
}