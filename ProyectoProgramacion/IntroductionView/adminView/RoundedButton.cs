using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace adminView
{
    public class RoundedButton : Button
    {
        public int BorderRadius { get; set; } = 20; // Radio del borde redondeado
        private System.Windows.Forms.Timer animationTimer = new System.Windows.Forms.Timer();
        private float scale = 1.0f; // Escala del botón (1.0 = tamaño original)
        private bool isShrinking = true; // Controla si el botón está reduciéndose o regresando a su tamaño original
        private Color BorderColor;

        [Category("Appearance")]


        public RoundedButton()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = Color.FromArgb(0, 0, 0);
            this.ForeColor = Color.White;
            this.BorderColor = BorderColor;

            // Configurar el temporizador para la animación
            animationTimer.Interval = 30; // Velocidad de la animación (en ms)
            animationTimer.Tick += AnimateButton;

        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            var graphics = pevent.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Crear un rectángulo con bordes redondeados ajustado a la escala
            var scaledWidth = (int)(Width * scale);
            var scaledHeight = (int)(Height * scale);
            var xOffset = (Width - scaledWidth) / 2;
            var yOffset = (Height - scaledHeight) / 2;
            var rect = new Rectangle(xOffset, yOffset, scaledWidth, scaledHeight);

            var path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, BorderRadius, BorderRadius, 180, 90);
            path.AddArc(rect.Right - BorderRadius, rect.Y, BorderRadius, BorderRadius, 270, 90);
            path.AddArc(rect.Right - BorderRadius, rect.Bottom - BorderRadius, BorderRadius, BorderRadius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - BorderRadius, BorderRadius, BorderRadius, 90, 90);
            path.CloseFigure();

            // Ajustar la región del botón
            this.Region = new Region(path);

            // Dibujar el fondo
            graphics.FillPath(new SolidBrush(BackColor), path);

            // Dibujar el borde
            graphics.DrawPath(new Pen(BorderColor, 2), path);

            // Dibujar el texto centrado
            var textSize = graphics.MeasureString(Text, Font);
            var textPoint = new PointF(
                (Width - textSize.Width) / 2,
                (Height - textSize.Height) / 2);
            graphics.DrawString(Text, Font, new SolidBrush(ForeColor), textPoint);
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            // Iniciar la animación al hacer clic
            isShrinking = true;
            animationTimer.Start();
        }

        private void AnimateButton(object sender, EventArgs e)
        {
            if (isShrinking)
            {
                scale -= 0.05f; // Reducir el tamaño gradualmente
                if (scale <= 0.9f)
                {
                    isShrinking = false; // Cambiar dirección (crecer)
                }
            }
            else
            {
                scale += 0.05f; // Incrementar el tamaño gradualmente
                if (scale >= 1.0f)
                {
                    scale = 1.0f;
                    animationTimer.Stop(); // Detener animación al alcanzar tamaño original
                }
            }

            Invalidate(); // Redibujar el botón con el nuevo tamaño
        }
    }
}
