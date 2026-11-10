
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ProyectoP5.Presentacion
{
    public class NumericUpDownRedondeado : UserControl, System.ComponentModel.ISupportInitialize
    {
        private readonly NumericUpDown controlInterno;

        public NumericUpDownRedondeado()
        {
            BackColor = Color.White;
            Padding = new Padding(10, 7, 10, 3);

            controlInterno = new NumericUpDown
            {
                BorderStyle = BorderStyle.None,
                Font = new Font("Segoe UI", 9F),
                Location = new Point(8, 4),
                Width = Width - 16,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };

            Controls.Add(controlInterno);
        }

        public decimal Value
        {
            get => controlInterno.Value;
            set => controlInterno.Value = value;
        }

        public decimal Minimum
        {
            get => controlInterno.Minimum;
            set => controlInterno.Minimum = value;
        }

        public decimal Maximum
        {
            get => controlInterno.Maximum;
            set => controlInterno.Maximum = value;
        }

        public int DecimalPlaces
        {
            get => controlInterno.DecimalPlaces;
            set => controlInterno.DecimalPlaces = value;
        }

        public decimal Increment
        {
            get => controlInterno.Increment;
            set => controlInterno.Increment = value;
        }

        public bool ThousandsSeparator
        {
            get => controlInterno.ThousandsSeparator;
            set => controlInterno.ThousandsSeparator = value;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (GraphicsPath path = new GraphicsPath())
            {
                int radio = 10;
                int d = radio * 2;

                path.AddArc(1, 1, d, d, 180, 90);
                path.AddArc(Width - d - 2, 1, d, d, 270, 90);
                path.AddArc(Width - d - 2, Height - d - 2, d, d, 0, 90);
                path.AddArc(1, Height - d - 2, d, d, 90, 90);
                path.CloseFigure();

                using (Pen lapiz = new Pen(Color.FromArgb(190, 200, 210), 1))
                    e.Graphics.DrawPath(lapiz, path);
            }
        }

protected override void OnResize(EventArgs e)
{
    base.OnResize(e);

    if (controlInterno != null)
    {
        controlInterno.Location = new Point(10, 7);
        controlInterno.Width = Math.Max(0, Width - 20);
    }

    Invalidate();
}
	public void BeginInit()
	{
    		((System.ComponentModel.ISupportInitialize)controlInterno).BeginInit();
	}

	public void EndInit()
	{
    		((System.ComponentModel.ISupportInitialize)controlInterno).EndInit();
	}
    }
}
