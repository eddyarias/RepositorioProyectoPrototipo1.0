using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2 - 400,
                                      (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2); ;

            this.TabSecuencialVentas.TabPages[1].Enabled = false;
            this.TabSecuencialVentas.TabPages[2].Enabled = false;
            this.TabSecuencialVentas.TabPages[3].Enabled = false;




            dataGridView1.Rows.Add("Pasta dental       .  ", 3.99);
            dataGridView1.Rows.Add("Paños húmedos      .  ", 2.99);
            dataGridView1.Rows.Add("Analgesia en crema .  ", 4.99);
            dataGridView1.Rows.Add("Antiséptico bucal  .  ", 5.99);
            dataGridView1.Rows.Add("Protector solar    .  ", 9.99);
            dataGridView1.Rows.Add("Jarabe para la tos .  ", 6.99);
            dataGridView1.Rows.Add("Vendas adhesivas   .  ", 2.49);
            dataGridView1.Rows.Add("Antidiarreico      .  ", 7.99);
            dataGridView1.Rows.Add("Repelente insecto  .  ", 8.99);
            dataGridView1.Rows.Add("Jabón antibacterial.  ", 1.99);
            dataGridView1.Rows.Add("Suplemento         .  ", 1.99);
            dataGridView1.Rows.Add("Descongestionante  .  ", 4.99);
            dataGridView1.Rows.Add("Gotas para los ojos.  ", 6.99);
            dataGridView1.Rows.Add("Analgésico en gel  .  ", 5.99);
            dataGridView1.Rows.Add("Antihistamínico    .  ", 3.99);
            dataGridView1.Rows.Add("Desodorante        .  ", 7.99);

            dataGridView1.Columns[0].Width = 8;
            // Establecer el ancho de la columna "Producto"
            dataGridView1.Columns["Producto"].Width = 85;

            // Establecer el ancho de la columna "Precio"
            dataGridView1.Columns["Precio"].Width = 45;

            dataGridView1.Columns["Cantidad"].Width = 36;

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

        List<float> arregloPrecios = new List<float>();
        List<int> arregloCantidad = new List<int>();
        List<String> arregloProductos = new List<String>();

        int productosSeleccionados;

        bool seRealizaronEdiciones=false;

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            seRealizaronEdiciones = true;

            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;

            DataGridViewRow row = dataGridView1.Rows[rowIndex];

            DataGridViewCell cantCell = row.Cells["Cantidad"];
            DataGridViewCell precioCell = row.Cells["Precio"];
            DataGridViewCell productoCell = row.Cells["Producto"];

            if (cantCell != null && cantCell.Value != null &&
                precioCell != null && precioCell.Value != null &&
                productoCell != null && productoCell.Value != null)
            {
                if (int.TryParse(cantCell.Value.ToString(), out int cantidad) &&
                    float.TryParse(precioCell.Value.ToString(), out float precio))
                {
                    string producto = productoCell.Value.ToString();

                    arregloCantidad.Add(cantidad);
                    arregloPrecios.Add(precio);
                    arregloProductos.Add(producto);

                    this.label13.Text = ImprimirInformacion(arregloPrecios, arregloCantidad, arregloProductos);
                    this.lbTotal.Text = TotalVenta.ToString();
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Manejar el evento de clic del botón
            if (seRealizaronEdiciones)
            {
                this.label13.Text=ImprimirInformacion(arregloPrecios, arregloCantidad, arregloProductos );
            }
            else
            {
                // No se realizaron ediciones
                MessageBox.Show("No se realizaron ediciones en el DataGridView.");
            }

            // Restablecer la bandera de ediciones
            seRealizaronEdiciones = false;
        }

        float TotalVenta=0;
        private string ImprimirInformacion(List<float> arregloPrecios, List<int> arregloCantidad, List<string> arregloProductos)
        {
            int cantidadElementos = arregloPrecios.Count;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < cantidadElementos; i++)
            {
                float precio = arregloPrecios[i];
                int cantidad = arregloCantidad[i];
                string producto = arregloProductos[i];

                float total = precio * cantidad;
                TotalVenta += total;

                sb.AppendLine(producto.ToString() + precio.ToString().PadRight(15)+ cantidad.ToString().PadRight(8) + total.ToString());
                precio = cantidad = 0;
                total = 0;
            }

            return sb.ToString();
        }
    }
}
