namespace ProyectoP5.Presentacion
{
    partial class Gestiondeusuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestiondeusuarios));
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            label1 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            button5 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleRight;
            button4.Location = new Point(276, 170);
            button4.Name = "button4";
            button4.Size = new Size(130, 48);
            button4.TabIndex = 10;
            button4.Text = "Actualizar usuario ";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleRight;
            button3.Location = new Point(30, 170);
            button3.Name = "button3";
            button3.Size = new Size(132, 48);
            button3.TabIndex = 9;
            button3.Text = "Consultar usuario ";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(276, 88);
            button2.Name = "button2";
            button2.Size = new Size(130, 48);
            button2.TabIndex = 9;
            button2.Text = "Eliminar usuario ";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 21);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(429, 67);
            label1.TabIndex = 0;
            label1.Text = "Sistema de gestión de usuarios ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(30, 91);
            button1.Name = "button1";
            button1.Size = new Size(132, 48);
            button1.TabIndex = 5;
            button1.Text = "Registrar usuario ";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(180, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(436, 258);
            panel1.TabIndex = 11;
            // 
            // button5
            // 
            button5.Location = new Point(22, 19);
            button5.Name = "button5";
            button5.Size = new Size(114, 38);
            button5.TabIndex = 12;
            button5.Text = "Regresar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Gestiondeusuarios
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 468);
            Controls.Add(button5);
            Controls.Add(panel1);
            Name = "Gestiondeusuarios";
            Text = "Gestióndeusuarios";
            FormClosed += Gestiondeusuarios_FormClosed;
            Load += Gestiondeusuarios_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label1;
        private Button button1;
        private Panel panel1;
        private Button button5;
    }
}