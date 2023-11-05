using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraApp
{
    public partial class Trabajo2 : Form
    {
        public Trabajo2()
        {
            InitializeComponent();
        }

        private void Trabajo2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Complete el formulario por favor..");
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {
            string apellido = textBoxApellido.Text;
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
        }

        private void textBoxEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBoxDireccion_TextChanged(object sender, EventArgs e)
        {
            string direccion = textBoxDireccion.Text;
        }
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (textBoxApellido.Text == "")
                textBoxApellido.BackColor = Color.Red;
            else
                textBoxApellido.BackColor = System.Drawing.SystemColors.Control;
            if (textBoxNombre.Text == "")
                textBoxNombre.BackColor = Color.Red;
            else
                textBoxNombre.BackColor = System.Drawing.SystemColors.Control;
            if (textBoxEdad.Text == "")
                textBoxEdad.BackColor = Color.Red;
            else
                textBoxEdad.BackColor = System.Drawing.SystemColors.Control;
            if (textBoxDireccion.Text == "")
                textBoxDireccion.BackColor = Color.Red;
            else
                textBoxDireccion.BackColor = System.Drawing.SystemColors.Control;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
