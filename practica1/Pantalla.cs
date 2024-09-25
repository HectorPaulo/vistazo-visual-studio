using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica1
{
    public partial class Pantalla : Form
    {
        public Pantalla()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Código que se ejecuta al cargar el formulario
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Evento al hacer clic en label2
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lbl.Text == "Borrando System32")
            {
                lbl.Text = "System32 Restaurado";
            }
            else
            {
                MessageBox.Show("System32 no existe", "Mensaje");
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (lbl.Text == "System32 Restaurado")
            {
                lbl.Text = "Borrando System32";
            }
            else
            {
                MessageBox.Show("System32 está en su lugar.", "Mensaje");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblsaludo.Text = "Hola "+ txtNombre.Text;
        }
    }
}
