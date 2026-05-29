namespace ProyectoPOO2C
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            clbProductos = new CheckedListBox();
            nudCantidad = new NumericUpDown();
            btnAgregar = new Button();
            btnCobrar = new Button();
            lblOferta = new Label();
            lblTotal = new Label();
            dgvVentas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // clbProductos
            // 
            clbProductos.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clbProductos.FormattingEnabled = true;
            clbProductos.Items.AddRange(new object[] { "Taco", "Hamburguesa", "Refresco", "Papas" });
            clbProductos.Location = new Point(25, 71);
            clbProductos.Name = "clbProductos";
            clbProductos.Size = new Size(203, 112);
            clbProductos.TabIndex = 0;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(25, 261);
            nudCantidad.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(203, 27);
            nudCantidad.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(330, 131);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCobrar
            // 
            btnCobrar.Location = new Point(330, 195);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(94, 29);
            btnCobrar.TabIndex = 3;
            btnCobrar.Text = "COBRAR";
            btnCobrar.UseVisualStyleBackColor = true;
            btnCobrar.Click += btnCobrar_Click;
            // 
            // lblOferta
            // 
            lblOferta.AutoSize = true;
            lblOferta.Location = new Point(332, 239);
            lblOferta.Name = "lblOferta";
            lblOferta.Size = new Size(51, 20);
            lblOferta.TabIndex = 4;
            lblOferta.Text = "Oferta";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(332, 281);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(45, 20);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total:";
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(503, 131);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.Size = new Size(372, 188);
            dgvVentas.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 450);
            Controls.Add(dgvVentas);
            Controls.Add(lblTotal);
            Controls.Add(lblOferta);
            Controls.Add(btnCobrar);
            Controls.Add(btnAgregar);
            Controls.Add(nudCantidad);
            Controls.Add(clbProductos);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox clbProductos;
        private NumericUpDown nudCantidad;
        private Button btnAgregar;
        private Button btnCobrar;
        private Label lblOferta;
        private Label lblTotal;
        private DataGridView dgvVentas;
    }
}
