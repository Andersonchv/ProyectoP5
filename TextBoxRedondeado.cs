
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ProyectoP5.Presentacion
{
    public class TextBoxRedondeado : UserControl
    {
        private readonly TextBox txtInterno;

        public TextBoxRedondeado()
        {
            this.BackColor = Color.White;
            this.Padding = new Padding(10, 7, 10, 7);

            txtInterno = new TextBox();

            txtInterno.BorderStyle = BorderStyle.None;
            txtInterno.Font = new Font("Segoe UI", 10F);
            txtInterno.Location = new Point(10, 7);
            txtInterno.Width = Width - 20;

            this.Controls.Add(txtInterno);

            AjustarTextoInterno();
            DibujarBorde();
        }

        public new string Text
        {
            get => txtInterno.Text;
            set => txtInterno.Text = value ?? string.Empty;
        }

        public void Clear()
        {
            txtInterno.Clear();
        }

private void AjustarTextoInterno()
{
    txtInterno.Location = new Point(10, 7);
    txtInterno.Width = Math.Max(0, Width - 20);
}

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            AjustarTextoInterno();
            DibujarBorde();
        }

        private void DibujarBorde()
        {
            int radio = 10;
            int d = radio * 2;

            if (Width <= d || Height <= d)
                return;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(1, 1, d, d, 180, 90);
                path.AddArc(Width - d - 2, 1, d, d, 270, 90);
                path.AddArc(
                    Width - d - 2, Height - d - 2,
                    d, d, 0, 90);
                path.AddArc(
                    1, Height - d - 2,
                    d, d, 90, 90);

                path.CloseFigure();
            }

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int radio = 10;
            int d = radio * 2;

            if (Width <= d || Height <= d)
                return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(1, 1, d, d, 180, 90);
                path.AddArc(Width - d - 2, 1, d, d, 270, 90);
                path.AddArc(
                    Width - d - 2, Height - d - 2,
                    d, d, 0, 90);
                path.AddArc(
                    1, Height - d - 2,
                    d, d, 90, 90);

                path.CloseFigure();

                using (Pen lapiz = new Pen(
                    Color.FromArgb(190, 200, 210), 1))
                {
                    e.Graphics.DrawPath(lapiz, path);
                }
            }
        }
        public bool Multiline
        {
            get => txtInterno.Multiline;
            set => txtInterno.Multiline = value;
        }
    }
}
