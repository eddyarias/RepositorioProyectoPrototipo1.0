﻿using System;
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
    public partial class Form_Clientes : Form
    {
        public Form_Clientes()
        {
            InitializeComponent();
        }

        private void Form_Clientes_Load(object sender, EventArgs e)
        {
            // Centrar el formulario en la pantalla
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2-400,
                                      (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2); 
                                      ////cambio 1
                                      ;
        }

        private void findClientButton_Click(object sender, EventArgs e)
        {

        }
    }
}
