using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3_UI
{
    internal static class ManejadorCSV
    {
        public static List<Algoritmia.Clase> ImportFromCsvFile(string filePath, out List<Algoritmia.Muestra> muestras)
        {
            int numElementosLeidos = 0;
            var data = new List<Algoritmia.Clase>();
            muestras = new List<Algoritmia.Muestra>();
            Algoritmia.Muestra leido;
            string nombreClase;
            int fila = 0;

            try
            {
                using (var reader = new StreamReader(File.OpenRead(filePath)))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');//.Substring(0, line.Length - 1).Split(',');

                        ++fila;

                        leido = new Algoritmia.Muestra();
                        nombreClase = "";

                        if (numElementosLeidos == 0)
                            numElementosLeidos = values.Length;

                        if (numElementosLeidos != values.Length)
                            throw new Exception(string.Format("La fila {0} tiene un numero de datos diferente al resto.", fila));
                        else
                        {
                            for (int i = 0; i < numElementosLeidos; i++)
                                if (i != numElementosLeidos - 1)
                                    leido.Medidas.Add(float.Parse(values[i].Replace('.', ',')));
                                else
                                {
                                    leido.NombreClase = values[i];
                                    nombreClase = values[i];
                                }

                            Algoritmia.Clase encontrado = data.FirstOrDefault(dato => dato.Nombre == nombreClase);

                            if (encontrado == null)
                                data.Add(new Algoritmia.Clase()
                                {
                                    Nombre = nombreClase,
                                });
                            muestras.Add(leido);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Helper.TreatErrorException(ex);
                data = null;
            }
            data[0].ToString();
            return data.Count > 0 ? data : null;
        }

        internal static void LeerMuestra(string fileName, TextBox txtFichero, TextBox txtMuestra1, TextBox txtMuestra2, TextBox txtMuestra3, TextBox txtMuestra4)
        {
            Algoritmia.Muestra leido = new Algoritmia.Muestra();
            txtFichero.Text = fileName;
            try
            {
                using (var reader = new StreamReader(File.OpenRead(fileName)))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Substring(0, line.Length - 1).Split(',');

                        for (int i = 0; i < values.Length - 1; i++)
                            leido.Medidas.Add(float.Parse(values[i].Replace('.', ',')));

                        leido.NombreClase = values[values.Length-1];
                    }
                }
                if (leido.Medidas.Count != 0)
                {
                    txtMuestra1.Text = leido.Medidas[0].ToString();
                    txtMuestra2.Text = leido.Medidas[1].ToString();
                    txtMuestra3.Text = leido.Medidas[2].ToString();
                    txtMuestra4.Text = leido.Medidas[3].ToString();
                }
                else
                    Helper.TreatErrorMessage("No se ha cargado un fichero de medidas válido");
            }
            catch (Exception ex)
            {
                Helper.TreatErrorException(ex);
            }
        }
    }
}