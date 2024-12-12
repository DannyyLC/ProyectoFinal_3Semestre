using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace adminView
{
    public class RoundedTableLayoutPanel : TableLayoutPanel
    {
        public int BorderRadius { get; set; } = 20; // Radio de las esquinas

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            var graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Crear un rectángulo redondeado
            var rect = new Rectangle(0, 0, Width, Height);
            using (var path = CreateRoundedRectanglePath(rect, BorderRadius))
            {
                // Ajustar la región del control para hacer que el fondo sea redondeado
                this.Region = new Region(path);

                // Dibujar el fondo del panel
                using (var brush = new SolidBrush(BackColor))
                {
                    graphics.FillPath(brush, path);
                }

                // Dibujar el borde del panel (opcional)
                using (var pen = new Pen(ForeColor, 2))
                {
                    graphics.DrawPath(pen, path);
                }
            }
        }

        // Método auxiliar para crear un GraphicsPath con esquinas redondeadas
        private GraphicsPath CreateRoundedRectanglePath(Rectangle rect, int radius)
        {
            var path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
