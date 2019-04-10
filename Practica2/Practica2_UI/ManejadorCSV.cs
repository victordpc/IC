using Algoritmia;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2_UI
{
    internal static class ManejadorCSV
    {

        public static DataTable ImportFromCsvFile(string filePath)
        {
            var rows = 0;
            var data = new DataTable();
            var fila = 0;
            try
            {
                using (var reader = new StreamReader(File.OpenRead(filePath)))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Substring(0, line.Length - 1).Split(';');
                        ++fila;
                        foreach (var item in values)
                        {
                            if (string.IsNullOrEmpty(item) || string.IsNullOrWhiteSpace(item))
                                throw new Exception("Valor no puede ser vacio");

                            if (rows == 0)
                                data.Columns.Add(item);
                        }
                        if (rows > 0)
                            data.Rows.Add(values);
                        rows++;

                        if (values.Length != data.Columns.Count)
                            throw new Exception(string.Format("La fila {0} tiene un numero de datos diferente al resto.", fila));
                    }
                }

                var differentValuesOfLastColumn = Atributo.ObtenerDiferentesValoresDeColumna(data, data.Columns.Count - 1);

                if (differentValuesOfLastColumn.Count > 2)
                    throw new Exception("La ultima columna es la de resultados y solo puede contener dos valores diferentes.");
            }
            catch (Exception ex)
            {
                Helper.TreatErrorException(ex);
                data = null;
            }

            return data?.Rows.Count > 0 ? data : null;
        }

    }
}