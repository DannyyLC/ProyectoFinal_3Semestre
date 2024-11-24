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
            navBar = new Panel();
            navBarPanel = new FlowLayoutPanel();
            AccountPanel = new Panel();
            CartPanel = new Panel();
            CartPicture = new PictureBox();
            AccountPicture = new PictureBox();
            LogoPanel = new Panel();
            LogoPicture = new PictureBox();
            loupePanel = new Panel();
            LoupePicture = new PictureBox();
            PanelHeader.SuspendLayout();
            panelSearchBox.SuspendLayout();
            navBar.SuspendLayout();
            AccountPanel.SuspendLayout();
            CartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CartPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AccountPicture).BeginInit();
            LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPicture).BeginInit();
            loupePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LoupePicture).BeginInit();
            SuspendLayout();
            // 
            // PanelHeader
            // 
            PanelHeader.BackColor = Color.White;
            PanelHeader.Controls.Add(LogoPanel);
            PanelHeader.Controls.Add(CartPanel);
            PanelHeader.Controls.Add(AccountPanel);
            PanelHeader.Controls.Add(panelSearchBox);
            PanelHeader.Dock = DockStyle.Top;
            PanelHeader.Location = new Point(0, 0);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new Size(1312, 114);
            PanelHeader.TabIndex = 0;
            // 
            // panelSearchBox
            // 
            panelSearchBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelSearchBox.BackColor = Color.Gainsboro;
            panelSearchBox.Controls.Add(loupePanel);
            panelSearchBox.Location = new Point(298, 10);
            panelSearchBox.Name = "panelSearchBox";
            panelSearchBox.Size = new Size(751, 87);
            panelSearchBox.TabIndex = 1;
            // 
            // navBar
            // 
            navBar.BackColor = Color.WhiteSmoke;
            navBar.Controls.Add(navBarPanel);
            navBar.Dock = DockStyle.Top;
            navBar.Location = new Point(0, 114);
            navBar.Name = "navBar";
            navBar.Size = new Size(1312, 50);
            navBar.TabIndex = 1;
            // 
            // navBarPanel
            // 
            navBarPanel.BackColor = Color.Gainsboro;
            navBarPanel.Dock = DockStyle.Fill;
            navBarPanel.Location = new Point(0, 0);
            navBarPanel.Name = "navBarPanel";
            navBarPanel.Padding = new Padding(20, 10, 0, 0);
            navBarPanel.Size = new Size(1312, 50);
            navBarPanel.TabIndex = 0;
            // 
            // AccountPanel
            // 
            AccountPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AccountPanel.BackColor = Color.Transparent;
            AccountPanel.Controls.Add(AccountPicture);
            AccountPanel.Location = new Point(1181, 19);
            AccountPanel.Name = "AccountPanel";
            AccountPanel.Size = new Size(100, 70);
            AccountPanel.TabIndex = 2;
            // 
            // CartPanel
            // 
            CartPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CartPanel.BackColor = Color.Transparent;
            CartPanel.Controls.Add(CartPicture);
            CartPanel.Location = new Point(1066, 19);
            CartPanel.Name = "CartPanel";
            CartPanel.Size = new Size(100, 70);
            CartPanel.TabIndex = 3;
            // 
            // CartPicture
            // 
            CartPicture.Dock = DockStyle.Fill;
            CartPicture.Image = Properties.Resources.shopping_cart;
            CartPicture.Location = new Point(0, 0);
            CartPicture.Name = "CartPicture";
            CartPicture.Padding = new Padding(2);
            CartPicture.Size = new Size(100, 70);
            CartPicture.SizeMode = PictureBoxSizeMode.Zoom;
            CartPicture.TabIndex = 0;
            CartPicture.TabStop = false;
            // 
            // AccountPicture
            // 
            AccountPicture.Dock = DockStyle.Fill;
            AccountPicture.Image = Properties.Resources.user;
            AccountPicture.Location = new Point(0, 0);
            AccountPicture.Name = "AccountPicture";
            AccountPicture.Size = new Size(100, 70);
            AccountPicture.SizeMode = PictureBoxSizeMode.Zoom;
            AccountPicture.TabIndex = 0;
            AccountPicture.TabStop = false;
            // 
            // LogoPanel
            // 
            LogoPanel.BackColor = Color.Transparent;
            LogoPanel.Controls.Add(LogoPicture);
            LogoPanel.Location = new Point(12, 10);
            LogoPanel.Name = "LogoPanel";
            LogoPanel.Size = new Size(267, 87);
            LogoPanel.TabIndex = 4;
            // 
            // LogoPicture
            // 
            LogoPicture.Dock = DockStyle.Fill;
            LogoPicture.Image = Properties.Resources.Kicks__600_x_100_;
            LogoPicture.Location = new Point(0, 0);
            LogoPicture.Name = "LogoPicture";
            LogoPicture.Size = new Size(267, 87);
            LogoPicture.SizeMode = PictureBoxSizeMode.Zoom;
            LogoPicture.TabIndex = 0;
            LogoPicture.TabStop = false;
            // 
            // loupePanel
            // 
            loupePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            loupePanel.BackColor = Color.Transparent;
            loupePanel.Controls.Add(LoupePicture);
            loupePanel.Location = new Point(16, 9);
            loupePanel.Name = "loupePanel";
            loupePanel.Size = new Size(94, 68);
            loupePanel.TabIndex = 0;
            // 
            // LoupePicture
            // 
            LoupePicture.Dock = DockStyle.Fill;
            LoupePicture.Image = Properties.Resources.loupe;
            LoupePicture.Location = new Point(0, 0);
            LoupePicture.Name = "LoupePicture";
            LoupePicture.Size = new Size(94, 68);
            LoupePicture.SizeMode = PictureBoxSizeMode.Zoom;
            LoupePicture.TabIndex = 0;
            LoupePicture.TabStop = false;
            // 
            // UserMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1312, 640);
            Controls.Add(navBar);
            Controls.Add(PanelHeader);
            Name = "UserMainForm";
            Text = "VistaUsuario";
            PanelHeader.ResumeLayout(false);
            panelSearchBox.ResumeLayout(false);
            navBar.ResumeLayout(false);
            AccountPanel.ResumeLayout(false);
            CartPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CartPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)AccountPicture).EndInit();
            LogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LogoPicture).EndInit();
            loupePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LoupePicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelHeader;
        private Panel navBar;
        private FlowLayoutPanel navBarPanel; // Contenedor para botones de navegación
        private Panel panelSearchBox;
        private Panel CartPanel;
        private Panel AccountPanel;
        private PictureBox CartPicture;
        private PictureBox AccountPicture;
        private Panel LogoPanel;
        private PictureBox LogoPicture;
        private Panel loupePanel;
        private PictureBox LoupePicture;
    }
}

