using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Utilidad.Validaciones
{
    public static class Validaciones
    {
        private static void TextBoxNumeros(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        public static void VerificarTextBoxNumeros(object sender, KeyPressEventArgs e)
        {
            TextBoxNumeros(sender, e);
        }

        private static void TextBoxLetras(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        public static void VerificarTextBoxLetras(object sender, KeyPressEventArgs e)
        {
            TextBoxLetras(sender, e);
        }

        private static bool TextBoxVacios(ErrorProvider errorProvider, params TextBox[] textBoxes)
        {
            bool lleno = true;
            errorProvider.Clear();

            foreach (TextBox textBox in textBoxes)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    errorProvider.SetError(textBox, "Este campo no puede estar vacío.");
                    lleno = false;
                }
                else
                {
                    errorProvider.SetError(textBox, string.Empty);
                }
            }
            return lleno;
        }

        public static bool VerificarTextBoxVacio(ErrorProvider errorProvider, params TextBox[] textBoxes)
        {
            return TextBoxVacios(errorProvider, textBoxes);
        }
    }
}
