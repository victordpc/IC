﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmia
{
    public class Clase
    {
        public Clase()
        {
            Centro = new Muestra();
        }

        public string Nombre { get; set; }

        public Muestra Centro { get; set; }

        public double[][] MatrizCovarianza { get; private set; }

        private double[][] matrizCovarianzaInversa;

        public double[][] MatrizCovarianzaInversa
        {
            get
            {
                if (MatrizCovarianza != null && matrizCovarianzaInversa == null)
                    matrizCovarianzaInversa = Matrix.CalcularInversa(MatrizCovarianza);
                return matrizCovarianzaInversa;
            }
            private set { matrizCovarianzaInversa = value; }
        }

        public override string ToString()
        {
            string resultado = "";
            resultado += Nombre + "; ";
            resultado += "Centro =" + (Centro.Medidas.Count() == 0 ? "" : Centro.ToString()) + "; ";
            return resultado;
        }

        public void InicializarMatrizCovarianza(int dimensionMedida)
        {
            MatrizCovarianza = new double[dimensionMedida][];
            for (int i = 0; i < dimensionMedida; i++)
            {
                MatrizCovarianza[i] = new double[dimensionMedida];
                for (int j = 0; j < dimensionMedida; j++)
                    MatrizCovarianza[i][j] = 0;
            }
        }
    }
}