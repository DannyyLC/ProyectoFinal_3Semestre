namespace ProyectoProgramacion.Views
{
    partial class CartForm
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
            HeaderTablePanel = new TableLayoutPanel();
            LogoPicture = new PictureBox();
            SearchBox = new Utlis.FullCustomTextBox();
            CartPicture = new PictureBox();
            UserPicture = new PictureBox();
            LoupePicture = new PictureBox();
            NavBarTableLayoutPanel = new TableLayoutPanel();
            btnJordan = new Utlis.CustomeButton();
            btnAdidas = new Utlis.CustomeButton();
            btnNovedades = new Utlis.CustomeButton();
            btnDescuento = new Utlis.CustomeButton();
            btnNike = new Utlis.CustomeButton();
            HeaderTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CartPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UserPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LoupePicture).BeginInit();
            NavBarTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // HeaderTablePanel
            // 
            HeaderTablePanel.ColumnCount = 4;
            HeaderTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            HeaderTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            HeaderTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8F));
            HeaderTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7F));
            HeaderTablePanel.Controls.Add(SearchBox, 1, 0);
            HeaderTablePanel.Controls.Add(UserPicture, 3, 0);
            HeaderTablePanel.Controls.Add(CartPicture, 2, 0);
            HeaderTablePanel.Controls.Add(LogoPicture, 0, 0);
            HeaderTablePanel.Dock = DockStyle.Top;
            HeaderTablePanel.Location = new Point(0, 0);
            HeaderTablePanel.Name = "HeaderTablePanel";
            HeaderTablePanel.RowCount = 1;
            HeaderTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            HeaderTablePanel.Size = new Size(1293, 104);
            HeaderTablePanel.TabIndex = 0;
            // 
            // LogoPicture
            // 
            LogoPicture.Image = Properties.Resources.Kicks__600_x_100_;
            LogoPicture.Location = new Point(3, 3);
            LogoPicture.Name = "LogoPicture";
            LogoPicture.Size = new Size(293, 95);
            LogoPicture.SizeMode = PictureBoxSizeMode.Zoom;
            LogoPicture.TabIndex = 0;
            LogoPicture.TabStop = false;
            // 
            // SearchBox
            // 
            SearchBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SearchBox.BackColor = SystemColors.Window;
            SearchBox.BorderColor = Color.DarkGray;
            SearchBox.BorderFocusColor = Color.FromArgb(208, 17, 16);
            SearchBox.BorderRadius = 30;
            SearchBox.BorderSize = 2;
            SearchBox.Cursor = Cursors.IBeam;
            SearchBox.Font = new Font("Tahoma", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchBox.ForeColor = Color.DimGray;
            SearchBox.Location = new Point(326, 20);
            SearchBox.Multiline = false;
            SearchBox.Name = "SearchBox";
            SearchBox.Padding = new Padding(25, 20, 10, 15);
            SearchBox.PasswordChar = false;
            SearchBox.PlaceholderColor = Color.DarkGray;
            SearchBox.PlaceholderText = "Buscar por marca, modelo, etc.";
            SearchBox.Size = new Size(769, 64);
            SearchBox.TabIndex = 1;
            SearchBox.Texts = "";
            SearchBox.UnderlinedStyle = false;
            // 
            // CartPicture
            // 
            CartPicture.Anchor = AnchorStyles.None;
            CartPicture.Cursor = Cursors.Hand;
            CartPicture.Image = Properties.Resources.shopping_cart;
            CartPicture.Location = new Point(1109, 22);
            CartPicture.Name = "CartPicture";
            CartPicture.Size = new Size(80, 59);
            CartPicture.SizeMode = PictureBoxSizeMode.Zoom;
            CartPicture.TabIndex = 2;
            CartPicture.TabStop = false;
            // 
            // UserPicture
            // 
            UserPicture.Anchor = AnchorStyles.None;
            UserPicture.Cursor = Cursors.Hand;
            UserPicture.Image = Properties.Resources.user;
            UserPicture.Location = new Point(1212, 22);
            UserPicture.Name = "UserPicture";
            UserPicture.Size = new Size(70, 59);
            UserPicture.SizeMode = PictureBoxSizeMode.Zoom;
            UserPicture.TabIndex = 3;
            UserPicture.TabStop = false;
            // 
            // LoupePicture
            // 
            LoupePicture.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            LoupePicture.Cursor = Cursors.Hand;
            LoupePicture.Image = Properties.Resources.loupe;
            LoupePicture.Location = new Point(1040, 31);
            LoupePicture.Name = "LoupePicture";
            LoupePicture.Size = new Size(46, 43);
            LoupePicture.SizeMode = PictureBoxSizeMode.Zoom;
            LoupePicture.TabIndex = 1;
            LoupePicture.TabStop = false;
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
            NavBarTableLayoutPanel.Size = new Size(1293, 64);
            NavBarTableLayoutPanel.TabIndex = 4;
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
            btnJordan.Location = new Point(416, 3);
            btnJordan.Name = "btnJordan";
            btnJordan.Size = new Size(123, 58);
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
            btnAdidas.Cursor = Cursors.Hand;
            btnAdidas.Dock = DockStyle.Fill;
            btnAdidas.FlatAppearance.BorderSize = 0;
            btnAdidas.FlatStyle = FlatStyle.Flat;
            btnAdidas.ForeColor = Color.Black;
            btnAdidas.Location = new Point(545, 3);
            btnAdidas.Name = "btnAdidas";
            btnAdidas.Size = new Size(110, 58);
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
            btnNovedades.Cursor = Cursors.Hand;
            btnNovedades.Dock = DockStyle.Fill;
            btnNovedades.FlatAppearance.BorderSize = 0;
            btnNovedades.FlatStyle = FlatStyle.Flat;
            btnNovedades.ForeColor = Color.Black;
            btnNovedades.Location = new Point(661, 3);
            btnNovedades.Name = "btnNovedades";
            btnNovedades.Size = new Size(149, 58);
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
            btnDescuento.Cursor = Cursors.Hand;
            btnDescuento.Dock = DockStyle.Fill;
            btnDescuento.FlatAppearance.BorderSize = 0;
            btnDescuento.FlatStyle = FlatStyle.Flat;
            btnDescuento.ForeColor = Color.FromArgb(208, 17, 16);
            btnDescuento.Location = new Point(816, 3);
            btnDescuento.Name = "btnDescuento";
            btnDescuento.Size = new Size(162, 58);
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
            btnNike.Cursor = Cursors.Hand;
            btnNike.Dock = DockStyle.Fill;
            btnNike.FlatAppearance.BorderSize = 0;
            btnNike.FlatStyle = FlatStyle.Flat;
            btnNike.ForeColor = Color.Black;
            btnNike.Location = new Point(313, 3);
            btnNike.Name = "btnNike";
            btnNike.Size = new Size(97, 58);
            btnNike.TabIndex = 0;
            btnNike.Text = "Nike";
            btnNike.TextColor = Color.Black;
            btnNike.UseVisualStyleBackColor = false;
            // 
            // CartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1293, 657);
            Controls.Add(NavBarTableLayoutPanel);
            Controls.Add(LoupePicture);
            Controls.Add(HeaderTablePanel);
            Name = "CartForm";
            Text = "CartForm";
            Load += CartForm_Load;
            HeaderTablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LogoPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)CartPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)UserPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)LoupePicture).EndInit();
            NavBarTableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel HeaderTablePanel;
        private PictureBox LogoPicture;
        private Utlis.FullCustomTextBox SearchBox;
        private PictureBox CartPicture;
        private PictureBox UserPicture;
        private PictureBox LoupePicture;
        private TableLayoutPanel NavBarTableLayoutPanel;
        private Utlis.CustomeButton btnJordan;
        private Utlis.CustomeButton btnAdidas;
        private Utlis.CustomeButton btnNovedades;
        private Utlis.CustomeButton btnDescuento;
        private Utlis.CustomeButton btnNike;
    }
}