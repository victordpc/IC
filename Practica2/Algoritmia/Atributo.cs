﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmia
{
    public class Atributo
    {
        public Atributo(string name, List<string> differentAttributenames)
        {
            Nombre = name;
            AtributosDiferentes = differentAttributenames;
        }

        public string Nombre { get; }

        public List<string> AtributosDiferentes { get; }

        public double Merito { get; set; }

        public static List<string> ObtenerDiferentesValoresDeColumna(DataTable data, int columnIndex)
        {
            var atributos = new List<string>();

            for (var i = 0; i < data.Rows.Count; i++)
            {
                var found = atributos.Any(t => t.ToUpper().Equals(data.Rows[i][columnIndex].ToString().ToUpper()));

                if (!found)
                {
                    atributos.Add(data.Rows[i][columnIndex].ToString());
                }
            }

            return atributos;
        }
    }

}
