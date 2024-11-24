using ProyectoProgramacion.Utlis;

namespace ProyectoProgramacion.Views
{
    partial class UserMainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            PanelHeader = new Panel();
            panelSearchBox = new Panel();
            logoPictureBox = new PictureBox();
            navBar = new Panel();
            navBarFlowLayout = new FlowLayoutPanel();
            PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            navBar.SuspendLayout();
            SuspendLayout();
            // 
            // PanelHeader
            // 
            PanelHeader.BackColor = Color.White;
            PanelHeader.Controls.Add(panelSearchBox);
            PanelHeader.Controls.Add(logoPictureBox);
            PanelHeader.Dock = DockStyle.Top;
            PanelHeader.Location = new Point(0, 0);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new Size(1144, 114);
            PanelHeader.TabIndex = 0;
            // 
            // panelSearchBox
            // 
            panelSearchBox.Location = new Point(294, 10);
            panelSearchBox.Name = "panelSearchBox";
            panelSearchBox.Size = new Size(689, 87);
            panelSearchBox.TabIndex = 1;
            // 
            // logoPictureBox
            // 
            logoPictureBox.BackColor = Color.Transparent;
            logoPictureBox.Location = new Point(10, 10);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(263, 87);
            logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoPictureBox.TabIndex = 0;
            logoPictureBox.TabStop = false;
            // 
            // navBar
            // 
            navBar.BackColor = Color.WhiteSmoke;
            navBar.Controls.Add(navBarFlowLayout);
            navBar.Dock = DockStyle.Top;
            navBar.Location = new Point(0, 114);
            navBar.Name = "navBar";
            navBar.Size = new Size(1144, 50);
            navBar.TabIndex = 1;
            // 
            // navBarFlowLayout
            // 
            navBarFlowLayout.Dock = DockStyle.Fill;
            navBarFlowLayout.Location = new Point(0, 0);
            navBarFlowLayout.Name = "navBarFlowLayout";
            navBarFlowLayout.Padding = new Padding(20, 10, 0, 0);
            navBarFlowLayout.Size = new Size(1144, 50);
            navBarFlowLayout.TabIndex = 0;
            // 
            // UserMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1144, 599);
            Controls.Add(navBar);
            Controls.Add(PanelHeader);
            Name = "UserMainForm";
            Text = "VistaUsuario";
            PanelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            navBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelHeader;
        private Panel navBar;
        private FlowLayoutPanel navBarFlowLayout; // Contenedor para botones de navegación
        private Panel panelSearchBox;
        private PictureBox logoPictureBox;
    }
}

