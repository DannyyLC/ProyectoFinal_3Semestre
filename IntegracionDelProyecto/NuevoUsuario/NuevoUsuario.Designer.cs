namespace Interfaz
{
    partial class NuevoUsuario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoUsuario));
            txtBoxUsuario = new TextBox();
            txtBoxContra = new TextBox();
            btnGuardar = new Button();
            txtBoxNombre = new TextBox();
            SuspendLayout();
            // 
            // txtBoxUsuario
            // 
            txtBoxUsuario.Font = new Font("Segoe UI", 12F);
            txtBoxUsuario.Location = new Point(215, 373);
            txtBoxUsuario.Margin = new Padding(3, 2, 3, 2);
            txtBoxUsuario.Name = "txtBoxUsuario";
            txtBoxUsuario.PlaceholderText = "Usuario";
            txtBoxUsuario.Size = new Size(162, 29);
            txtBoxUsuario.TabIndex = 0;
            txtBoxUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBoxContra
            // 
            txtBoxContra.Font = new Font("Segoe UI", 12F);
            txtBoxContra.Location = new Point(215, 437);
            txtBoxContra.Margin = new Padding(3, 2, 3, 2);
            txtBoxContra.Name = "txtBoxContra";
            txtBoxContra.PlaceholderText = "Contraseña";
            txtBoxContra.Size = new Size(162, 29);
            txtBoxContra.TabIndex = 1;
            txtBoxContra.TextAlign = HorizontalAlignment.Center;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Black;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(227, 483);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(137, 40);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtBoxNombre
            // 
            txtBoxNombre.Font = new Font("Segoe UI", 12F);
            txtBoxNombre.Location = new Point(215, 318);
            txtBoxNombre.Margin = new Padding(3, 2, 3, 2);
            txtBoxNombre.Name = "txtBoxNombre";
            txtBoxNombre.PlaceholderText = "Nombre";
            txtBoxNombre.Size = new Size(162, 29);
            txtBoxNombre.TabIndex = 3;
            txtBoxNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // NuevoUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = IntroductionView.Properties.Resources.Background;
            ClientSize = new Size(595, 552);
            Controls.Add(txtBoxNombre);
            Controls.Add(btnGuardar);
            Controls.Add(txtBoxContra);
            Controls.Add(txtBoxUsuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(611, 591);
            MinimumSize = new Size(611, 591);
            Name = "NuevoUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo usuario";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxUsuario;
        private TextBox txtBoxContra;
        private Button btnGuardar;
        private TextBox txtBoxNombre;
    }
}
