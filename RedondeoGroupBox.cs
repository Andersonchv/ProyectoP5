
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ProyectoP5.Presentacion
{
    public class RedondeoGroupBox : GroupBox
    {
        public RedondeoGroupBox()
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw,
                true
            );

            BackColor = Color.White;
            ForeColor = Color.Black;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Configuración gráfica
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(BackColor);

            int radio = 15;
            int margen = 2;
            int diametro = radio * 2;

            // Medidas del cuadro
            int ancho = Width - margen * 2;
            int alto = Height - margen * 2;

            using (GraphicsPath path = new GraphicsPath())
            using (Pen lapiz = new Pen(Color.Silver, 1.5f))
            using (SolidBrush fondo = new SolidBrush(BackColor))
            using (SolidBrush texto = new SolidBrush(ForeColor))
            {
                // Crear las esquinas redondeadas
                path.AddArc(
                    margen, margen,
                    diametro, diametro, 180, 90
                );

                path.AddArc(
                    ancho - diametro + margen, margen,
                    diametro, diametro, 270, 90
                );

                path.AddArc(
                    ancho - diametro + margen,
                    alto - diametro + margen,
                    diametro, diametro, 0, 90
                );

                path.AddArc(
                    margen,
                    alto - diametro + margen,
                    diametro, diametro, 90, 90
                );

                path.CloseFigure();

                // Dibujar el borde redondeado
                g.DrawPath(lapiz, path);

                // Medir el título
                SizeF medida = g.MeasureString(Text, Font);

                // Limpiar el espacio detrás del título
                g.FillRectangle(
                    fondo,
                    10,
                    0,
                    medida.Width + 8,
                    Font.Height
                );

                // Dibujar el título una sola vez
                g.DrawString(
                    Text,
                    Font,
                    texto,
                    10,
                    0
                );
            }
        }
    }
}

