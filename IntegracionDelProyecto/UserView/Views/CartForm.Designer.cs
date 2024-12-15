﻿namespace ProyectoProgramacion.Views
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartForm));
            HeaderTable = new TableLayoutPanel();
            UserPanel = new Panel();
            MenuPanel = new Panel();
            lblNombre = new Label();
            LogOutPanel = new Panel();
            lblLogOut = new Label();
            LogoutPicture = new PictureBox();
            ExitPicture = new PictureBox();
            UserPicture = new PictureBox();
            LogoPicture = new PictureBox();
            TitlelLabel = new Label();
            FooterPanel = new Panel();
            lblTime = new Label();
            TablePago = new TableLayoutPanel();
            btnPagar = new Utlis.CustomeButton();
            LabelMetodoPago = new Label();
            lblEmail = new Label();
            lblDatosTarjeta = new Label();
            lblTitular = new Label();
            txtEmail = new Utlis.FullCustomTextBox();
            txtTitular = new Utlis.FullCustomTextBox();
            tableDatosTarjeta = new TableLayoutPanel();
            txtFecha = new Utlis.FullCustomTextBox();
            txtNumeroTarjeta = new Utlis.FullCustomTextBox();
            txtCVC = new Utlis.FullCustomTextBox();
            panelTargetasimg = new Panel();
            MCPicture = new PictureBox();
            VisaPicture = new PictureBox();
            TarjetaPicture = new PictureBox();
            TableProducts = new TableLayoutPanel();
            Timer = new System.Windows.Forms.Timer(components);
            HeaderTable.SuspendLayout();
            UserPanel.SuspendLayout();
            MenuPanel.SuspendLayout();
            LogOutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoutPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ExitPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UserPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoPicture).BeginInit();
            FooterPanel.SuspendLayout();
            TablePago.SuspendLayout();
            tableDatosTarjeta.SuspendLayout();
            panelTargetasimg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MCPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VisaPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TarjetaPicture).BeginInit();
            SuspendLayout();
            // 
            // HeaderTable
            // 
            HeaderTable.BackColor = Color.LightGray;
            HeaderTable.ColumnCount = 3;
            HeaderTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.58314F));
            HeaderTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.3085861F));
            HeaderTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            HeaderTable.Controls.Add(UserPanel, 2, 0);
            HeaderTable.Controls.Add(LogoPicture, 0, 0);
            HeaderTable.Controls.Add(TitlelLabel, 1, 0);
            HeaderTable.Dock = DockStyle.Top;
            HeaderTable.Location = new Point(0, 0);
            HeaderTable.Name = "HeaderTable";
            HeaderTable.RowCount = 1;
            HeaderTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            HeaderTable.Size = new Size(1293, 113);
            HeaderTable.TabIndex = 0;
            // 
            // UserPanel
            // 
            UserPanel.BackColor = Color.Gainsboro;
            UserPanel.Controls.Add(MenuPanel);
            UserPanel.Controls.Add(UserPicture);
            UserPanel.Dock = DockStyle.Fill;
            UserPanel.Location = new Point(1036, 3);
            UserPanel.Name = "UserPanel";
            UserPanel.Size = new Size(254, 107);
            UserPanel.TabIndex = 0;
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = Color.WhiteSmoke;
            MenuPanel.Controls.Add(lblNombre);
            MenuPanel.Controls.Add(LogOutPanel);
            MenuPanel.Controls.Add(ExitPicture);
            MenuPanel.Dock = DockStyle.Fill;
            MenuPanel.Location = new Point(0, 0);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(254, 107);
            MenuPanel.TabIndex = 3;
            MenuPanel.Visible = false;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(0, 34);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(203, 22);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre de el usuario";
            // 
            // LogOutPanel
            // 
            LogOutPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LogOutPanel.Controls.Add(lblLogOut);
            LogOutPanel.Controls.Add(LogoutPicture);
            LogOutPanel.Location = new Point(3, 62);
            LogOutPanel.Name = "LogOutPanel";
            LogOutPanel.Size = new Size(201, 43);
            LogOutPanel.TabIndex = 3;
            LogOutPanel.Click += LogOutPanel_Click;
            // 
            // lblLogOut
            // 
            lblLogOut.AutoSize = true;
            lblLogOut.Cursor = Cursors.Hand;
            lblLogOut.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogOut.Location = new Point(40, 5);
            lblLogOut.Name = "lblLogOut";
            lblLogOut.Size = new Size(103, 28);
            lblLogOut.TabIndex = 1;
            lblLogOut.Text = "Log Out";
            lblLogOut.Click += lblLogOut_Click;
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
            // ExitPicture
            // 
            ExitPicture.Cursor = Cursors.Hand;
            ExitPicture.Image = IntroductionView.Properties.Resources.close;
            ExitPicture.Location = new Point(3, 3);
            ExitPicture.Name = "ExitPicture";
            ExitPicture.Size = new Size(32, 27);
            ExitPicture.SizeMode = PictureBoxSizeMode.Zoom;
            ExitPicture.TabIndex = 2;
            ExitPicture.TabStop = false;
            ExitPicture.Click += ExitPicture_Click;
            // 
            // UserPicture
            // 
            UserPicture.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UserPicture.BackColor = Color.Transparent;
            UserPicture.Image = IntroductionView.Properties.Resources.user1;
            UserPicture.Location = new Point(93, 21);
            UserPicture.Name = "UserPicture";
            UserPicture.Size = new Size(72, 62);
            UserPicture.SizeMode = PictureBoxSizeMode.Zoom;
            UserPicture.TabIndex = 1;
            UserPicture.TabStop = false;
            UserPicture.Click += UserPicture_Click;
            // 
            // LogoPicture
            // 
            LogoPicture.Cursor = Cursors.Hand;
            LogoPicture.Dock = DockStyle.Fill;
            LogoPicture.Image = (Image)resources.GetObject("LogoPicture.Image");
            LogoPicture.Location = new Point(3, 3);
            LogoPicture.Name = "LogoPicture";
            LogoPicture.Size = new Size(286, 107);
            LogoPicture.SizeMode = PictureBoxSizeMode.Zoom;
            LogoPicture.TabIndex = 0;
            LogoPicture.TabStop = false;
            LogoPicture.Click += LogoPicture_Click;
            // 
            // TitlelLabel
            // 
            TitlelLabel.AutoSize = true;
            TitlelLabel.BackColor = Color.Gainsboro;
            TitlelLabel.Dock = DockStyle.Fill;
            TitlelLabel.Font = new Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitlelLabel.Location = new Point(295, 0);
            TitlelLabel.Name = "TitlelLabel";
            TitlelLabel.Size = new Size(735, 113);
            TitlelLabel.TabIndex = 2;
            TitlelLabel.Text = "CARRITO";
            TitlelLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FooterPanel
            // 
            FooterPanel.BackColor = Color.LightGray;
            FooterPanel.Controls.Add(lblTime);
            FooterPanel.Dock = DockStyle.Bottom;
            FooterPanel.Location = new Point(0, 634);
            FooterPanel.Name = "FooterPanel";
            FooterPanel.Size = new Size(1293, 23);
            FooterPanel.TabIndex = 1;
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTime.Location = new Point(605, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(47, 22);
            lblTime.TabIndex = 0;
            lblTime.Text = "Hora";
            // 
            // TablePago
            // 
            TablePago.BackColor = Color.WhiteSmoke;
            TablePago.ColumnCount = 1;
            TablePago.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TablePago.Controls.Add(btnPagar, 0, 7);
            TablePago.Controls.Add(LabelMetodoPago, 0, 0);
            TablePago.Controls.Add(lblEmail, 0, 1);
            TablePago.Controls.Add(lblDatosTarjeta, 0, 3);
            TablePago.Controls.Add(lblTitular, 0, 5);
            TablePago.Controls.Add(txtEmail, 0, 2);
            TablePago.Controls.Add(txtTitular, 0, 6);
            TablePago.Controls.Add(tableDatosTarjeta, 0, 4);
            TablePago.Dock = DockStyle.Right;
            TablePago.Location = new Point(746, 113);
            TablePago.Name = "TablePago";
            TablePago.RowCount = 8;
            TablePago.RowStyles.Add(new RowStyle(SizeType.Percent, 13F));
            TablePago.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            TablePago.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            TablePago.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            TablePago.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TablePago.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            TablePago.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            TablePago.RowStyles.Add(new RowStyle(SizeType.Percent, 32F));
            TablePago.Size = new Size(547, 521);
            TablePago.TabIndex = 2;
            // 
            // btnPagar
            // 
            btnPagar.Anchor = AnchorStyles.Top;
            btnPagar.BackColor = SystemColors.ActiveCaptionText;
            btnPagar.BackgroundClor = SystemColors.ActiveCaptionText;
            btnPagar.BorderColor = Color.PaleVioletRed;
            btnPagar.BorderRadius = 17;
            btnPagar.BorderSize = 0;
            btnPagar.Cursor = Cursors.Hand;
            btnPagar.FlatAppearance.BorderSize = 0;
            btnPagar.FlatStyle = FlatStyle.Flat;
            btnPagar.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPagar.ForeColor = Color.White;
            btnPagar.Location = new Point(146, 354);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(255, 55);
            btnPagar.TabIndex = 1;
            btnPagar.Text = "Pagar";
            btnPagar.TextColor = Color.White;
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // LabelMetodoPago
            // 
            LabelMetodoPago.AutoSize = true;
            LabelMetodoPago.Dock = DockStyle.Fill;
            LabelMetodoPago.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelMetodoPago.Location = new Point(3, 0);
            LabelMetodoPago.Name = "LabelMetodoPago";
            LabelMetodoPago.Size = new Size(541, 67);
            LabelMetodoPago.TabIndex = 2;
            LabelMetodoPago.Text = "Metodo de Pago";
            LabelMetodoPago.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            lblEmail.Location = new Point(3, 75);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(85, 28);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "E-Mail";
            // 
            // lblDatosTarjeta
            // 
            lblDatosTarjeta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDatosTarjeta.AutoSize = true;
            lblDatosTarjeta.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            lblDatosTarjeta.Location = new Point(3, 144);
            lblDatosTarjeta.Name = "lblDatosTarjeta";
            lblDatosTarjeta.Size = new Size(229, 26);
            lblDatosTarjeta.TabIndex = 4;
            lblDatosTarjeta.Text = "Datos de la tarjeta";
            // 
            // lblTitular
            // 
            lblTitular.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTitular.AutoSize = true;
            lblTitular.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            lblTitular.Location = new Point(3, 282);
            lblTitular.Name = "lblTitular";
            lblTitular.Size = new Size(231, 28);
            lblTitular.TabIndex = 5;
            lblTitular.Text = "Nombre del Titular";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.Window;
            txtEmail.BorderColor = Color.DarkGray;
            txtEmail.BorderFocusColor = Color.FromArgb(208, 17, 16);
            txtEmail.BorderRadius = 7;
            txtEmail.BorderSize = 2;
            txtEmail.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.DimGray;
            txtEmail.Location = new Point(3, 106);
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(7);
            txtEmail.PasswordChar = false;
            txtEmail.PlaceholderColor = Color.DarkGray;
            txtEmail.PlaceholderText = "ejemplo@gmail.com";
            txtEmail.Size = new Size(401, 39);
            txtEmail.TabIndex = 6;
            txtEmail.Texts = "";
            txtEmail.UnderlinedStyle = false;
            // 
            // txtTitular
            // 
            txtTitular.BackColor = SystemColors.Window;
            txtTitular.BorderColor = Color.DarkGray;
            txtTitular.BorderFocusColor = Color.FromArgb(208, 17, 16);
            txtTitular.BorderRadius = 7;
            txtTitular.BorderSize = 2;
            txtTitular.Dock = DockStyle.Fill;
            txtTitular.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitular.ForeColor = Color.DimGray;
            txtTitular.Location = new Point(3, 313);
            txtTitular.Multiline = false;
            txtTitular.Name = "txtTitular";
            txtTitular.Padding = new Padding(7);
            txtTitular.PasswordChar = false;
            txtTitular.PlaceholderColor = Color.DarkGray;
            txtTitular.PlaceholderText = "Nombre de el Titular de la Tarjeta";
            txtTitular.Size = new Size(541, 39);
            txtTitular.TabIndex = 7;
            txtTitular.Texts = "";
            txtTitular.UnderlinedStyle = false;
            // 
            // tableDatosTarjeta
            // 
            tableDatosTarjeta.ColumnCount = 3;
            tableDatosTarjeta.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.00315F));
            tableDatosTarjeta.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.9968452F));
            tableDatosTarjeta.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 139F));
            tableDatosTarjeta.Controls.Add(txtFecha, 0, 1);
            tableDatosTarjeta.Controls.Add(txtNumeroTarjeta, 0, 0);
            tableDatosTarjeta.Controls.Add(txtCVC, 1, 1);
            tableDatosTarjeta.Controls.Add(panelTargetasimg, 2, 0);
            tableDatosTarjeta.Controls.Add(TarjetaPicture, 2, 1);
            tableDatosTarjeta.Dock = DockStyle.Fill;
            tableDatosTarjeta.Location = new Point(3, 173);
            tableDatosTarjeta.Name = "tableDatosTarjeta";
            tableDatosTarjeta.RowCount = 2;
            tableDatosTarjeta.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableDatosTarjeta.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableDatosTarjeta.Size = new Size(541, 98);
            tableDatosTarjeta.TabIndex = 8;
            // 
            // txtFecha
            // 
            txtFecha.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtFecha.BackColor = SystemColors.Window;
            txtFecha.BorderColor = Color.DarkGray;
            txtFecha.BorderFocusColor = Color.FromArgb(208, 17, 16);
            txtFecha.BorderRadius = 7;
            txtFecha.BorderSize = 2;
            txtFecha.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFecha.ForeColor = Color.DimGray;
            txtFecha.Location = new Point(3, 56);
            txtFecha.Multiline = false;
            txtFecha.Name = "txtFecha";
            txtFecha.Padding = new Padding(7);
            txtFecha.PasswordChar = false;
            txtFecha.PlaceholderColor = Color.DarkGray;
            txtFecha.PlaceholderText = "MM/YY";
            txtFecha.Size = new Size(151, 39);
            txtFecha.TabIndex = 8;
            txtFecha.Texts = "";
            txtFecha.UnderlinedStyle = false;
            // 
            // txtNumeroTarjeta
            // 
            txtNumeroTarjeta.BackColor = SystemColors.Window;
            txtNumeroTarjeta.BorderColor = Color.DarkGray;
            txtNumeroTarjeta.BorderFocusColor = Color.FromArgb(208, 17, 16);
            txtNumeroTarjeta.BorderRadius = 7;
            txtNumeroTarjeta.BorderSize = 2;
            tableDatosTarjeta.SetColumnSpan(txtNumeroTarjeta, 2);
            txtNumeroTarjeta.Dock = DockStyle.Fill;
            txtNumeroTarjeta.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumeroTarjeta.ForeColor = Color.DimGray;
            txtNumeroTarjeta.Location = new Point(3, 3);
            txtNumeroTarjeta.Multiline = false;
            txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            txtNumeroTarjeta.Padding = new Padding(7);
            txtNumeroTarjeta.PasswordChar = false;
            txtNumeroTarjeta.PlaceholderColor = Color.DarkGray;
            txtNumeroTarjeta.PlaceholderText = "1234 1234 1234 1234 ";
            txtNumeroTarjeta.Size = new Size(395, 39);
            txtNumeroTarjeta.TabIndex = 7;
            txtNumeroTarjeta.Texts = "";
            txtNumeroTarjeta.UnderlinedStyle = false;
            // 
            // txtCVC
            // 
            txtCVC.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtCVC.BackColor = SystemColors.Window;
            txtCVC.BorderColor = Color.DarkGray;
            txtCVC.BorderFocusColor = Color.FromArgb(208, 17, 16);
            txtCVC.BorderRadius = 7;
            txtCVC.BorderSize = 2;
            txtCVC.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCVC.ForeColor = Color.DimGray;
            txtCVC.Location = new Point(191, 56);
            txtCVC.Multiline = false;
            txtCVC.Name = "txtCVC";
            txtCVC.Padding = new Padding(7);
            txtCVC.PasswordChar = false;
            txtCVC.PlaceholderColor = Color.DarkGray;
            txtCVC.PlaceholderText = "CVC";
            txtCVC.Size = new Size(171, 39);
            txtCVC.TabIndex = 9;
            txtCVC.Texts = "";
            txtCVC.UnderlinedStyle = false;
            // 
            // panelTargetasimg
            // 
            panelTargetasimg.Controls.Add(MCPicture);
            panelTargetasimg.Controls.Add(VisaPicture);
            panelTargetasimg.Dock = DockStyle.Fill;
            panelTargetasimg.Location = new Point(404, 3);
            panelTargetasimg.Name = "panelTargetasimg";
            panelTargetasimg.Size = new Size(134, 43);
            panelTargetasimg.TabIndex = 10;
            // 
            // MCPicture
            // 
            MCPicture.Dock = DockStyle.Right;
            MCPicture.Image = IntroductionView.Properties.Resources.mastercard;
            MCPicture.Location = new Point(73, 0);
            MCPicture.Name = "MCPicture";
            MCPicture.Size = new Size(61, 43);
            MCPicture.SizeMode = PictureBoxSizeMode.Zoom;
            MCPicture.TabIndex = 1;
            MCPicture.TabStop = false;
            // 
            // VisaPicture
            // 
            VisaPicture.Dock = DockStyle.Left;
            VisaPicture.Image = IntroductionView.Properties.Resources.visa;
            VisaPicture.Location = new Point(0, 0);
            VisaPicture.Name = "VisaPicture";
            VisaPicture.Size = new Size(63, 43);
            VisaPicture.SizeMode = PictureBoxSizeMode.Zoom;
            VisaPicture.TabIndex = 0;
            VisaPicture.TabStop = false;
            // 
            // TarjetaPicture
            // 
            TarjetaPicture.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            TarjetaPicture.Image = IntroductionView.Properties.Resources.tarjeta;
            TarjetaPicture.Location = new Point(404, 56);
            TarjetaPicture.Name = "TarjetaPicture";
            TarjetaPicture.Size = new Size(125, 39);
            TarjetaPicture.SizeMode = PictureBoxSizeMode.Zoom;
            TarjetaPicture.TabIndex = 11;
            TarjetaPicture.TabStop = false;
            // 
            // TableProducts
            // 
            TableProducts.AutoScroll = true;
            TableProducts.ColumnCount = 2;
            TableProducts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            TableProducts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            TableProducts.Dock = DockStyle.Fill;
            TableProducts.Location = new Point(0, 113);
            TableProducts.Name = "TableProducts";
            TableProducts.RowCount = 1;
            TableProducts.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableProducts.Size = new Size(746, 521);
            TableProducts.TabIndex = 3;
            // 
            // Timer
            // 
            Timer.Enabled = true;
            Timer.Interval = 1000;
            Timer.Tick += Timer_Tick;
            // 
            // CartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1293, 657);
            Controls.Add(TableProducts);
            Controls.Add(TablePago);
            Controls.Add(FooterPanel);
            Controls.Add(HeaderTable);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CartForm";
            Text = "KICK5";
            HeaderTable.ResumeLayout(false);
            HeaderTable.PerformLayout();
            UserPanel.ResumeLayout(false);
            MenuPanel.ResumeLayout(false);
            MenuPanel.PerformLayout();
            LogOutPanel.ResumeLayout(false);
            LogOutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoutPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)ExitPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)UserPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoPicture).EndInit();
            FooterPanel.ResumeLayout(false);
            FooterPanel.PerformLayout();
            TablePago.ResumeLayout(false);
            TablePago.PerformLayout();
            tableDatosTarjeta.ResumeLayout(false);
            panelTargetasimg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MCPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)VisaPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)TarjetaPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel HeaderTable;
        private PictureBox LogoPicture;
        private PictureBox UserPicture;
        private Label TitlelLabel;
        private Panel FooterPanel;
        private TableLayoutPanel TablePago;
        private Utlis.CustomeButton btnPagar;
        private Label LabelMetodoPago;
        private Label lblEmail;
        private Label lblDatosTarjeta;
        private Label lblTitular;
        private Utlis.FullCustomTextBox txtEmail;
        private Utlis.FullCustomTextBox txtTitular;
        private TableLayoutPanel tableDatosTarjeta;
        private Utlis.FullCustomTextBox txtFecha;
        private Utlis.FullCustomTextBox txtNumeroTarjeta;
        private Utlis.FullCustomTextBox txtCVC;
        private Panel panelTargetasimg;
        private PictureBox MCPicture;
        private PictureBox VisaPicture;
        private PictureBox TarjetaPicture;
        private TableLayoutPanel TableProducts;
        private Label lblTime;
        private System.Windows.Forms.Timer Timer;
        private Panel UserPanel;
        private Panel MenuPanel;
        private Label lblNombre;
        private Panel LogOutPanel;
        private Label lblLogOut;
        private PictureBox LogoutPicture;
        private PictureBox ExitPicture;
    }
}