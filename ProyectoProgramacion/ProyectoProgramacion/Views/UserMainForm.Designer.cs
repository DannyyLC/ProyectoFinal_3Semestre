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
            HeaderTableLayoutPanel.SuspendLayout();
            panelSearchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LoupePicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AccountPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CartPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoPicture).BeginInit();
            NavBarTableLayoutPanel.SuspendLayout();
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
            HeaderTableLayoutPanel.Size = new Size(1312, 104);
            HeaderTableLayoutPanel.TabIndex = 2;
            // 
            // panelSearchBox
            // 
            panelSearchBox.BackColor = SystemColors.Window;
            panelSearchBox.Controls.Add(LoupePicture);
            panelSearchBox.Controls.Add(SearchBox);
            panelSearchBox.Dock = DockStyle.Fill;
            panelSearchBox.Location = new Point(323, 3);
            panelSearchBox.Name = "panelSearchBox";
            panelSearchBox.Size = new Size(789, 98);
            panelSearchBox.TabIndex = 1;
            // 
            // LoupePicture
            // 
            LoupePicture.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            LoupePicture.BackColor = SystemColors.Window;
            LoupePicture.Image = Properties.Resources.loupe;
            LoupePicture.Location = new Point(705, 23);
            LoupePicture.Name = "LoupePicture";
            LoupePicture.Size = new Size(46, 43);
            LoupePicture.SizeMode = PictureBoxSizeMode.Zoom;
            LoupePicture.TabIndex = 0;
            LoupePicture.TabStop = false;
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
            SearchBox.PlaceholderText = "Buscar por marca, modelo, etc.";
            SearchBox.Size = new Size(780, 64);
            SearchBox.TabIndex = 0;
            SearchBox.Texts = "";
            SearchBox.UnderlinedStyle = false;
            // 
            // AccountPicture
            // 
            AccountPicture.Anchor = AnchorStyles.None;
            AccountPicture.Cursor = Cursors.Hand;
            AccountPicture.Image = Properties.Resources.user;
            AccountPicture.Location = new Point(1230, 22);
            AccountPicture.Name = "AccountPicture";
            AccountPicture.Size = new Size(70, 59);
            AccountPicture.SizeMode = PictureBoxSizeMode.Zoom;
            AccountPicture.TabIndex = 0;
            AccountPicture.TabStop = false;
            // 
            // CartPicture
            // 
            CartPicture.Anchor = AnchorStyles.None;
            CartPicture.Cursor = Cursors.Hand;
            CartPicture.Image = Properties.Resources.shopping_cart;
            CartPicture.Location = new Point(1127, 22);
            CartPicture.Name = "CartPicture";
            CartPicture.Padding = new Padding(2);
            CartPicture.Size = new Size(80, 59);
            CartPicture.SizeMode = PictureBoxSizeMode.Zoom;
            CartPicture.TabIndex = 0;
            CartPicture.TabStop = false;
            // 
            // LogoPicture
            // 
            LogoPicture.Image = Properties.Resources.Kicks__600_x_100_;
            LogoPicture.Location = new Point(3, 3);
            LogoPicture.Margin = new Padding(3, 3, 15, 3);
            LogoPicture.Name = "LogoPicture";
            LogoPicture.Size = new Size(298, 95);
            LogoPicture.SizeMode = PictureBoxSizeMode.Zoom;
            LogoPicture.TabIndex = 0;
            LogoPicture.TabStop = false;
            // 
            // NavBarTableLayoutPanel
            // 
            NavBarTableLayoutPanel.BackColor = Color.WhiteSmoke;
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
            NavBarTableLayoutPanel.Size = new Size(1312, 64);
            NavBarTableLayoutPanel.TabIndex = 3;
            // 
            // btnJordan
            // 
            btnJordan.BackColor = Color.Transparent;
            btnJordan.BackgroundClor = Color.Transparent;
            btnJordan.BorderColor = Color.PaleVioletRed;
            btnJordan.BorderRadius = 0;
            btnJordan.BorderSize = 0;
            btnJordan.Dock = DockStyle.Fill;
            btnJordan.FlatAppearance.BorderSize = 0;
            btnJordan.FlatStyle = FlatStyle.Flat;
            btnJordan.ForeColor = Color.Black;
            btnJordan.Location = new Point(421, 3);
            btnJordan.Name = "btnJordan";
            btnJordan.Size = new Size(125, 58);
            btnJordan.TabIndex = 1;
            btnJordan.Text = "Jordan";
            btnJordan.TextColor = Color.Black;
            btnJordan.UseVisualStyleBackColor = false;
            // 
            // btnAdidas
            // 
            btnAdidas.BackColor = Color.Transparent;
            btnAdidas.BackgroundClor = Color.Transparent;
            btnAdidas.BorderColor = Color.PaleVioletRed;
            btnAdidas.BorderRadius = 0;
            btnAdidas.BorderSize = 0;
            btnAdidas.Dock = DockStyle.Fill;
            btnAdidas.FlatAppearance.BorderSize = 0;
            btnAdidas.FlatStyle = FlatStyle.Flat;
            btnAdidas.ForeColor = Color.Black;
            btnAdidas.Location = new Point(552, 3);
            btnAdidas.Name = "btnAdidas";
            btnAdidas.Size = new Size(112, 58);
            btnAdidas.TabIndex = 2;
            btnAdidas.Text = "Adidas";
            btnAdidas.TextColor = Color.Black;
            btnAdidas.UseVisualStyleBackColor = false;
            // 
            // btnNovedades
            // 
            btnNovedades.BackColor = Color.Transparent;
            btnNovedades.BackgroundClor = Color.Transparent;
            btnNovedades.BorderColor = Color.PaleVioletRed;
            btnNovedades.BorderRadius = 0;
            btnNovedades.BorderSize = 0;
            btnNovedades.Dock = DockStyle.Fill;
            btnNovedades.FlatAppearance.BorderSize = 0;
            btnNovedades.FlatStyle = FlatStyle.Flat;
            btnNovedades.ForeColor = Color.Black;
            btnNovedades.Location = new Point(670, 3);
            btnNovedades.Name = "btnNovedades";
            btnNovedades.Size = new Size(151, 58);
            btnNovedades.TabIndex = 3;
            btnNovedades.Text = "Novedades";
            btnNovedades.TextColor = Color.Black;
            btnNovedades.UseVisualStyleBackColor = false;
            // 
            // btnDescuento
            // 
            btnDescuento.BackColor = Color.Transparent;
            btnDescuento.BackgroundClor = Color.Transparent;
            btnDescuento.BorderColor = Color.PaleVioletRed;
            btnDescuento.BorderRadius = 0;
            btnDescuento.BorderSize = 0;
            btnDescuento.Dock = DockStyle.Fill;
            btnDescuento.FlatAppearance.BorderSize = 0;
            btnDescuento.FlatStyle = FlatStyle.Flat;
            btnDescuento.ForeColor = Color.FromArgb(208, 17, 16);
            btnDescuento.Location = new Point(827, 3);
            btnDescuento.Name = "btnDescuento";
            btnDescuento.Size = new Size(164, 58);
            btnDescuento.TabIndex = 4;
            btnDescuento.Text = "Descuentos";
            btnDescuento.TextColor = Color.FromArgb(208, 17, 16);
            btnDescuento.UseVisualStyleBackColor = false;
            // 
            // btnNike
            // 
            btnNike.BackColor = Color.Transparent;
            btnNike.BackgroundClor = Color.Transparent;
            btnNike.BorderColor = Color.PaleVioletRed;
            btnNike.BorderRadius = 0;
            btnNike.BorderSize = 0;
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
            // 
            // UserMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1312, 640);
            Controls.Add(NavBarTableLayoutPanel);
            Controls.Add(HeaderTableLayoutPanel);
            Name = "UserMainForm";
            Text = "VistaUsuario";
            Layout += UserMainForm_Layout;
            HeaderTableLayoutPanel.ResumeLayout(false);
            panelSearchBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LoupePicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)AccountPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)CartPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoPicture).EndInit();
            NavBarTableLayoutPanel.ResumeLayout(false);
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
    }
}

