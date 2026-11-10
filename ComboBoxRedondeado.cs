
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ProyectoP5.Presentacion
{
    public class ComboBoxRedondeado : UserControl
    {
        private readonly ComboBox comboInterno;

        public ComboBoxRedondeado()
        {
            BackColor = Color.White;
	    MinimumSize = new Size(0, 34);
            comboInterno = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                FlatStyle = FlatStyle.Flat,
		AutoSize = false,
		IntegralHeight = false,
                Font = new Font("Segoe UI", 9F),
		Location = new Point(10, 2),
		Width = Width - 20,
		Height = 20,
                Anchor = AnchorStyles.Top |
                         AnchorStyles.Left |
                         AnchorStyles.Right
		
            };

            Controls.Add(comboInterno);
	    AjustarComboInterno();
        }

        // Elementos del ComboBox
        public ComboBox.ObjectCollection Items => comboInterno.Items;

        // Elemento seleccionado
        public object? SelectedItem
        {
            get => comboInterno.SelectedItem;
            set => comboInterno.SelectedItem = value;
        }

        // Índice seleccionado
        public int SelectedIndex
        {
            get => comboInterno.SelectedIndex;
            set => comboInterno.SelectedIndex = value;
        }

        // Estilo de lista desplegable
        public ComboBoxStyle DropDownStyle
        {
            get => comboInterno.DropDownStyle;
            set => comboInterno.DropDownStyle = value;
        }

        // Formato habilitado
        public bool FormattingEnabled
        {
            get => comboInterno.FormattingEnabled;
            set => comboInterno.FormattingEnabled = value;
        }

        // Evento de cambio de selección
        public event EventHandler SelectedIndexChanged
        {
            add => comboInterno.SelectedIndexChanged += value;
            remove => comboInterno.SelectedIndexChanged -= value;
        }

	// Ajustar tamaño
protected override void OnResize(EventArgs e)
{
    base.OnResize(e);

    AjustarComboInterno();
    Invalidate();
}

        // Dibujar bordes redondeados
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            int radio = 10;
            int d = radio * 2;

            if (Width <= d || Height <= d)
                return;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(1, 1, d, d, 180, 90);
                path.AddArc(Width - d - 2, 1, d, d, 270, 90);
                path.AddArc(
                    Width - d - 2,
                    Height - d - 2,
                    d, d, 0, 90);

                path.AddArc(
                    1,
                    Height - d - 2,
                    d, d, 90, 90);

                path.CloseFigure();

                using (Pen lapiz = new Pen(
                    Color.FromArgb(190, 200, 210), 1))
                {
                    e.Graphics.DrawPath(lapiz, path);
                }
            }
        }
private void AjustarComboInterno()
{
    comboInterno.Location = new Point(10, 2);
    comboInterno.Width = Math.Max(0, Width - 20);
}
    }
}
