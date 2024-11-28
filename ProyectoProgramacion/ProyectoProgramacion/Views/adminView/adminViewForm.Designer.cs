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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tableLayoutPanelPrincipal = new TableLayoutPanel();
            tableLayoutPanelLateral = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBoxLogo = new PictureBox();
            label1 = new Label();
            btnSignOff = new RoundedButton();
            tableLayoutPanelResultados = new TableLayoutPanel();
            labelTituloResultados = new Label();
            pictureBoxGrafica = new PictureBox();
            labelHora = new Label();
            roundedTableLayoutPanel1 = new RoundedTableLayoutPanel();
            labelResumen = new Label();
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
            btnAddProduct = new RoundedButton();
            btnDeleteProduct = new RoundedButton();
            tableLayoutPanelPrincipal.SuspendLayout();
            tableLayoutPanelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            tableLayoutPanelResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGrafica).BeginInit();
            roundedTableLayoutPanel1.SuspendLayout();
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
            tableLayoutPanelLateral.Controls.Add(pictureBox1, 0, 3);
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
            tableLayoutPanelLateral.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanelLateral.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanelLateral.Size = new Size(198, 715);
            tableLayoutPanelLateral.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom;
            pictureBox1.BackColor = Color.LightBlue;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.Shoe__Final__2024_11_23_20_57_53__1_;
            pictureBox1.Location = new Point(3, 512);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.LightBlue;
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.None;
            pictureBoxLogo.Dock = DockStyle.Fill;
            pictureBoxLogo.Image = Properties.Resources.Kicks__Final__2024_11_23_20_56_34;
            pictureBoxLogo.Location = new Point(3, 3);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(192, 65);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(3, 71);
            label1.Name = "label1";
            label1.Size = new Size(192, 71);
            label1.TabIndex = 1;
            label1.Text = "Administrador";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSignOff
            // 
            btnSignOff.Anchor = AnchorStyles.None;
            btnSignOff.BackColor = Color.Firebrick;
            btnSignOff.BorderRadius = 20;
            btnSignOff.FlatAppearance.BorderSize = 0;
            btnSignOff.FlatStyle = FlatStyle.Flat;
            btnSignOff.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignOff.ForeColor = Color.White;
            btnSignOff.Location = new Point(3, 145);
            btnSignOff.Name = "btnSignOff";
            btnSignOff.Size = new Size(192, 65);
            btnSignOff.TabIndex = 4;
            btnSignOff.Text = "Cerrar sesión";
            btnSignOff.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanelResultados
            // 
            tableLayoutPanelResultados.ColumnCount = 2;
            tableLayoutPanelResultados.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanelResultados.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelResultados.Controls.Add(labelTituloResultados, 0, 0);
            tableLayoutPanelResultados.Controls.Add(pictureBoxGrafica, 0, 1);
            tableLayoutPanelResultados.Controls.Add(labelHora, 1, 0);
            tableLayoutPanelResultados.Controls.Add(roundedTableLayoutPanel1, 1, 1);
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
            labelTituloResultados.Font = new Font("Tahoma", 24F, FontStyle.Bold);
            labelTituloResultados.ForeColor = Color.Black;
            labelTituloResultados.Location = new Point(251, 0);
            labelTituloResultados.Name = "labelTituloResultados";
            labelTituloResultados.Padding = new Padding(0, 15, 60, 0);
            labelTituloResultados.Size = new Size(400, 52);
            labelTituloResultados.TabIndex = 0;
            labelTituloResultados.Text = "Resultados de venta";
            // 
            // pictureBoxGrafica
            // 
            pictureBoxGrafica.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxGrafica.Dock = DockStyle.Fill;
            pictureBoxGrafica.Image = Properties.Resources.diseño_final;
            pictureBoxGrafica.Location = new Point(3, 55);
            pictureBoxGrafica.Name = "pictureBoxGrafica";
            pictureBoxGrafica.Padding = new Padding(30, 15, 30, 5);
            pictureBoxGrafica.Size = new Size(897, 293);
            pictureBoxGrafica.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxGrafica.TabIndex = 1;
            pictureBoxGrafica.TabStop = false;
            // 
            // labelHora
            // 
            labelHora.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelHora.AutoSize = true;
            labelHora.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHora.ForeColor = Color.Black;
            labelHora.Location = new Point(1071, 0);
            labelHora.Name = "labelHora";
            labelHora.Size = new Size(55, 19);
            labelHora.TabIndex = 3;
            labelHora.Text = "Fecha:";
            labelHora.TextAlign = ContentAlignment.TopRight;
            // 
            // roundedTableLayoutPanel1
            // 
            roundedTableLayoutPanel1.BackColor = Color.LightBlue;
            roundedTableLayoutPanel1.BorderRadius = 20;
            roundedTableLayoutPanel1.ColumnCount = 1;
            roundedTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            roundedTableLayoutPanel1.Controls.Add(labelResumen, 0, 0);
            roundedTableLayoutPanel1.Dock = DockStyle.Fill;
            roundedTableLayoutPanel1.ForeColor = Color.LightBlue;
            roundedTableLayoutPanel1.Location = new Point(906, 55);
            roundedTableLayoutPanel1.Name = "roundedTableLayoutPanel1";
            roundedTableLayoutPanel1.RowCount = 4;
            roundedTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            roundedTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            roundedTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            roundedTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            roundedTableLayoutPanel1.Size = new Size(220, 293);
            roundedTableLayoutPanel1.TabIndex = 4;
            // 
            // labelResumen
            // 
            labelResumen.Anchor = AnchorStyles.None;
            labelResumen.AutoSize = true;
            labelResumen.Font = new Font("Tahoma", 24F, FontStyle.Bold);
            labelResumen.ForeColor = Color.Black;
            labelResumen.Location = new Point(27, 17);
            labelResumen.Name = "labelResumen";
            labelResumen.Size = new Size(165, 39);
            labelResumen.TabIndex = 0;
            labelResumen.Text = "Resumen";
            // 
            // tableLayoutPanelListado
            // 
            tableLayoutPanelListado.ColumnCount = 3;
            tableLayoutPanelListado.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanelListado.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelListado.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelListado.Controls.Add(labelListado, 0, 0);
            tableLayoutPanelListado.Controls.Add(dataGridViewListado, 0, 1);
            tableLayoutPanelListado.Controls.Add(btnAddProduct, 1, 0);
            tableLayoutPanelListado.Controls.Add(btnDeleteProduct, 2, 0);
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
            // labelListado
            // 
            labelListado.Anchor = AnchorStyles.None;
            labelListado.AutoSize = true;
            labelListado.Font = new Font("Tahoma", 24F, FontStyle.Bold);
            labelListado.ForeColor = Color.Black;
            labelListado.ImageAlign = ContentAlignment.TopCenter;
            labelListado.Location = new Point(118, 9);
            labelListado.Name = "labelListado";
            labelListado.Padding = new Padding(150, 0, 0, 10);
            labelListado.Size = new Size(500, 49);
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
            dataGridViewCellStyle1.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            dataGridViewCellStyle2.ForeColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewListado.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewListado.Dock = DockStyle.Fill;
            dataGridViewListado.Location = new Point(3, 71);
            dataGridViewListado.Name = "dataGridViewListado";
            dataGridViewListado.ReadOnly = true;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewListado.RowsDefaultCellStyle = dataGridViewCellStyle3;
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
            // btnAddProduct
            // 
            btnAddProduct.Anchor = AnchorStyles.None;
            btnAddProduct.BackColor = Color.DarkSlateGray;
            btnAddProduct.BorderRadius = 20;
            btnAddProduct.FlatAppearance.BorderSize = 0;
            btnAddProduct.FlatStyle = FlatStyle.Flat;
            btnAddProduct.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddProduct.ForeColor = Color.White;
            btnAddProduct.Location = new Point(739, 3);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(178, 62);
            btnAddProduct.TabIndex = 4;
            btnAddProduct.Text = "Agregar Producto";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Anchor = AnchorStyles.None;
            btnDeleteProduct.BackColor = Color.Firebrick;
            btnDeleteProduct.BorderRadius = 20;
            btnDeleteProduct.FlatAppearance.BorderSize = 0;
            btnDeleteProduct.FlatStyle = FlatStyle.Flat;
            btnDeleteProduct.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteProduct.ForeColor = Color.White;
            btnDeleteProduct.Location = new Point(923, 3);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(179, 62);
            btnDeleteProduct.TabIndex = 5;
            btnDeleteProduct.Text = "Eliminar Producto";
            btnDeleteProduct.UseVisualStyleBackColor = false;
            // 
            // adminViewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 715);
            Controls.Add(tableLayoutPanelPrincipal);
            ForeColor = Color.Transparent;
            Name = "adminViewForm";
            Text = "Vista de administrador";
            tableLayoutPanelPrincipal.ResumeLayout(false);
            tableLayoutPanelLateral.ResumeLayout(false);
            tableLayoutPanelLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            tableLayoutPanelResultados.ResumeLayout(false);
            tableLayoutPanelResultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGrafica).EndInit();
            roundedTableLayoutPanel1.ResumeLayout(false);
            roundedTableLayoutPanel1.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanelListado;
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
        private Label labelHora;
        private RoundedTableLayoutPanel roundedTableLayoutPanel1;
        private PictureBox pictureBox1;
        private Label labelResumen;
        private RoundedButton btnAddProduct;
        private RoundedButton btnDeleteProduct;
        private RoundedButton btnSignOff;
    }
}
