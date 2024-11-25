using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace adminView
{
    public class RoundedButton : Button
    {
        public int BorderRadius { get; set; } = 20; // Radio del borde redondeado
        public RoundedButton()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = Color.FromArgb(0, 0, 0);
            this.ForeColor = Color.White;
 
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            var graphics = pevent.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Crear un rectángulo con bordes redondeados
            var rect = new Rectangle(0, 0, Width, Height);
            var path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, BorderRadius, BorderRadius, 180, 90);
            path.AddArc(rect.Right - BorderRadius, rect.Y, BorderRadius, BorderRadius, 270, 90);
            path.AddArc(rect.Right - BorderRadius, rect.Bottom - BorderRadius, BorderRadius, BorderRadius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - BorderRadius, BorderRadius, BorderRadius, 90, 90);
            path.CloseFigure();

            // Dibujar el fondo
            graphics.FillPath(new SolidBrush(BackColor), path);

            // Dibujar el borde
            graphics.DrawPath(new Pen(ForeColor, 2), path);

            // Dibujar el texto centrado
            var textSize = graphics.MeasureString(Text, Font);
            var textPoint = new PointF(
                (Width - textSize.Width) / 2,
                (Height - textSize.Height) / 2);
            graphics.DrawString(Text, Font, new SolidBrush(ForeColor), textPoint);
        }
    }
}
