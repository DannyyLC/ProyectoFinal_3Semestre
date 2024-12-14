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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartForm));
            HeaderTable = new TableLayoutPanel();
            LogoPicture = new PictureBox();
            UserPicture = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)LogoPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UserPicture).BeginInit();
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
            HeaderTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            HeaderTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            HeaderTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            HeaderTable.Controls.Add(LogoPicture, 0, 0);
            HeaderTable.Controls.Add(UserPicture, 2, 0);
            HeaderTable.Controls.Add(TitlelLabel, 1, 0);
            HeaderTable.Dock = DockStyle.Top;
            HeaderTable.Location = new Point(0, 0);
            HeaderTable.Name = "HeaderTable";
            HeaderTable.RowCount = 1;
            HeaderTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            HeaderTable.Size = new Size(1293, 79);
            HeaderTable.TabIndex = 0;
            // 
            // LogoPicture
            // 
            LogoPicture.Cursor = Cursors.Hand;
            LogoPicture.Dock = DockStyle.Fill;
            LogoPicture.Image = IntroductionView.Properties.Resources.Kicks__600_x_100_;
            LogoPicture.Location = new Point(3, 3);
            LogoPicture.Name = "LogoPicture";
            LogoPicture.Size = new Size(252, 73);
            LogoPicture.SizeMode = PictureBoxSizeMode.Zoom;
            LogoPicture.TabIndex = 0;
            LogoPicture.TabStop = false;
            LogoPicture.Click += LogoPicture_Click;
            // 
            // UserPicture
            // 
            UserPicture.Anchor = AnchorStyles.None;
            UserPicture.BackColor = Color.Transparent;
            UserPicture.Image = IntroductionView.Properties.Resources.user1;
            UserPicture.Location = new Point(1122, 9);
            UserPicture.Name = "UserPicture";
            UserPicture.Size = new Size(82, 61);
            UserPicture.SizeMode = PictureBoxSizeMode.Zoom;
            UserPicture.TabIndex = 1;
            UserPicture.TabStop = false;
            // 
            // TitlelLabel
            // 
            TitlelLabel.AutoSize = true;
            TitlelLabel.BackColor = Color.Gainsboro;
            TitlelLabel.Dock = DockStyle.Fill;
            TitlelLabel.Font = new Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitlelLabel.Location = new Point(261, 0);
            TitlelLabel.Name = "TitlelLabel";
            TitlelLabel.Size = new Size(769, 79);
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
            lblTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTime.Location = new Point(1067, 1);
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
            TablePago.Location = new Point(746, 79);
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
            TablePago.Size = new Size(547, 555);
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
            btnPagar.Location = new Point(146, 377);
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
            LabelMetodoPago.Size = new Size(541, 72);
            LabelMetodoPago.TabIndex = 2;
            LabelMetodoPago.Text = "Metodo de Pago";
            LabelMetodoPago.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            lblEmail.Location = new Point(3, 82);
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
            lblDatosTarjeta.Location = new Point(3, 154);
            lblDatosTarjeta.Name = "lblDatosTarjeta";
            lblDatosTarjeta.Size = new Size(229, 27);
            lblDatosTarjeta.TabIndex = 4;
            lblDatosTarjeta.Text = "Datos de la tarjeta";
            // 
            // lblTitular
            // 
            lblTitular.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTitular.AutoSize = true;
            lblTitular.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            lblTitular.Location = new Point(3, 302);
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
            txtEmail.Location = new Point(3, 113);
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
            txtTitular.Location = new Point(3, 333);
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
            tableDatosTarjeta.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 137F));
            tableDatosTarjeta.Controls.Add(txtFecha, 0, 1);
            tableDatosTarjeta.Controls.Add(txtNumeroTarjeta, 0, 0);
            tableDatosTarjeta.Controls.Add(txtCVC, 1, 1);
            tableDatosTarjeta.Controls.Add(panelTargetasimg, 2, 0);
            tableDatosTarjeta.Controls.Add(TarjetaPicture, 2, 1);
            tableDatosTarjeta.Dock = DockStyle.Fill;
            tableDatosTarjeta.Location = new Point(3, 184);
            tableDatosTarjeta.Name = "tableDatosTarjeta";
            tableDatosTarjeta.RowCount = 2;
            tableDatosTarjeta.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableDatosTarjeta.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableDatosTarjeta.Size = new Size(541, 105);
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
            txtFecha.Location = new Point(3, 63);
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
            txtNumeroTarjeta.Size = new Size(397, 39);
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
            txtCVC.Location = new Point(192, 63);
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
            panelTargetasimg.Location = new Point(406, 3);
            panelTargetasimg.Name = "panelTargetasimg";
            panelTargetasimg.Size = new Size(132, 46);
            panelTargetasimg.TabIndex = 10;
            // 
            // MCPicture
            // 
            MCPicture.Dock = DockStyle.Right;
            MCPicture.Image = IntroductionView.Properties.Resources.mastercard;
            MCPicture.Location = new Point(71, 0);
            MCPicture.Name = "MCPicture";
            MCPicture.Size = new Size(61, 46);
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
            VisaPicture.Size = new Size(63, 46);
            VisaPicture.SizeMode = PictureBoxSizeMode.Zoom;
            VisaPicture.TabIndex = 0;
            VisaPicture.TabStop = false;
            // 
            // TarjetaPicture
            // 
            TarjetaPicture.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            TarjetaPicture.Image = IntroductionView.Properties.Resources.tarjeta;
            TarjetaPicture.Location = new Point(406, 63);
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
            TableProducts.Location = new Point(0, 79);
            TableProducts.Name = "TableProducts";
            TableProducts.RowCount = 1;
            TableProducts.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableProducts.Size = new Size(746, 555);
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
            ((System.ComponentModel.ISupportInitialize)LogoPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)UserPicture).EndInit();
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
    }
}