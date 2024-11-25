namespace adminView
{
    partial class adminViewForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tableLayoutPanelPrincipal = new TableLayoutPanel();
            tableLayoutPanelLateral = new TableLayoutPanel();
            pictureBoxLogo = new PictureBox();
            label1 = new Label();
            tableLayoutPanelResultados = new TableLayoutPanel();
            labelTituloResultados = new Label();
            pictureBoxGrafica = new PictureBox();
            tableLayoutPanelResumen = new TableLayoutPanel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            labelR1 = new Label();
            tableLayoutPanelListado = new TableLayoutPanel();
            labelListado = new Label();
            dataGridViewListado = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripción = new DataGridViewTextBoxColumn();
            Imagen = new DataGridViewImageColumn();
            Marca = new DataGridViewTextBoxColumn();
            Colores = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            labelHora = new Label();
            btnSignOff = new RoundedButton(Color.Firebrick);
            btnAgregarProducto = new RoundedButton(Color.White);
            btnEliminarProducto = new RoundedButton(Color.White);
            tableLayoutPanelPrincipal.SuspendLayout();
            tableLayoutPanelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            tableLayoutPanelResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGrafica).BeginInit();
            tableLayoutPanelResumen.SuspendLayout();
            tableLayoutPanelListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListado).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanelPrincipal
            // 
            tableLayoutPanelPrincipal.BackColor = Color.White;
            tableLayoutPanelPrincipal.ColumnCount = 2;
            tableLayoutPanelPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanelPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanelPrincipal.Controls.Add(tableLayoutPanelLateral, 0, 0);
            tableLayoutPanelPrincipal.Controls.Add(tableLayoutPanelResultados, 1, 0);
            tableLayoutPanelPrincipal.Controls.Add(tableLayoutPanelListado, 1, 1);
            tableLayoutPanelPrincipal.Dock = DockStyle.Fill;
            tableLayoutPanelPrincipal.Location = new Point(0, 0);
            tableLayoutPanelPrincipal.Name = "tableLayoutPanelPrincipal";
            tableLayoutPanelPrincipal.RowCount = 2;
            tableLayoutPanelPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelPrincipal.Size = new Size(1341, 715);
            tableLayoutPanelPrincipal.TabIndex = 0;
            // 
            // tableLayoutPanelLateral
            // 
            tableLayoutPanelLateral.BackColor = Color.LightBlue;
            tableLayoutPanelLateral.ColumnCount = 1;
            tableLayoutPanelLateral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelLateral.Controls.Add(pictureBoxLogo, 0, 0);
            tableLayoutPanelLateral.Controls.Add(label1, 0, 1);
            tableLayoutPanelLateral.Controls.Add(btnSignOff, 0, 2);
            tableLayoutPanelLateral.Dock = DockStyle.Fill;
            tableLayoutPanelLateral.Location = new Point(0, 0);
            tableLayoutPanelLateral.Margin = new Padding(0, 0, 3, 0);
            tableLayoutPanelLateral.Name = "tableLayoutPanelLateral";
            tableLayoutPanelLateral.RowCount = 4;
            tableLayoutPanelPrincipal.SetRowSpan(tableLayoutPanelLateral, 2);
            tableLayoutPanelLateral.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanelLateral.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanelLateral.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanelLateral.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelLateral.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelLateral.Size = new Size(198, 715);
            tableLayoutPanelLateral.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.LightBlue;
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.None;
            pictureBoxLogo.Dock = DockStyle.Fill;
            pictureBoxLogo.Image = Properties.Resources.Kicks__Final__2024_11_23_20_56_34;
            pictureBoxLogo.Location = new Point(3, 3);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(192, 63);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 69);
            label1.Name = "label1";
            label1.Size = new Size(192, 69);
            label1.TabIndex = 1;
            label1.Text = "Administrador";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSignOff
            // 
            btnSignOff.Anchor = AnchorStyles.Top;
            btnSignOff.BackColor = Color.Firebrick;
            btnSignOff.BorderRadius = 30;
            btnSignOff.FlatAppearance.BorderSize = 0;
            btnSignOff.FlatStyle = FlatStyle.Flat;
            btnSignOff.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignOff.ForeColor = Color.White;
            btnSignOff.Location = new Point(24, 141);
            btnSignOff.Name = "btnSignOff";
            btnSignOff.Size = new Size(150, 50);
            btnSignOff.TabIndex = 2;
            btnSignOff.Text = "Cerrar Sesión";
            btnSignOff.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanelResultados
            // 
            tableLayoutPanelResultados.ColumnCount = 2;
            tableLayoutPanelResultados.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanelResultados.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelResultados.Controls.Add(labelTituloResultados, 0, 0);
            tableLayoutPanelResultados.Controls.Add(pictureBoxGrafica, 0, 1);
            tableLayoutPanelResultados.Controls.Add(tableLayoutPanelResumen, 1, 1);
            tableLayoutPanelResultados.Controls.Add(labelHora, 1, 0);
            tableLayoutPanelResultados.Dock = DockStyle.Fill;
            tableLayoutPanelResultados.Location = new Point(204, 3);
            tableLayoutPanelResultados.Margin = new Padding(3, 3, 8, 3);
            tableLayoutPanelResultados.Name = "tableLayoutPanelResultados";
            tableLayoutPanelResultados.RowCount = 2;
            tableLayoutPanelResultados.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanelResultados.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanelResultados.Size = new Size(1129, 351);
            tableLayoutPanelResultados.TabIndex = 1;
            // 
            // labelTituloResultados
            // 
            labelTituloResultados.Anchor = AnchorStyles.Top;
            labelTituloResultados.AutoSize = true;
            labelTituloResultados.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTituloResultados.Location = new Point(114, 0);
            labelTituloResultados.Name = "labelTituloResultados";
            labelTituloResultados.Padding = new Padding(0, 15, 355, 0);
            labelTituloResultados.Size = new Size(674, 52);
            labelTituloResultados.TabIndex = 0;
            labelTituloResultados.Text = "Resultados de venta";
            // 
            // pictureBoxGrafica
            // 
            pictureBoxGrafica.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxGrafica.Dock = DockStyle.Fill;
            pictureBoxGrafica.Image = Properties.Resources.imgplaceholder;
            pictureBoxGrafica.Location = new Point(3, 55);
            pictureBoxGrafica.Name = "pictureBoxGrafica";
            pictureBoxGrafica.Padding = new Padding(30, 30, 30, 10);
            pictureBoxGrafica.Size = new Size(897, 293);
            pictureBoxGrafica.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxGrafica.TabIndex = 1;
            pictureBoxGrafica.TabStop = false;
            // 
            // tableLayoutPanelResumen
            // 
            tableLayoutPanelResumen.BackColor = Color.LightBlue;
            tableLayoutPanelResumen.ColumnCount = 1;
            tableLayoutPanelResumen.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelResumen.Controls.Add(label4, 0, 3);
            tableLayoutPanelResumen.Controls.Add(label3, 0, 2);
            tableLayoutPanelResumen.Controls.Add(label2, 0, 0);
            tableLayoutPanelResumen.Controls.Add(labelR1, 0, 1);
            tableLayoutPanelResumen.Dock = DockStyle.Fill;
            tableLayoutPanelResumen.Location = new Point(906, 55);
            tableLayoutPanelResumen.Margin = new Padding(3, 3, 10, 3);
            tableLayoutPanelResumen.Name = "tableLayoutPanelResumen";
            tableLayoutPanelResumen.RowCount = 4;
            tableLayoutPanelResumen.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelResumen.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelResumen.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelResumen.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelResumen.Size = new Size(213, 293);
            tableLayoutPanelResumen.TabIndex = 2;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(61, 245);
            label4.Name = "label4";
            label4.Size = new Size(91, 21);
            label4.TabIndex = 3;
            label4.Text = "Placeholder";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(61, 172);
            label3.Name = "label3";
            label3.Size = new Size(91, 21);
            label3.TabIndex = 2;
            label3.Text = "Placeholder";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(47, 20);
            label2.Name = "label2";
            label2.Size = new Size(118, 32);
            label2.TabIndex = 0;
            label2.Text = "Resumen";
            // 
            // labelR1
            // 
            labelR1.Anchor = AnchorStyles.None;
            labelR1.AutoSize = true;
            labelR1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelR1.Location = new Point(61, 99);
            labelR1.Name = "labelR1";
            labelR1.Size = new Size(91, 21);
            labelR1.TabIndex = 1;
            labelR1.Text = "Placeholder";
            // 
            // tableLayoutPanelListado
            // 
            tableLayoutPanelListado.ColumnCount = 3;
            tableLayoutPanelListado.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanelListado.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelListado.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelListado.Controls.Add(btnAgregarProducto, 1, 0);
            tableLayoutPanelListado.Controls.Add(btnEliminarProducto, 2, 0);
            tableLayoutPanelListado.Controls.Add(labelListado, 0, 0);
            tableLayoutPanelListado.Controls.Add(dataGridViewListado, 0, 1);
            tableLayoutPanelListado.Dock = DockStyle.Fill;
            tableLayoutPanelListado.Location = new Point(221, 360);
            tableLayoutPanelListado.Margin = new Padding(20, 3, 15, 15);
            tableLayoutPanelListado.Name = "tableLayoutPanelListado";
            tableLayoutPanelListado.RowCount = 2;
            tableLayoutPanelListado.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelListado.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanelListado.Size = new Size(1105, 340);
            tableLayoutPanelListado.TabIndex = 2;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = Color.DarkSlateGray;
            btnAgregarProducto.BorderRadius = 20;
            btnAgregarProducto.Dock = DockStyle.Fill;
            btnAgregarProducto.FlatAppearance.BorderSize = 0;
            btnAgregarProducto.FlatStyle = FlatStyle.Flat;
            btnAgregarProducto.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarProducto.ForeColor = Color.White;
            btnAgregarProducto.Location = new Point(756, 20);
            btnAgregarProducto.Margin = new Padding(20);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(144, 28);
            btnAgregarProducto.TabIndex = 0;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.BackColor = Color.Firebrick;
            btnEliminarProducto.BorderRadius = 20;
            btnEliminarProducto.Dock = DockStyle.Fill;
            btnEliminarProducto.FlatAppearance.BorderSize = 0;
            btnEliminarProducto.FlatStyle = FlatStyle.Flat;
            btnEliminarProducto.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminarProducto.ForeColor = Color.White;
            btnEliminarProducto.Location = new Point(940, 20);
            btnEliminarProducto.Margin = new Padding(20);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(145, 28);
            btnEliminarProducto.TabIndex = 1;
            btnEliminarProducto.Text = "Eliminar Producto";
            btnEliminarProducto.UseVisualStyleBackColor = false;
            // 
            // labelListado
            // 
            labelListado.Anchor = AnchorStyles.None;
            labelListado.AutoSize = true;
            labelListado.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelListado.ImageAlign = ContentAlignment.TopCenter;
            labelListado.Location = new Point(125, 6);
            labelListado.Name = "labelListado";
            labelListado.Padding = new Padding(150, 0, 0, 10);
            labelListado.Size = new Size(486, 55);
            labelListado.TabIndex = 2;
            labelListado.Text = "Listado de productos";
            labelListado.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridViewListado
            // 
            dataGridViewListado.AllowUserToAddRows = false;
            dataGridViewListado.AllowUserToDeleteRows = false;
            dataGridViewListado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewListado.BackgroundColor = Color.LightBlue;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListado.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Descripción, Imagen, Marca, Colores, Precio, Stock });
            tableLayoutPanelListado.SetColumnSpan(dataGridViewListado, 3);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewListado.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewListado.Dock = DockStyle.Fill;
            dataGridViewListado.Location = new Point(3, 71);
            dataGridViewListado.Name = "dataGridViewListado";
            dataGridViewListado.ReadOnly = true;
            dataGridViewListado.Size = new Size(1099, 266);
            dataGridViewListado.TabIndex = 3;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Descripción
            // 
            Descripción.HeaderText = "Descripción";
            Descripción.Name = "Descripción";
            Descripción.ReadOnly = true;
            // 
            // Imagen
            // 
            Imagen.HeaderText = "Imagen";
            Imagen.Name = "Imagen";
            Imagen.ReadOnly = true;
            Imagen.Resizable = DataGridViewTriState.True;
            Imagen.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Marca
            // 
            Marca.HeaderText = "Marca";
            Marca.Name = "Marca";
            Marca.ReadOnly = true;
            // 
            // Colores
            // 
            Colores.HeaderText = "Colores";
            Colores.Name = "Colores";
            Colores.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            // 
            // labelHora
            // 
            labelHora.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelHora.AutoSize = true;
            labelHora.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHora.Location = new Point(1032, 0);
            labelHora.Name = "labelHora";
            labelHora.Size = new Size(94, 25);
            labelHora.TabIndex = 3;
            labelHora.Text = "labelHora";
            labelHora.TextAlign = ContentAlignment.TopRight;
            
            System.Windows.Forms.Timer timerHora = new System.Windows.Forms.Timer();
            DateTime fechaHoy = DateTime.Today;
            timerHora.Interval = 1000; // Intervalo de 1 segundo
            timerHora.Tick += (s, e) =>
            {
                labelHora.Text = $"Fecha: {fechaHoy.ToString("dd/MM/yyyy")}\nHora: {DateTime.Now.ToString("HH:mm:ss")}"; // Actualiza la hora en formato 24 horas
            };
            timerHora.Start();
            // 
            // adminViewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 715);
            Controls.Add(tableLayoutPanelPrincipal);
            Name = "adminViewForm";
            Text = "Form1";
            tableLayoutPanelPrincipal.ResumeLayout(false);
            tableLayoutPanelLateral.ResumeLayout(false);
            tableLayoutPanelLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            tableLayoutPanelResultados.ResumeLayout(false);
            tableLayoutPanelResultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGrafica).EndInit();
            tableLayoutPanelResumen.ResumeLayout(false);
            tableLayoutPanelResumen.PerformLayout();
            tableLayoutPanelListado.ResumeLayout(false);
            tableLayoutPanelListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelPrincipal;
        private TableLayoutPanel tableLayoutPanelLateral;
        private PictureBox pictureBoxLogo;
        private Label label1;
        private TableLayoutPanel tableLayoutPanelResultados;
        private Label labelTituloResultados;
        private PictureBox pictureBoxGrafica;
        private TableLayoutPanel tableLayoutPanelResumen;
        private Label label2;
        private Label labelR1;
        private Label label4;
        private Label label3;
        private TableLayoutPanel tableLayoutPanelListado;
        private RoundedButton btnAgregarProducto;
        private RoundedButton btnEliminarProducto;
        private Label labelListado;
        private DataGridView dataGridViewListado;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripción;
        private DataGridViewImageColumn Imagen;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Colores;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Stock;
        private RoundedButton btnSignOff;
        private Label labelHora;
    }
}
