using ProyectoProgramacion.Utlis;
using System.Drawing;

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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMainForm));
            HeaderTableLayoutPanel = new TableLayoutPanel();
            panelSearchBox = new Panel();
            LoupePicture = new PictureBox();
            SearchBox = new FullCustomTextBox();
            AccountPicture = new PictureBox();
            CartPicture = new PictureBox();
            LogoPicture = new PictureBox();
            NavBarTableLayoutPanel = new TableLayoutPanel();
            btnJordan = new CustomeButton();
            btnAdidas = new CustomeButton();
            btnNovedades = new CustomeButton();
            btnDescuento = new CustomeButton();
            btnNike = new CustomeButton();
            FooterPanel = new Panel();
            lblTime = new Label();
            FlowLayoutProducts = new FlowLayoutPanel();
            Timer = new System.Windows.Forms.Timer(components);
            MenuUser = new Label();
            ExitMenuPicture = new PictureBox();
            LogOutPanel = new Panel();
            lblLogout = new Label();
            LogoutPicture = new PictureBox();
            UserMenu = new Panel();
            HeaderTableLayoutPanel.SuspendLayout();
            panelSearchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LoupePicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AccountPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CartPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoPicture).BeginInit();
            NavBarTableLayoutPanel.SuspendLayout();
            FooterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ExitMenuPicture).BeginInit();
            LogOutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoutPicture).BeginInit();
            UserMenu.SuspendLayout();
            SuspendLayout();
            // 
            // HeaderTableLayoutPanel
            // 
            HeaderTableLayoutPanel.ColumnCount = 4;
            HeaderTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.3902435F));
            HeaderTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.5945129F));
            HeaderTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8F));
            HeaderTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7F));
            HeaderTableLayoutPanel.Controls.Add(panelSearchBox, 1, 0);
            HeaderTableLayoutPanel.Controls.Add(AccountPicture, 3, 0);
            HeaderTableLayoutPanel.Controls.Add(CartPicture, 2, 0);
            HeaderTableLayoutPanel.Controls.Add(LogoPicture, 0, 0);
            HeaderTableLayoutPanel.Dock = DockStyle.Top;
            HeaderTableLayoutPanel.Location = new Point(0, 0);
            HeaderTableLayoutPanel.Name = "HeaderTableLayoutPanel";
            HeaderTableLayoutPanel.RowCount = 1;
            HeaderTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            HeaderTableLayoutPanel.Size = new Size(1309, 104);
            HeaderTableLayoutPanel.TabIndex = 2;
            // 
            // panelSearchBox
            // 
            panelSearchBox.BackColor = SystemColors.Window;
            panelSearchBox.Controls.Add(LoupePicture);
            panelSearchBox.Controls.Add(SearchBox);
            panelSearchBox.Dock = DockStyle.Fill;
            panelSearchBox.Location = new Point(322, 3);
            panelSearchBox.Name = "panelSearchBox";
            panelSearchBox.Size = new Size(787, 98);
            panelSearchBox.TabIndex = 1;
            // 
            // LoupePicture
            // 
            LoupePicture.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            LoupePicture.BackColor = SystemColors.Window;
            LoupePicture.Cursor = Cursors.Hand;
            LoupePicture.Image = IntroductionView.Properties.Resources.loupe;
            LoupePicture.Location = new Point(721, 25);
            LoupePicture.Name = "LoupePicture";
            LoupePicture.Size = new Size(46, 42);
            LoupePicture.SizeMode = PictureBoxSizeMode.Zoom;
            LoupePicture.TabIndex = 0;
            LoupePicture.TabStop = false;
            LoupePicture.Click += LoupePicture_Click;
            // 
            // SearchBox
            // 
            SearchBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SearchBox.BackColor = SystemColors.Window;
            SearchBox.BorderColor = Color.DarkGray;
            SearchBox.BorderFocusColor = Color.FromArgb(208, 17, 16);
            SearchBox.BorderRadius = 30;
            SearchBox.BorderSize = 2;
            SearchBox.Cursor = Cursors.IBeam;
            SearchBox.Font = new Font("Tahoma", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchBox.ForeColor = Color.DimGray;
            SearchBox.Location = new Point(2, 15);
            SearchBox.Multiline = false;
            SearchBox.Name = "SearchBox";
            SearchBox.Padding = new Padding(25, 20, 10, 15);
            SearchBox.PasswordChar = false;
            SearchBox.PlaceholderColor = Color.DarkGray;
            SearchBox.PlaceholderText = "Buscar por modelo";
            SearchBox.Size = new Size(778, 64);
            SearchBox.TabIndex = 0;
            SearchBox.Texts = "";
            SearchBox.UnderlinedStyle = false;
            // 
            // AccountPicture
            // 
            AccountPicture.Anchor = AnchorStyles.None;
            AccountPicture.Cursor = Cursors.Hand;
            AccountPicture.Image = IntroductionView.Properties.Resources.user;
            AccountPicture.Location = new Point(1227, 22);
            AccountPicture.Name = "AccountPicture";
            AccountPicture.Size = new Size(70, 59);
            AccountPicture.SizeMode = PictureBoxSizeMode.Zoom;
            AccountPicture.TabIndex = 0;
            AccountPicture.TabStop = false;
            AccountPicture.Click += AccountPicture_Click;
            // 
            // CartPicture
            // 
            CartPicture.Anchor = AnchorStyles.None;
            CartPicture.Cursor = Cursors.Hand;
            CartPicture.Image = IntroductionView.Properties.Resources.shopping_cart;
            CartPicture.Location = new Point(1124, 22);
            CartPicture.Name = "CartPicture";
            CartPicture.Padding = new Padding(2, 3, 2, 3);
            CartPicture.Size = new Size(80, 59);
            CartPicture.SizeMode = PictureBoxSizeMode.Zoom;
            CartPicture.TabIndex = 0;
            CartPicture.TabStop = false;
            CartPicture.Click += CartPicture_Click;
            // 
            // LogoPicture
            // 
            LogoPicture.Cursor = Cursors.Hand;
            LogoPicture.Image = IntroductionView.Properties.Resources.Kicks__Final__2024_11_23_20_56_34;
            LogoPicture.Location = new Point(0, 0);
            LogoPicture.Margin = new Padding(0);
            LogoPicture.Name = "LogoPicture";
            LogoPicture.Size = new Size(293, 95);
            LogoPicture.SizeMode = PictureBoxSizeMode.Zoom;
            LogoPicture.TabIndex = 0;
            LogoPicture.TabStop = false;
            LogoPicture.Click += LogoPicture_Click;
            // 
            // NavBarTableLayoutPanel
            // 
            NavBarTableLayoutPanel.BackColor = Color.Gainsboro;
            NavBarTableLayoutPanel.ColumnCount = 7;
            NavBarTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24F));
            NavBarTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8F));
            NavBarTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            NavBarTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9F));
            NavBarTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
            NavBarTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13F));
            NavBarTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24F));
            NavBarTableLayoutPanel.Controls.Add(btnJordan, 2, 0);
            NavBarTableLayoutPanel.Controls.Add(btnAdidas, 3, 0);
            NavBarTableLayoutPanel.Controls.Add(btnNovedades, 4, 0);
            NavBarTableLayoutPanel.Controls.Add(btnDescuento, 5, 0);
            NavBarTableLayoutPanel.Controls.Add(btnNike, 1, 0);
            NavBarTableLayoutPanel.Dock = DockStyle.Top;
            NavBarTableLayoutPanel.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NavBarTableLayoutPanel.Location = new Point(0, 104);
            NavBarTableLayoutPanel.Name = "NavBarTableLayoutPanel";
            NavBarTableLayoutPanel.RowCount = 1;
            NavBarTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            NavBarTableLayoutPanel.Size = new Size(1309, 64);
            NavBarTableLayoutPanel.TabIndex = 3;
            // 
            // btnJordan
            // 
            btnJordan.BackColor = Color.Transparent;
            btnJordan.BackgroundClor = Color.Transparent;
            btnJordan.BorderColor = Color.PaleVioletRed;
            btnJordan.BorderRadius = 0;
            btnJordan.BorderSize = 0;
            btnJordan.Cursor = Cursors.Hand;
            btnJordan.Dock = DockStyle.Fill;
            btnJordan.FlatAppearance.BorderSize = 0;
            btnJordan.FlatStyle = FlatStyle.Flat;
            btnJordan.ForeColor = Color.Black;
            btnJordan.Location = new Point(421, 3);
            btnJordan.Name = "btnJordan";
            btnJordan.Size = new Size(124, 58);
            btnJordan.TabIndex = 1;
            btnJordan.Text = "Jordan";
            btnJordan.TextColor = Color.Black;
            btnJordan.UseVisualStyleBackColor = false;
            btnJordan.Click += btnJordan_Click;
            // 
            // btnAdidas
            // 
            btnAdidas.BackColor = Color.Transparent;
            btnAdidas.BackgroundClor = Color.Transparent;
            btnAdidas.BorderColor = Color.PaleVioletRed;
            btnAdidas.BorderRadius = 0;
            btnAdidas.BorderSize = 0;
            btnAdidas.Cursor = Cursors.Hand;
            btnAdidas.Dock = DockStyle.Fill;
            btnAdidas.FlatAppearance.BorderSize = 0;
            btnAdidas.FlatStyle = FlatStyle.Flat;
            btnAdidas.ForeColor = Color.Black;
            btnAdidas.Location = new Point(551, 3);
            btnAdidas.Name = "btnAdidas";
            btnAdidas.Size = new Size(111, 58);
            btnAdidas.TabIndex = 2;
            btnAdidas.Text = "Adidas";
            btnAdidas.TextColor = Color.Black;
            btnAdidas.UseVisualStyleBackColor = false;
            btnAdidas.Click += btnAdidas_Click;
            // 
            // btnNovedades
            // 
            btnNovedades.BackColor = Color.Transparent;
            btnNovedades.BackgroundClor = Color.Transparent;
            btnNovedades.BorderColor = Color.PaleVioletRed;
            btnNovedades.BorderRadius = 0;
            btnNovedades.BorderSize = 0;
            btnNovedades.Cursor = Cursors.Hand;
            btnNovedades.Dock = DockStyle.Fill;
            btnNovedades.FlatAppearance.BorderSize = 0;
            btnNovedades.FlatStyle = FlatStyle.Flat;
            btnNovedades.ForeColor = Color.Black;
            btnNovedades.Location = new Point(668, 3);
            btnNovedades.Name = "btnNovedades";
            btnNovedades.Size = new Size(151, 58);
            btnNovedades.TabIndex = 3;
            btnNovedades.Text = "Novedades";
            btnNovedades.TextColor = Color.Black;
            btnNovedades.UseVisualStyleBackColor = false;
            btnNovedades.Click += btnNovedades_Click;
            // 
            // btnDescuento
            // 
            btnDescuento.BackColor = Color.Transparent;
            btnDescuento.BackgroundClor = Color.Transparent;
            btnDescuento.BorderColor = Color.PaleVioletRed;
            btnDescuento.BorderRadius = 0;
            btnDescuento.BorderSize = 0;
            btnDescuento.Cursor = Cursors.Hand;
            btnDescuento.Dock = DockStyle.Fill;
            btnDescuento.FlatAppearance.BorderSize = 0;
            btnDescuento.FlatStyle = FlatStyle.Flat;
            btnDescuento.ForeColor = Color.FromArgb(208, 17, 16);
            btnDescuento.Location = new Point(825, 3);
            btnDescuento.Name = "btnDescuento";
            btnDescuento.Size = new Size(164, 58);
            btnDescuento.TabIndex = 4;
            btnDescuento.Text = "Descuentos";
            btnDescuento.TextColor = Color.FromArgb(208, 17, 16);
            btnDescuento.UseVisualStyleBackColor = false;
            btnDescuento.Click += btnDescuento_Click;
            // 
            // btnNike
            // 
            btnNike.BackColor = Color.Transparent;
            btnNike.BackgroundClor = Color.Transparent;
            btnNike.BorderColor = Color.PaleVioletRed;
            btnNike.BorderRadius = 0;
            btnNike.BorderSize = 0;
            btnNike.Cursor = Cursors.Hand;
            btnNike.Dock = DockStyle.Fill;
            btnNike.FlatAppearance.BorderSize = 0;
            btnNike.FlatStyle = FlatStyle.Flat;
            btnNike.ForeColor = Color.Black;
            btnNike.Location = new Point(317, 3);
            btnNike.Name = "btnNike";
            btnNike.Size = new Size(98, 58);
            btnNike.TabIndex = 0;
            btnNike.Text = "Nike";
            btnNike.TextColor = Color.Black;
            btnNike.UseVisualStyleBackColor = false;
            btnNike.Click += btnNike_Click;
            // 
            // FooterPanel
            // 
            FooterPanel.BackColor = Color.Gainsboro;
            FooterPanel.Controls.Add(lblTime);
            FooterPanel.Dock = DockStyle.Bottom;
            FooterPanel.Location = new Point(0, 668);
            FooterPanel.Name = "FooterPanel";
            FooterPanel.Size = new Size(1309, 29);
            FooterPanel.TabIndex = 4;
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTime.Location = new Point(1195, 3);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(47, 22);
            lblTime.TabIndex = 0;
            lblTime.Text = "Hora";
            // 
            // FlowLayoutProducts
            // 
            FlowLayoutProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FlowLayoutProducts.AutoScroll = true;
            FlowLayoutProducts.BackColor = SystemColors.Window;
            FlowLayoutProducts.Location = new Point(162, 168);
            FlowLayoutProducts.Name = "FlowLayoutProducts";
            FlowLayoutProducts.Size = new Size(943, 495);
            FlowLayoutProducts.TabIndex = 7;
            // 
            // Timer
            // 
            Timer.Enabled = true;
            Timer.Interval = 1000;
            Timer.Tick += Timer_Tick;
            // 
            // MenuUser
            // 
            MenuUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            MenuUser.AutoSize = true;
            MenuUser.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuUser.Location = new Point(3, 69);
            MenuUser.Name = "MenuUser";
            MenuUser.Size = new Size(203, 22);
            MenuUser.TabIndex = 0;
            MenuUser.Text = "Nombre de el usuario";
            // 
            // ExitMenuPicture
            // 
            ExitMenuPicture.Cursor = Cursors.Hand;
            ExitMenuPicture.Image = IntroductionView.Properties.Resources.close;
            ExitMenuPicture.Location = new Point(5, 5);
            ExitMenuPicture.Name = "ExitMenuPicture";
            ExitMenuPicture.Size = new Size(32, 27);
            ExitMenuPicture.SizeMode = PictureBoxSizeMode.Zoom;
            ExitMenuPicture.TabIndex = 1;
            ExitMenuPicture.TabStop = false;
            ExitMenuPicture.Click += ExitMenuPicture_Click;
            // 
            // LogOutPanel
            // 
            LogOutPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LogOutPanel.Controls.Add(lblLogout);
            LogOutPanel.Controls.Add(LogoutPicture);
            LogOutPanel.Location = new Point(5, 113);
            LogOutPanel.Name = "LogOutPanel";
            LogOutPanel.Size = new Size(201, 43);
            LogOutPanel.TabIndex = 2;
            // 
            // lblLogout
            // 
            lblLogout.AutoSize = true;
            lblLogout.Cursor = Cursors.Hand;
            lblLogout.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogout.Location = new Point(40, 5);
            lblLogout.Name = "lblLogout";
            lblLogout.Size = new Size(103, 28);
            lblLogout.TabIndex = 1;
            lblLogout.Text = "Log Out";
            lblLogout.Click += lblLogout_Click;
            // 
            // LogoutPicture
            // 
            LogoutPicture.Cursor = Cursors.Hand;
            LogoutPicture.Dock = DockStyle.Left;
            LogoutPicture.Image = IntroductionView.Properties.Resources.logout;
            LogoutPicture.Location = new Point(0, 0);
            LogoutPicture.Name = "LogoutPicture";
            LogoutPicture.Size = new Size(34, 43);
            LogoutPicture.SizeMode = PictureBoxSizeMode.Zoom;
            LogoutPicture.TabIndex = 0;
            LogoutPicture.TabStop = false;
            LogoutPicture.Click += LogoutPicture_Click;
            // 
            // UserMenu
            // 
            UserMenu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UserMenu.BackColor = Color.WhiteSmoke;
            UserMenu.Controls.Add(LogOutPanel);
            UserMenu.Controls.Add(ExitMenuPicture);
            UserMenu.Controls.Add(MenuUser);
            UserMenu.Location = new Point(1042, 0);
            UserMenu.Name = "UserMenu";
            UserMenu.Size = new Size(267, 189);
            UserMenu.TabIndex = 8;
            UserMenu.Visible = false;
            // 
            // UserMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1309, 697);
            Controls.Add(FooterPanel);
            Controls.Add(UserMenu);
            Controls.Add(FlowLayoutProducts);
            Controls.Add(NavBarTableLayoutPanel);
            Controls.Add(HeaderTableLayoutPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UserMainForm";
            Text = "KICK5";
            Layout += UserMainForm_Layout;
            HeaderTableLayoutPanel.ResumeLayout(false);
            panelSearchBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LoupePicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)AccountPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)CartPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoPicture).EndInit();
            NavBarTableLayoutPanel.ResumeLayout(false);
            FooterPanel.ResumeLayout(false);
            FooterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ExitMenuPicture).EndInit();
            LogOutPanel.ResumeLayout(false);
            LogOutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoutPicture).EndInit();
            UserMenu.ResumeLayout(false);
            UserMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel HeaderTableLayoutPanel;
        private PictureBox AccountPicture;
        private PictureBox LogoPicture;
        private PictureBox CartPicture;
        private Panel panelSearchBox;
        private PictureBox LoupePicture;
        private FullCustomTextBox SearchBox;
        private TableLayoutPanel NavBarTableLayoutPanel;
        private CustomeButton btnNike;
        private CustomeButton btnJordan;
        private CustomeButton btnAdidas;
        private CustomeButton btnNovedades;
        private CustomeButton btnDescuento;
        private Panel FooterPanel;
        private FlowLayoutPanel FlowLayoutProducts;
        private Label lblTime;
        private System.Windows.Forms.Timer Timer;
        private Label MenuUser;
        private PictureBox ExitMenuPicture;
        private Panel LogOutPanel;
        private Label lblLogout;
        private PictureBox LogoutPicture;
        private Panel UserMenu;
    }
}

