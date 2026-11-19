namespace ProyectoP5.Presentacion
{
    partial class Eliminar_usuarios
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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            dgvbuscar = new DataGridView();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvbuscar).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(681, 23);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(709, 54);
            button1.Name = "button1";
            button1.Size = new Size(82, 36);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(22, 12);
            button2.Name = "button2";
            button2.Size = new Size(86, 23);
            button2.TabIndex = 3;
            button2.Text = "Regresar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(418, 449);
            button3.Name = "button3";
            button3.Size = new Size(211, 44);
            button3.TabIndex = 4;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(221, 10);
            label1.Name = "label1";
            label1.Size = new Size(349, 51);
            label1.TabIndex = 5;
            label1.Text = "Eliminar usuario";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvbuscar
            // 
            dgvbuscar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvbuscar.Location = new Point(22, 100);
            dgvbuscar.Name = "dgvbuscar";
            dgvbuscar.Size = new Size(733, 343);
            dgvbuscar.TabIndex = 6;
            dgvbuscar.CellClick += dgvbuscar_CellClick;
            // 
            // button4
            // 
            button4.Location = new Point(129, 449);
            button4.Name = "button4";
            button4.Size = new Size(211, 44);
            button4.TabIndex = 7;
            button4.Text = "Limpiar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Eliminar_usuarios
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 505);
            Controls.Add(button4);
            Controls.Add(dgvbuscar);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Eliminar_usuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eliminar usuarios";
            FormClosed += Eliminar_usuarios_FormClosed;
            Load += Eliminar_usuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvbuscar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private DataGridView dgvbuscar;
        private Button button4;
    }
}