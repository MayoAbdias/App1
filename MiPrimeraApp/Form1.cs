using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraApp
{
    public partial class MiApp : Form
    {
        public MiApp()
        {
            InitializeComponent();
        }

        private void MiApp_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido a mi App");
        }

        private void MiApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Mostramos un Mensaje con MessageBox.Show. (Run)
            MessageBox.Show("Gracias por usar mi App,hasta la proxima..");
        }

        private void buttonHolaMundo_Click(object sender, EventArgs e)
        {
            //Al dispararse el evento Click, se cambie el color del Formulario.
            //MessageBox.Show("Se disparo el evento Click", " Atencion!");
            //this.BackColor = Color.Blue;
            if (textBoxMiApli.Text == "")
                textBoxMiApli.BackColor = Color.Aqua;
            else
                textBoxMiApli.BackColor = System.Drawing.SystemColors.Control;
           
        }
        private void buttonHolaMundo_MouseMove(object sender, MouseEventArgs e)
        {
            buttonHolaMundo.Cursor = Cursors.Hand;
        }

        private void MiApp_MouseClick(object sender, MouseEventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;

            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Preciono el boton izquierdo", "Atencion!");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Preciono el boton derecho", "Atencion!");
            if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Preciono el boton del medio", "Atencion!");
        }

        private void labelMiApp_MouseMove(object sender, MouseEventArgs e)
        {
            

            
            labelMiApp.BackColor = Color.Purple;
            labelMiApp.Cursor = Cursors.Hand;
        }

       

        private void labelMiApp_MouseLeave(object sender, EventArgs e)
        {
            labelMiApp.BackColor = System.Drawing.SystemColors.Control;
            labelMiApp.Cursor = Cursors.Arrow;
        }

        private void textBoxMiApli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBoxMiapli2_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene" + textBoxMiapli2.Text.Length + "Caracteres");
        }
    }
}
