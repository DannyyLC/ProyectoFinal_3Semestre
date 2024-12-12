namespace ProyectoProgramacion.Utlis
{
    partial class FullCustomTextBox
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(7, 7);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(307, 18);
            textBox1.TabIndex = 0;
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // FullCustomTextBox
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Window;
            Controls.Add(textBox1);
            Font = new Font("Segoe UI", 9.8F);
            ForeColor = Color.DimGray;
            Name = "FullCustomTextBox";
            Padding = new Padding(7);
            Size = new Size(321, 92);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
    }
}
