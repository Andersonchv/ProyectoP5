namespace ProyectoP5.Presentacion
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            btnProductos = new Button();
            btnVentas = new Button();
            btnUsuarios = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(324, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(219, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Sistema de Ventas";
            // 
            // btnProductos
            // 
            btnProductos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProductos.Location = new Point(139, 184);
            btnProductos.Margin = new Padding(3, 2, 3, 2);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(140, 41);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnVentas
            // 
            btnVentas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVentas.Location = new Point(391, 184);
            btnVentas.Margin = new Padding(3, 2, 3, 2);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(140, 41);
            btnVentas.TabIndex = 2;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsuarios.Location = new Point(654, 184);
            btnUsuarios.Margin = new Padding(3, 2, 3, 2);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(140, 41);
            btnUsuarios.TabIndex = 3;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 434);
            Controls.Add(btnUsuarios);
            Controls.Add(btnVentas);
            Controls.Add(btnProductos);
            Controls.Add(lblTitulo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Ventas";
            WindowState = FormWindowState.Maximized;
            Load += FrmMenuPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnProductos;
        private Button btnVentas;
        private Button btnUsuarios;
    }
}