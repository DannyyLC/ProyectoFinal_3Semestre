namespace IntroductionView
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            tableLayoutPanelAcceso = new TableLayoutPanel();
            labelPregunta = new Label();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            labelAcceso = new Label();
            buttonIniciarSesion = new Button();
            buttonRegistrate = new Button();
            buttonExitProgram = new Button();
            tableLayoutPanelAcceso.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelAcceso
            // 
            tableLayoutPanelAcceso.BackColor = Color.Transparent;
            tableLayoutPanelAcceso.ColumnCount = 4;
            tableLayoutPanelAcceso.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanelAcceso.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanelAcceso.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanelAcceso.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanelAcceso.Controls.Add(labelPregunta, 2, 6);
            tableLayoutPanelAcceso.Controls.Add(textBoxPassword, 2, 4);
            tableLayoutPanelAcceso.Controls.Add(textBoxUsername, 2, 3);
            tableLayoutPanelAcceso.Controls.Add(labelAcceso, 2, 2);
            tableLayoutPanelAcceso.Controls.Add(buttonIniciarSesion, 2, 5);
            tableLayoutPanelAcceso.Controls.Add(buttonRegistrate, 2, 7);
            tableLayoutPanelAcceso.Controls.Add(buttonExitProgram, 2, 8);
            tableLayoutPanelAcceso.Dock = DockStyle.Fill;
            tableLayoutPanelAcceso.Location = new Point(0, 0);
            tableLayoutPanelAcceso.Name = "tableLayoutPanelAcceso";
            tableLayoutPanelAcceso.RowCount = 10;
            tableLayoutPanelAcceso.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanelAcceso.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanelAcceso.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanelAcceso.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tableLayoutPanelAcceso.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tableLayoutPanelAcceso.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tableLayoutPanelAcceso.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanelAcceso.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            tableLayoutPanelAcceso.RowStyles.Add(new RowStyle(SizeType.Percent, 23F));
            tableLayoutPanelAcceso.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutPanelAcceso.Size = new Size(1494, 783);
            tableLayoutPanelAcceso.TabIndex = 0;
            // 
            // labelPregunta
            // 
            labelPregunta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelPregunta.AutoSize = true;
            labelPregunta.BackColor = Color.Transparent;
            labelPregunta.Font = new Font("Tahoma", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelPregunta.ForeColor = Color.FromArgb(18, 17, 16);
            labelPregunta.Location = new Point(749, 407);
            labelPregunta.Name = "labelPregunta";
            labelPregunta.Size = new Size(249, 28);
            labelPregunta.TabIndex = 4;
            labelPregunta.Text = "¿No tienes una cuenta?";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.Location = new Point(749, 291);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = " Contraseña";
            textBoxPassword.Size = new Size(300, 40);
            textBoxPassword.TabIndex = 2;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxUsername.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUsername.Location = new Point(749, 245);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.PlaceholderText = " Usuario";
            textBoxUsername.Size = new Size(300, 40);
            textBoxUsername.TabIndex = 1;
            // 
            // labelAcceso
            // 
            labelAcceso.AutoSize = true;
            labelAcceso.BackColor = Color.Transparent;
            labelAcceso.Font = new Font("Segoe UI", 42F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAcceso.ForeColor = Color.FromArgb(18, 17, 16);
            labelAcceso.ImageAlign = ContentAlignment.TopLeft;
            labelAcceso.Location = new Point(749, 156);
            labelAcceso.Name = "labelAcceso";
            labelAcceso.RightToLeft = RightToLeft.No;
            labelAcceso.Size = new Size(265, 78);
            labelAcceso.TabIndex = 3;
            labelAcceso.Text = "Sign in";
            // 
            // buttonIniciarSesion
            // 
            buttonIniciarSesion.BackColor = Color.FromArgb(18, 17, 16);
            buttonIniciarSesion.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonIniciarSesion.ForeColor = Color.Ivory;
            buttonIniciarSesion.Location = new Point(749, 345);
            buttonIniciarSesion.Name = "buttonIniciarSesion";
            buttonIniciarSesion.Size = new Size(300, 48);
            buttonIniciarSesion.TabIndex = 5;
            buttonIniciarSesion.Text = "Iniciar Sesión";
            buttonIniciarSesion.UseVisualStyleBackColor = false;
            buttonIniciarSesion.Click += buttonIniciarSesion_Click;
            // 
            // buttonRegistrate
            // 
            buttonRegistrate.BackColor = Color.FromArgb(18, 17, 16);
            buttonRegistrate.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegistrate.ForeColor = Color.Ivory;
            buttonRegistrate.Location = new Point(749, 438);
            buttonRegistrate.Name = "buttonRegistrate";
            buttonRegistrate.Size = new Size(300, 48);
            buttonRegistrate.TabIndex = 6;
            buttonRegistrate.Text = "Regístrate";
            buttonRegistrate.UseVisualStyleBackColor = false;
            // 
            // buttonExitProgram
            // 
            buttonExitProgram.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonExitProgram.BackColor = Color.FromArgb(208, 17, 16);
            buttonExitProgram.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExitProgram.ForeColor = Color.FromArgb(254, 254, 254);
            buttonExitProgram.Location = new Point(1090, 632);
            buttonExitProgram.Name = "buttonExitProgram";
            buttonExitProgram.Size = new Size(250, 50);
            buttonExitProgram.TabIndex = 7;
            buttonExitProgram.Text = "Salir";
            buttonExitProgram.UseVisualStyleBackColor = false;
            buttonExitProgram.Click += buttonExitProgram_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Kicks_Login_FS;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1494, 783);
            Controls.Add(tableLayoutPanelAcceso);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            tableLayoutPanelAcceso.ResumeLayout(false);
            tableLayoutPanelAcceso.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelAcceso;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Label labelAcceso;
        private Label labelPregunta;
        private Button buttonIniciarSesion;
        private Button buttonRegistrate;
        private Button buttonExitProgram;
    }
}