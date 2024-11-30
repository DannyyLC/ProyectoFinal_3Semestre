﻿using ProyectoProgramacion.Utlis;
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
            UserMenu = new Panel();
            LogOutPanel = new Panel();
            lblLogout = new Label();
            LogoutPicture = new PictureBox();
            ExitMenuPicture = new PictureBox();
            MenuUser = new Label();
            ProductView = new Panel();
            ProductPanel = new Panel();
            PictureRegresar = new PictureBox();
            ProductPicture = new PictureBox();
            ProductButtonsPanel = new Panel();
            btnComprarYa = new CustomeButton();
            btnAgregarCarrito = new CustomeButton();
            ProductDescriptionPanel = new Panel();
            ProductDescription = new RichTextBox();
            ProductMarca = new Label();
            ProductModel = new Label();
            HeaderTableLayoutPanel.SuspendLayout();
            panelSearchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LoupePicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AccountPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CartPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoPicture).BeginInit();
            NavBarTableLayoutPanel.SuspendLayout();
            FooterPanel.SuspendLayout();
            UserMenu.SuspendLayout();
            LogOutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoutPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ExitMenuPicture).BeginInit();
            ProductView.SuspendLayout();
            ProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureRegresar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductPicture).BeginInit();
            ProductButtonsPanel.SuspendLayout();
            ProductDescriptionPanel.SuspendLayout();
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
            HeaderTableLayoutPanel.Size = new Size(1283, 104);
            HeaderTableLayoutPanel.TabIndex = 2;
            // 
            // panelSearchBox
            // 
            panelSearchBox.BackColor = SystemColors.Window;
            panelSearchBox.Controls.Add(LoupePicture);
            panelSearchBox.Controls.Add(SearchBox);
            panelSearchBox.Dock = DockStyle.Fill;
            panelSearchBox.Location = new Point(315, 3);
            panelSearchBox.Name = "panelSearchBox";
            panelSearchBox.Size = new Size(771, 98);
            panelSearchBox.TabIndex = 1;
            // 
            // LoupePicture
            // 
            LoupePicture.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            LoupePicture.BackColor = SystemColors.Window;
            LoupePicture.Cursor = Cursors.Hand;
            LoupePicture.Image = Properties.Resources.loupe;
            LoupePicture.Location = new Point(705, 25);
            LoupePicture.Name = "LoupePicture";
            LoupePicture.Size = new Size(46, 43);
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
            SearchBox.PlaceholderText = "Buscar por marca, modelo, etc.";
            SearchBox.Size = new Size(762, 64);
            SearchBox.TabIndex = 0;
            SearchBox.Texts = "";
            SearchBox.UnderlinedStyle = false;
            // 
            // AccountPicture
            // 
            AccountPicture.Anchor = AnchorStyles.None;
            AccountPicture.Cursor = Cursors.Hand;
            AccountPicture.Image = Properties.Resources.user;
            AccountPicture.Location = new Point(1202, 22);
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
            CartPicture.Image = Properties.Resources.shopping_cart;
            CartPicture.Location = new Point(1100, 22);
            CartPicture.Name = "CartPicture";
            CartPicture.Padding = new Padding(2);
            CartPicture.Size = new Size(80, 59);
            CartPicture.SizeMode = PictureBoxSizeMode.Zoom;
            CartPicture.TabIndex = 0;
            CartPicture.TabStop = false;
            CartPicture.Click += CartPicture_Click;
            // 
            // LogoPicture
            // 
            LogoPicture.Image = Properties.Resources.Kicks__600_x_100_;
            LogoPicture.Location = new Point(0, 0);
            LogoPicture.Margin = new Padding(0);
            LogoPicture.Name = "LogoPicture";
            LogoPicture.Size = new Size(293, 95);
            LogoPicture.SizeMode = PictureBoxSizeMode.Zoom;
            LogoPicture.TabIndex = 0;
            LogoPicture.TabStop = false;
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
            NavBarTableLayoutPanel.Size = new Size(1283, 64);
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
            btnJordan.Location = new Point(412, 3);
            btnJordan.Name = "btnJordan";
            btnJordan.Size = new Size(122, 58);
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
            btnAdidas.Location = new Point(540, 3);
            btnAdidas.Name = "btnAdidas";
            btnAdidas.Size = new Size(109, 58);
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
            btnNovedades.Location = new Point(655, 3);
            btnNovedades.Name = "btnNovedades";
            btnNovedades.Size = new Size(147, 58);
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
            btnDescuento.Location = new Point(808, 3);
            btnDescuento.Name = "btnDescuento";
            btnDescuento.Size = new Size(160, 58);
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
            btnNike.Location = new Point(310, 3);
            btnNike.Name = "btnNike";
            btnNike.Size = new Size(96, 58);
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
            FooterPanel.Location = new Point(0, 674);
            FooterPanel.Name = "FooterPanel";
            FooterPanel.Size = new Size(1283, 29);
            FooterPanel.TabIndex = 4;
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTime.Location = new Point(1170, 3);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(45, 21);
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
            FlowLayoutProducts.Size = new Size(938, 621);
            FlowLayoutProducts.TabIndex = 7;
            // 
            // Timer
            // 
            Timer.Enabled = true;
            Timer.Interval = 1000;
            Timer.Tick += Timer_Tick;
            // 
            // UserMenu
            // 
            UserMenu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UserMenu.BackColor = Color.WhiteSmoke;
            UserMenu.Controls.Add(LogOutPanel);
            UserMenu.Controls.Add(ExitMenuPicture);
            UserMenu.Controls.Add(MenuUser);
            UserMenu.Location = new Point(1038, 0);
            UserMenu.Name = "UserMenu";
            UserMenu.Size = new Size(261, 190);
            UserMenu.TabIndex = 8;
            UserMenu.Visible = false;
            // 
            // LogOutPanel
            // 
            LogOutPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LogOutPanel.Controls.Add(lblLogout);
            LogOutPanel.Controls.Add(LogoutPicture);
            LogOutPanel.Location = new Point(5, 113);
            LogOutPanel.Name = "LogOutPanel";
            LogOutPanel.Size = new Size(201, 42);
            LogOutPanel.TabIndex = 2;
            // 
            // lblLogout
            // 
            lblLogout.AutoSize = true;
            lblLogout.Cursor = Cursors.Hand;
            lblLogout.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogout.Location = new Point(40, 6);
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
            LogoutPicture.Image = Properties.Resources.logout;
            LogoutPicture.Location = new Point(0, 0);
            LogoutPicture.Name = "LogoutPicture";
            LogoutPicture.Size = new Size(34, 42);
            LogoutPicture.SizeMode = PictureBoxSizeMode.Zoom;
            LogoutPicture.TabIndex = 0;
            LogoutPicture.TabStop = false;
            LogoutPicture.Click += LogoutPicture_Click;
            // 
            // ExitMenuPicture
            // 
            ExitMenuPicture.Cursor = Cursors.Hand;
            ExitMenuPicture.Image = Properties.Resources.close;
            ExitMenuPicture.Location = new Point(5, 6);
            ExitMenuPicture.Name = "ExitMenuPicture";
            ExitMenuPicture.Size = new Size(32, 27);
            ExitMenuPicture.SizeMode = PictureBoxSizeMode.Zoom;
            ExitMenuPicture.TabIndex = 1;
            ExitMenuPicture.TabStop = false;
            ExitMenuPicture.Click += ExitMenuPicture_Click;
            // 
            // MenuUser
            // 
            MenuUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            MenuUser.AutoSize = true;
            MenuUser.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuUser.Location = new Point(3, 70);
            MenuUser.Name = "MenuUser";
            MenuUser.Size = new Size(203, 22);
            MenuUser.TabIndex = 0;
            MenuUser.Text = "Nombre de el usuario";
            // 
            // ProductView
            // 
            ProductView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ProductView.Controls.Add(ProductPanel);
            ProductView.Controls.Add(ProductButtonsPanel);
            ProductView.Controls.Add(ProductDescriptionPanel);
            ProductView.Location = new Point(0, 227);
            ProductView.Name = "ProductView";
            ProductView.Size = new Size(1262, 447);
            ProductView.TabIndex = 9;
            ProductView.Visible = false;
            // 
            // ProductPanel
            // 
            ProductPanel.Controls.Add(PictureRegresar);
            ProductPanel.Controls.Add(ProductPicture);
            ProductPanel.Dock = DockStyle.Fill;
            ProductPanel.Location = new Point(0, 0);
            ProductPanel.Name = "ProductPanel";
            ProductPanel.Size = new Size(752, 358);
            ProductPanel.TabIndex = 2;
            // 
            // PictureRegresar
            // 
            PictureRegresar.Location = new Point(12, 16);
            PictureRegresar.Name = "PictureRegresar";
            PictureRegresar.Size = new Size(51, 38);
            PictureRegresar.SizeMode = PictureBoxSizeMode.Zoom;
            PictureRegresar.TabIndex = 1;
            PictureRegresar.TabStop = false;
            PictureRegresar.Click += PictureRegresar_Click;
            // 
            // ProductPicture
            // 
            ProductPicture.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ProductPicture.Location = new Point(69, 28);
            ProductPicture.Name = "ProductPicture";
            ProductPicture.Size = new Size(647, 324);
            ProductPicture.SizeMode = PictureBoxSizeMode.Zoom;
            ProductPicture.TabIndex = 0;
            ProductPicture.TabStop = false;
            // 
            // ProductButtonsPanel
            // 
            ProductButtonsPanel.BackColor = Color.Transparent;
            ProductButtonsPanel.Controls.Add(btnComprarYa);
            ProductButtonsPanel.Controls.Add(btnAgregarCarrito);
            ProductButtonsPanel.Dock = DockStyle.Bottom;
            ProductButtonsPanel.Location = new Point(0, 358);
            ProductButtonsPanel.Name = "ProductButtonsPanel";
            ProductButtonsPanel.Size = new Size(752, 89);
            ProductButtonsPanel.TabIndex = 1;
            // 
            // btnComprarYa
            // 
            btnComprarYa.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnComprarYa.BackColor = SystemColors.InactiveCaptionText;
            btnComprarYa.BackgroundClor = SystemColors.InactiveCaptionText;
            btnComprarYa.BorderColor = Color.PaleVioletRed;
            btnComprarYa.BorderRadius = 40;
            btnComprarYa.BorderSize = 0;
            btnComprarYa.FlatAppearance.BorderSize = 0;
            btnComprarYa.FlatStyle = FlatStyle.Flat;
            btnComprarYa.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComprarYa.ForeColor = SystemColors.ControlLightLight;
            btnComprarYa.Location = new Point(443, 18);
            btnComprarYa.Name = "btnComprarYa";
            btnComprarYa.Size = new Size(237, 58);
            btnComprarYa.TabIndex = 1;
            btnComprarYa.Text = "Comprar Ya";
            btnComprarYa.TextColor = SystemColors.ControlLightLight;
            btnComprarYa.UseVisualStyleBackColor = false;
            // 
            // btnAgregarCarrito
            // 
            btnAgregarCarrito.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAgregarCarrito.BackColor = Color.FromArgb(208, 17, 16);
            btnAgregarCarrito.BackgroundClor = Color.FromArgb(208, 17, 16);
            btnAgregarCarrito.BorderColor = Color.PaleVioletRed;
            btnAgregarCarrito.BorderRadius = 40;
            btnAgregarCarrito.BorderSize = 0;
            btnAgregarCarrito.FlatAppearance.BorderSize = 0;
            btnAgregarCarrito.FlatStyle = FlatStyle.Flat;
            btnAgregarCarrito.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarCarrito.ForeColor = SystemColors.ControlLightLight;
            btnAgregarCarrito.Location = new Point(160, 18);
            btnAgregarCarrito.Name = "btnAgregarCarrito";
            btnAgregarCarrito.Size = new Size(277, 58);
            btnAgregarCarrito.TabIndex = 0;
            btnAgregarCarrito.Text = "Agregar al Carrito";
            btnAgregarCarrito.TextColor = SystemColors.ControlLightLight;
            btnAgregarCarrito.UseVisualStyleBackColor = false;
            // 
            // ProductDescriptionPanel
            // 
            ProductDescriptionPanel.BackColor = Color.Transparent;
            ProductDescriptionPanel.Controls.Add(ProductModel);
            ProductDescriptionPanel.Controls.Add(ProductMarca);
            ProductDescriptionPanel.Controls.Add(ProductDescription);
            ProductDescriptionPanel.Dock = DockStyle.Right;
            ProductDescriptionPanel.Location = new Point(752, 0);
            ProductDescriptionPanel.Name = "ProductDescriptionPanel";
            ProductDescriptionPanel.Size = new Size(510, 447);
            ProductDescriptionPanel.TabIndex = 0;
            // 
            // ProductDescription
            // 
            ProductDescription.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ProductDescription.BorderStyle = BorderStyle.None;
            ProductDescription.Font = new Font("Microsoft Sans Serif", 8.25F);
            ProductDescription.Location = new Point(41, 35);
            ProductDescription.Name = "ProductDescription";
            ProductDescription.Size = new Size(439, 399);
            ProductDescription.TabIndex = 0;
            ProductDescription.Text = "";
            // 
            // ProductMarca
            // 
            ProductMarca.AutoSize = true;
            ProductMarca.Font = new Font("Tahoma", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductMarca.Location = new Point(41, 28);
            ProductMarca.Name = "ProductMarca";
            ProductMarca.Size = new Size(343, 45);
            ProductMarca.TabIndex = 1;
            ProductMarca.Text = "Marca de el Tenis";
            // 
            // ProductModel
            // 
            ProductModel.AutoSize = true;
            ProductModel.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductModel.Location = new Point(41, 97);
            ProductModel.Name = "ProductModel";
            ProductModel.Size = new Size(296, 36);
            ProductModel.TabIndex = 2;
            ProductModel.Text = "Modelo de el Tenis";
            // 
            // UserMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1304, 656);
            Controls.Add(FooterPanel);
            Controls.Add(ProductView);
            Controls.Add(UserMenu);
            Controls.Add(FlowLayoutProducts);
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
            FooterPanel.ResumeLayout(false);
            FooterPanel.PerformLayout();
            UserMenu.ResumeLayout(false);
            UserMenu.PerformLayout();
            LogOutPanel.ResumeLayout(false);
            LogOutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoutPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)ExitMenuPicture).EndInit();
            ProductView.ResumeLayout(false);
            ProductPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureRegresar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductPicture).EndInit();
            ProductButtonsPanel.ResumeLayout(false);
            ProductDescriptionPanel.ResumeLayout(false);
            ProductDescriptionPanel.PerformLayout();
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
        private Panel UserMenu;
        private Label MenuUser;
        private PictureBox ExitMenuPicture;
        private Panel LogOutPanel;
        private Label lblLogout;
        private PictureBox LogoutPicture;
        private Panel ProductView;
        private Panel ProductButtonsPanel;
        private Panel ProductDescriptionPanel;
        private CustomeButton btnComprarYa;
        private CustomeButton btnAgregarCarrito;
        private Panel ProductPanel;
        private PictureBox PictureRegresar;
        private PictureBox ProductPicture;
        private Label ProductModel;
        private Label ProductMarca;
        private RichTextBox ProductDescription;
    }
}

