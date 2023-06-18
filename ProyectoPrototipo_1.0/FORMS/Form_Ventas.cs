using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrototipo_1._0
{
    public partial class Form_Ventas : Form
    {
        public Form_Ventas()
        {
            InitializeComponent();
        }

        private void Form_Ventas_Load(object sender, EventArgs e)
        {
            // Centrar el formulario en la pantalla
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2-400,
                                      (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2); ;

            this.TabSecuencialVentas.TabPages[1].Enabled = false;
            this.TabSecuencialVentas.TabPages[2].Enabled= false;
            this.TabSecuencialVentas.TabPages[3].Enabled = false;
        }


        // Variable para almacenar el índice de la pestaña actual
        private int indicePestanaActual = 0;

        // Método para avanzar a la siguiente pestaña
        private void AvanzarPestana()
        {
            // Deshabilitar la pestaña actual
            TabSecuencialVentas.TabPages[indicePestanaActual].Enabled = false;

            // Incrementar el índice de la pestaña actual
            indicePestanaActual++;

            // Habilitar la siguiente pestaña
            if (indicePestanaActual < TabSecuencialVentas.TabCount)
            {
                TabSecuencialVentas.TabPages[indicePestanaActual].Enabled = true;
                TabSecuencialVentas.SelectedIndex = indicePestanaActual;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.AvanzarPestana();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.AvanzarPestana();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.AvanzarPestana();
        }
    }
}
