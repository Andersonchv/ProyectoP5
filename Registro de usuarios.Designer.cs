namespace ProyectoP5.Presentacion
{
    partial class Registrodeusuarios
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
            components = new System.ComponentModel.Container();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            txtPerfil = new Label();
            comboBox1 = new ComboBox();
            conexionBDBindingSource = new BindingSource(components);
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)conexionBDBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 75);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 0;
            label2.Text = "Nombre ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(249, 76);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 1;
            label3.Text = "Teléfono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(416, 76);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 2;
            label4.Text = "Correo electrónico ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(91, 93);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(249, 94);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(416, 94);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(28, 22);
            button1.Name = "button1";
            button1.Size = new Size(70, 24);
            button1.TabIndex = 6;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(416, 289);
            button2.Name = "button2";
            button2.Size = new Size(126, 48);
            button2.TabIndex = 7;
            button2.Text = "Registrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Arial", 20.25F);
            label5.Location = new Point(180, 9);
            label5.Name = "label5";
            label5.Size = new Size(429, 67);
            label5.TabIndex = 8;
            label5.Text = "REGISTRO DE USUARIO";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPerfil
            // 
            txtPerfil.AutoSize = true;
            txtPerfil.Location = new Point(575, 72);
            txtPerfil.Name = "txtPerfil";
            txtPerfil.Size = new Size(34, 15);
            txtPerfil.TabIndex = 9;
            txtPerfil.Text = "Perfil";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1-ADMINISTRADOR", "2-VENDEDOR", "3-BODEGUERO", "4-CLIENTE" });
            comboBox1.Location = new Point(578, 93);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(104, 23);
            comboBox1.TabIndex = 10;
            // 
            // conexionBDBindingSource
            // 
            conexionBDBindingSource.DataSource = typeof(Datos.ConexionBD);
            // 
            // button3
            // 
            button3.Location = new Point(249, 289);
            button3.Name = "button3";
            button3.Size = new Size(126, 48);
            button3.TabIndex = 11;
            button3.Text = "Limpiar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Registrodeusuarios
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(comboBox1);
            Controls.Add(txtPerfil);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Registrodeusuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REGISTRO DE USUARIOS ";
            FormClosed += Registrodeusuarios_FormClosed;
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)conexionBDBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Label label5;
        private Label txtPerfil;
        private ComboBox comboBox1;
        private BindingSource conexionBDBindingSource;
        private Button button3;
    }
}