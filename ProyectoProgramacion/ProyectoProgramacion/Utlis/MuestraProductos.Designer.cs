namespace ProyectoProgramacion.Utlis
{
    partial class MuestraProductos
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            PictureRegresar = new PictureBox();
            ProductPicture = new PictureBox();
            btnComprarYa = new CustomeButton();
            btnAgregarCarrito = new CustomeButton();
            ProductDescription = new RichTextBox();
            tableLayoutProducts = new TableLayoutPanel();
            PanelProducto = new Panel();
            lblStock = new Label();
            lblPrecio = new Label();
            ProductModel = new Label();
            ProductMarca = new Label();
            PictureLeft = new PictureBox();
            PictuteRight = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PictureRegresar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductPicture).BeginInit();
            tableLayoutProducts.SuspendLayout();
            PanelProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictuteRight).BeginInit();
            SuspendLayout();
            // 
            // PictureRegresar
            // 
            PictureRegresar.Cursor = Cursors.Hand;
            PictureRegresar.Image = Properties.Resources.volver;
            PictureRegresar.Location = new Point(3, 3);
            PictureRegresar.Name = "PictureRegresar";
            PictureRegresar.Size = new Size(40, 38);
            PictureRegresar.SizeMode = PictureBoxSizeMode.Zoom;
            PictureRegresar.TabIndex = 1;
            PictureRegresar.TabStop = false;
            PictureRegresar.Click += PictureRegresar_Click;
            // 
            // ProductPicture
            // 
            tableLayoutProducts.SetColumnSpan(ProductPicture, 2);
            ProductPicture.Dock = DockStyle.Fill;
            ProductPicture.Location = new Point(49, 3);
            ProductPicture.Name = "ProductPicture";
            tableLayoutProducts.SetRowSpan(ProductPicture, 2);
            ProductPicture.Size = new Size(710, 570);
            ProductPicture.SizeMode = PictureBoxSizeMode.Zoom;
            ProductPicture.TabIndex = 0;
            ProductPicture.TabStop = false;
            // 
            // btnComprarYa
            // 
            btnComprarYa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnComprarYa.BackColor = SystemColors.InactiveCaptionText;
            btnComprarYa.BackgroundClor = SystemColors.InactiveCaptionText;
            btnComprarYa.BorderColor = Color.PaleVioletRed;
            btnComprarYa.BorderRadius = 37;
            btnComprarYa.BorderSize = 0;
            btnComprarYa.Cursor = Cursors.Hand;
            btnComprarYa.FlatAppearance.BorderSize = 0;
            btnComprarYa.FlatStyle = FlatStyle.Flat;
            btnComprarYa.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComprarYa.ForeColor = SystemColors.ControlLightLight;
            btnComprarYa.Location = new Point(101, 612);
            btnComprarYa.MaximumSize = new Size(300, 70);
            btnComprarYa.MinimumSize = new Size(277, 56);
            btnComprarYa.Name = "btnComprarYa";
            btnComprarYa.Size = new Size(300, 61);
            btnComprarYa.TabIndex = 1;
            btnComprarYa.Text = "Comprar Ya";
            btnComprarYa.TextColor = SystemColors.ControlLightLight;
            btnComprarYa.UseVisualStyleBackColor = false;
            btnComprarYa.Click += btnComprarYa_Click;
            // 
            // btnAgregarCarrito
            // 
            btnAgregarCarrito.BackColor = Color.FromArgb(208, 17, 16);
            btnAgregarCarrito.BackgroundClor = Color.FromArgb(208, 17, 16);
            btnAgregarCarrito.BorderColor = Color.PaleVioletRed;
            btnAgregarCarrito.BorderRadius = 37;
            btnAgregarCarrito.BorderSize = 0;
            btnAgregarCarrito.Cursor = Cursors.Hand;
            btnAgregarCarrito.FlatAppearance.BorderSize = 0;
            btnAgregarCarrito.FlatStyle = FlatStyle.Flat;
            btnAgregarCarrito.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarCarrito.ForeColor = SystemColors.ControlLightLight;
            btnAgregarCarrito.Location = new Point(407, 612);
            btnAgregarCarrito.MaximumSize = new Size(300, 70);
            btnAgregarCarrito.MinimumSize = new Size(277, 56);
            btnAgregarCarrito.Name = "btnAgregarCarrito";
            btnAgregarCarrito.Size = new Size(288, 61);
            btnAgregarCarrito.TabIndex = 0;
            btnAgregarCarrito.Text = "Agregar al Carrito";
            btnAgregarCarrito.TextColor = SystemColors.ControlLightLight;
            btnAgregarCarrito.UseVisualStyleBackColor = false;
            btnAgregarCarrito.Click += btnAgregarCarrito_Click;
            // 
            // ProductDescription
            // 
            ProductDescription.BackColor = Color.White;
            ProductDescription.BorderStyle = BorderStyle.None;
            ProductDescription.Dock = DockStyle.Fill;
            ProductDescription.Enabled = false;
            ProductDescription.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductDescription.Location = new Point(765, 308);
            ProductDescription.Name = "ProductDescription";
            tableLayoutProducts.SetRowSpan(ProductDescription, 3);
            ProductDescription.Size = new Size(387, 367);
            ProductDescription.TabIndex = 0;
            ProductDescription.Text = "";
            // 
            // tableLayoutProducts
            // 
            tableLayoutProducts.BackColor = SystemColors.Window;
            tableLayoutProducts.ColumnCount = 4;
            tableLayoutProducts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            tableLayoutProducts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31F));
            tableLayoutProducts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31F));
            tableLayoutProducts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            tableLayoutProducts.Controls.Add(PictureRegresar, 0, 0);
            tableLayoutProducts.Controls.Add(ProductPicture, 1, 0);
            tableLayoutProducts.Controls.Add(PanelProducto, 3, 0);
            tableLayoutProducts.Controls.Add(btnComprarYa, 1, 3);
            tableLayoutProducts.Controls.Add(btnAgregarCarrito, 2, 3);
            tableLayoutProducts.Controls.Add(ProductDescription, 3, 1);
            tableLayoutProducts.Controls.Add(PictureLeft, 1, 2);
            tableLayoutProducts.Controls.Add(PictuteRight, 2, 2);
            tableLayoutProducts.Dock = DockStyle.Fill;
            tableLayoutProducts.Location = new Point(0, 0);
            tableLayoutProducts.Name = "tableLayoutProducts";
            tableLayoutProducts.RowCount = 4;
            tableLayoutProducts.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tableLayoutProducts.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutProducts.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutProducts.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutProducts.Size = new Size(1155, 678);
            tableLayoutProducts.TabIndex = 11;
            // 
            // PanelProducto
            // 
            PanelProducto.Controls.Add(lblStock);
            PanelProducto.Controls.Add(lblPrecio);
            PanelProducto.Controls.Add(ProductModel);
            PanelProducto.Controls.Add(ProductMarca);
            PanelProducto.Dock = DockStyle.Fill;
            PanelProducto.Location = new Point(765, 3);
            PanelProducto.Name = "PanelProducto";
            PanelProducto.Size = new Size(387, 299);
            PanelProducto.TabIndex = 3;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStock.Location = new Point(0, 163);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(99, 36);
            lblStock.TabIndex = 4;
            lblStock.Text = "Stock";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(0, 127);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(110, 36);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "Precio";
            // 
            // ProductModel
            // 
            ProductModel.AutoSize = true;
            ProductModel.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductModel.Location = new Point(0, 73);
            ProductModel.Name = "ProductModel";
            ProductModel.Size = new Size(296, 36);
            ProductModel.TabIndex = 2;
            ProductModel.Text = "Modelo de el Tenis";
            // 
            // ProductMarca
            // 
            ProductMarca.AutoSize = true;
            ProductMarca.Font = new Font("Tahoma", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductMarca.Location = new Point(0, 28);
            ProductMarca.Name = "ProductMarca";
            ProductMarca.Size = new Size(343, 45);
            ProductMarca.TabIndex = 1;
            ProductMarca.Text = "Marca de el Tenis";
            // 
            // PictureLeft
            // 
            PictureLeft.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PictureLeft.Cursor = Cursors.Hand;
            PictureLeft.Image = Properties.Resources.atras;
            PictureLeft.Location = new Point(251, 579);
            PictureLeft.Name = "PictureLeft";
            PictureLeft.Size = new Size(150, 27);
            PictureLeft.SizeMode = PictureBoxSizeMode.Zoom;
            PictureLeft.TabIndex = 4;
            PictureLeft.TabStop = false;
            PictureLeft.Click += PictureLeft_Click;
            // 
            // PictuteRight
            // 
            PictuteRight.Cursor = Cursors.Hand;
            PictuteRight.Image = Properties.Resources.Adelante;
            PictuteRight.Location = new Point(407, 579);
            PictuteRight.Name = "PictuteRight";
            PictuteRight.Size = new Size(150, 27);
            PictuteRight.SizeMode = PictureBoxSizeMode.Zoom;
            PictuteRight.TabIndex = 5;
            PictuteRight.TabStop = false;
            PictuteRight.Click += PictuteRight_Click;
            // 
            // MuestraProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutProducts);
            Name = "MuestraProductos";
            Size = new Size(1155, 678);
            ((System.ComponentModel.ISupportInitialize)PictureRegresar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductPicture).EndInit();
            tableLayoutProducts.ResumeLayout(false);
            PanelProducto.ResumeLayout(false);
            PanelProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictuteRight).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox PictureRegresar;
        private PictureBox ProductPicture;
        private CustomeButton btnComprarYa;
        private CustomeButton btnAgregarCarrito;
        private RichTextBox ProductDescription;
        private TableLayoutPanel tableLayoutProducts;
        private Panel PanelProducto;
        private Label ProductModel;
        private Label ProductMarca;
        private PictureBox PictureLeft;
        private PictureBox PictuteRight;
        private Label lblPrecio;
        private Label lblStock;
    }
}
