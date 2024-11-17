namespace ProyectoProgramacion.Views
{
    partial class UserMainForm
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
            panel1 = new Panel();
            navBar = new Panel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1239, 101);
            panel1.TabIndex = 0;
            // 
            // navBar
            // 
            navBar.BackColor = SystemColors.ButtonFace;
            navBar.Dock = DockStyle.Top;
            navBar.Location = new Point(0, 101);
            navBar.Name = "navBar";
            navBar.Size = new Size(1239, 78);
            navBar.TabIndex = 1;
            // 
            // UserMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1239, 638);
            Controls.Add(navBar);
            Controls.Add(panel1);
            Name = "UserMainForm";
            Text = "VistaUsuario";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel navBar;
    }
}
