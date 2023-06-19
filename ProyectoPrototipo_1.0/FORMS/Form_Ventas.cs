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




            dataGridView1.Rows.Add("Pasta dental", "Ayuda a prevenir la caries y mantener una buena salud bucal", 3.99);
            dataGridView1.Rows.Add("Paños húmedos", "Limpia y refresca la piel suavemente", 2.99);
            dataGridView1.Rows.Add("Analgesia en crema", "Alivia el dolor muscular y articular", 4.99);
            dataGridView1.Rows.Add("Antiséptico bucal", "Elimina los gérmenes y refresca el aliento", 5.99);
            dataGridView1.Rows.Add("Protector solar SPF 50+", "Protege la piel de los rayos UV y previene quemaduras", 9.99);
            dataGridView1.Rows.Add("Jarabe para la tos", "Alivia la tos seca y productiva", 6.99);
            dataGridView1.Rows.Add("Vendas adhesivas", "Se utilizan para cubrir heridas y cortes", 2.49);
            dataGridView1.Rows.Add("Antidiarreico", "Controla la diarrea y alivia los síntomas", 7.99);
            dataGridView1.Rows.Add("Loción repelente de insectos", "Protege contra los mosquitos y otros insectos", 8.99);
            dataGridView1.Rows.Add("Jabón antibacterial", "Limpia y desinfecta las manos", 1.99);
            dataGridView1.Rows.Add("Suplemento vitamínico", "Proporciona nutrientes esenciales para el organismo", 10.99);
            dataGridView1.Rows.Add("Descongestionante nasal", "Alivia la congestión nasal y los síntomas del resfriado", 4.99);
            dataGridView1.Rows.Add("Gotas para los ojos", "Hidrata y alivia la irritación ocular", 6.99);
            dataGridView1.Rows.Add("Analgésico en gel", "Alivia el dolor localizado en músculos y articulaciones", 5.99);
            dataGridView1.Rows.Add("Antihistamínico", "Alivia los síntomas de las alergias", 3.99);
            dataGridView1.Rows.Add("Crema para pie de atleta", "Trata y previene las infecciones por hongos en los pies", 7.99);

            dataGridView1.Columns[0].Width = 8;
            // Establecer el ancho de la columna "Producto"
            dataGridView1.Columns["Producto"].Width = 85;

            // Establecer el ancho de la columna "Descripción"
            dataGridView1.Columns["Descripcion"].Width = 95;

            // Establecer el ancho de la columna "Precio"
            dataGridView1.Columns["Precio"].Width = 40;

            dataGridView1.Columns["Cantidad"].Width = 60;

            dataGridView1.Columns["Cantidad"].ReadOnly = false;

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
