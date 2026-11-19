namespace ProyectoP5.Presentacion
{
    partial class Actualizar_usuario
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            txtID = new TextBox();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dgvbuscar = new DataGridView();
            button4 = new Button();
            comboBox1 = new ComboBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvbuscar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(237, 9);
            label1.Name = "label1";
            label1.Size = new Size(341, 50);
            label1.TabIndex = 0;
            label1.Text = "Actualización de usuario";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(713, 98);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 1;
            label2.Text = "Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(713, 145);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(711, 189);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 3;
            label4.Text = "Teléfono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(713, 243);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 4;
            label5.Text = "Correo electrónico";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(16, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(691, 23);
            textBox1.TabIndex = 6;
            // 
            // txtID
            // 
            txtID.Location = new Point(713, 116);
            txtID.Name = "txtID";
            txtID.Size = new Size(127, 23);
            txtID.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(713, 163);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(127, 23);
            txtNombre.TabIndex = 8;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(713, 207);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(127, 23);
            txtTelefono.TabIndex = 9;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(713, 261);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(127, 23);
            txtCorreo.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(713, 53);
            button1.Name = "button1";
            button1.Size = new Size(127, 35);
            button1.TabIndex = 11;
            button1.Text = "Buscar ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(469, 367);
            button2.Name = "button2";
            button2.Size = new Size(109, 50);
            button2.TabIndex = 12;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(17, 12);
            button3.Name = "button3";
            button3.Size = new Size(73, 27);
            button3.TabIndex = 13;
            button3.Text = "Regresar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dgvbuscar
            // 
            dgvbuscar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvbuscar.Location = new Point(17, 94);
            dgvbuscar.Name = "dgvbuscar";
            dgvbuscar.Size = new Size(690, 254);
            dgvbuscar.TabIndex = 14;
            dgvbuscar.CellClick += dgvbuscar_CellClick;
            // 
            // button4
            // 
            button4.Location = new Point(178, 367);
            button4.Name = "button4";
            button4.Size = new Size(109, 50);
            button4.TabIndex = 15;
            button4.Text = "Limpiar ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1-ADMINISTRADOR", "2-VENDEDOR", "3-BODEGUERO", "4-CLIENTE" });
            comboBox1.Location = new Point(716, 304);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(124, 23);
            comboBox1.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(716, 286);
            label6.Name = "label6";
            label6.Size = new Size(24, 15);
            label6.TabIndex = 17;
            label6.Text = "Rol";
            // 
            // Actualizar_usuario
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(851, 447);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(button4);
            Controls.Add(dgvbuscar);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(txtID);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Actualizar_usuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar_usuario";
            FormClosed += Actualizar_usuario_FormClosed;
            Load += Actualizar_usuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvbuscar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox txtID;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dgvbuscar;
        private Button button4;
        private ComboBox comboBox1;
        private Label label6;
    }
}