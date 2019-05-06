using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3_UI
{
    static class Helper
    {
        internal static void TreatErrorException(Exception message)
        {
            System.Windows.Forms.MessageBox.Show(message.Message,
                "Error en la ejecución",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Error);

        }

        internal static void TreatErrorMessage(string v)
        {
            System.Windows.Forms.MessageBox.Show(v,
                "Error en la ejecución",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Error);
        }

        internal static void ShowMessage(string v)
        {
            System.Windows.Forms.MessageBox.Show(v,
                "Información",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Information);
        }
    }
}
