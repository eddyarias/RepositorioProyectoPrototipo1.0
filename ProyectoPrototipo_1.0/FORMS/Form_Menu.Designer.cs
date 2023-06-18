namespace ProyectoPrototipo_1._0
{
    partial class Form_Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Menu));
            this.bttModuloInventario = new System.Windows.Forms.Button();
            this.bttModuloClientes = new System.Windows.Forms.Button();
            this.bttModuloProveedores = new System.Windows.Forms.Button();
            this.bttModuloVentas = new System.Windows.Forms.Button();
            this.bttModuloCompras = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttModuloInventario
            // 
            this.bttModuloInventario.Location = new System.Drawing.Point(752, 12);
            this.bttModuloInventario.Name = "bttModuloInventario";
            this.bttModuloInventario.Size = new System.Drawing.Size(179, 142);
            this.bttModuloInventario.TabIndex = 0;
            this.bttModuloInventario.Text = "MÓDULO DE INVENTARIO";
            this.bttModuloInventario.UseVisualStyleBackColor = true;
            this.bttModuloInventario.Click += new System.EventHandler(this.bttModuloInventario_Click);
            // 
            // bttModuloClientes
            // 
            this.bttModuloClientes.Location = new System.Drawing.Point(567, 12);
            this.bttModuloClientes.Name = "bttModuloClientes";
            this.bttModuloClientes.Size = new System.Drawing.Size(179, 142);
            this.bttModuloClientes.TabIndex = 1;
            this.bttModuloClientes.Text = "MÓDULO DE CLIENTES";
            this.bttModuloClientes.UseVisualStyleBackColor = true;
            this.bttModuloClientes.Click += new System.EventHandler(this.bttModuloClientes_Click);
            // 
            // bttModuloProveedores
            // 
            this.bttModuloProveedores.Location = new System.Drawing.Point(382, 12);
            this.bttModuloProveedores.Name = "bttModuloProveedores";
            this.bttModuloProveedores.Size = new System.Drawing.Size(179, 142);
            this.bttModuloProveedores.TabIndex = 2;
            this.bttModuloProveedores.Text = "MÓDULO DE PROVEEDORES";
            this.bttModuloProveedores.UseVisualStyleBackColor = true;
            this.bttModuloProveedores.Click += new System.EventHandler(this.bttProveedores_Click);
            // 
            // bttModuloVentas
            // 
            this.bttModuloVentas.Location = new System.Drawing.Point(12, 12);
            this.bttModuloVentas.Name = "bttModuloVentas";
            this.bttModuloVentas.Size = new System.Drawing.Size(179, 142);
            this.bttModuloVentas.TabIndex = 3;
            this.bttModuloVentas.Text = "MÓDULO DE VENTAS";
            this.bttModuloVentas.UseVisualStyleBackColor = true;
            this.bttModuloVentas.Click += new System.EventHandler(this.bttModuloVentas_Click);
            // 
            // bttModuloCompras
            // 
            this.bttModuloCompras.Location = new System.Drawing.Point(197, 12);
            this.bttModuloCompras.Name = "bttModuloCompras";
            this.bttModuloCompras.Size = new System.Drawing.Size(179, 142);
            this.bttModuloCompras.TabIndex = 4;
            this.bttModuloCompras.Text = "MÓDULO DE COMPRAS";
            this.bttModuloCompras.UseVisualStyleBackColor = true;
            this.bttModuloCompras.Click += new System.EventHandler(this.bttModuloCompras_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(39, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(870, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "SISTEMA DE GESTIÓN PARA “FARMACY ECUADOR”";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 34.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 67);
            this.label2.TabIndex = 6;
            this.label2.Text = "SYSMACY";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(139, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BSalir
            // 
            this.BSalir.Location = new System.Drawing.Point(843, 789);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(88, 39);
            this.BSalir.TabIndex = 9;
            this.BSalir.Text = "SALIR";
            this.BSalir.UseVisualStyleBackColor = true;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 844);
            this.Controls.Add(this.BSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttModuloCompras);
            this.Controls.Add(this.bttModuloVentas);
            this.Controls.Add(this.bttModuloProveedores);
            this.Controls.Add(this.bttModuloClientes);
            this.Controls.Add(this.bttModuloInventario);
            this.Controls.Add(this.pictureBox1);
            this.IsMdiContainer = true;
            this.Name = "Form_Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttModuloInventario;
        private System.Windows.Forms.Button bttModuloClientes;
        private System.Windows.Forms.Button bttModuloProveedores;
        private System.Windows.Forms.Button bttModuloVentas;
        private System.Windows.Forms.Button bttModuloCompras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BSalir;
    }
}

