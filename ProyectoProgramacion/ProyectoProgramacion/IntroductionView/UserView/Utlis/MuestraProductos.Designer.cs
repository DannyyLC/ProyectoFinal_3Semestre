﻿namespace ProyectoProgramacion.Utlis
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
            PictureRegresar.Image = IntroductionView.Properties.Resources.volver;
            PictureRegresar.Location = new Point(3, 2);
            PictureRegresar.Margin = new Padding(3, 2, 3, 2);
            PictureRegresar.Name = "PictureRegresar";
            PictureRegresar.Size = new Size(34, 28);
            PictureRegresar.SizeMode = PictureBoxSizeMode.Zoom;
            PictureRegresar.TabIndex = 1;
            PictureRegresar.TabStop = false;
            PictureRegresar.Click += PictureRegresar_Click;
            // 
            // ProductPicture
            // 
            tableLayoutProducts.SetColumnSpan(ProductPicture, 2);
            ProductPicture.Dock = DockStyle.Fill;
            ProductPicture.Location = new Point(43, 2);
            ProductPicture.Margin = new Padding(3, 2, 3, 2);
            ProductPicture.Name = "ProductPicture";
            tableLayoutProducts.SetRowSpan(ProductPicture, 2);
            ProductPicture.Size = new Size(620, 427);
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
            btnComprarYa.Location = new Point(88, 458);
            btnComprarYa.Margin = new Padding(3, 2, 3, 2);
            btnComprarYa.MaximumSize = new Size(262, 52);
            btnComprarYa.MinimumSize = new Size(242, 42);
            btnComprarYa.Name = "btnComprarYa";
            btnComprarYa.Size = new Size(262, 46);
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
            btnAgregarCarrito.Location = new Point(356, 458);
            btnAgregarCarrito.Margin = new Padding(3, 2, 3, 2);
            btnAgregarCarrito.MaximumSize = new Size(262, 52);
            btnAgregarCarrito.MinimumSize = new Size(242, 42);
            btnAgregarCarrito.Name = "btnAgregarCarrito";
            btnAgregarCarrito.Size = new Size(252, 46);
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
            ProductDescription.Location = new Point(669, 230);
            ProductDescription.Margin = new Padding(3, 2, 3, 2);
            ProductDescription.Name = "ProductDescription";
            tableLayoutProducts.SetRowSpan(ProductDescription, 3);
            ProductDescription.Size = new Size(339, 276);
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
            tableLayoutProducts.Margin = new Padding(3, 2, 3, 2);
            tableLayoutProducts.Name = "tableLayoutProducts";
            tableLayoutProducts.RowCount = 4;
            tableLayoutProducts.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tableLayoutProducts.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutProducts.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutProducts.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutProducts.Size = new Size(1011, 508);
            tableLayoutProducts.TabIndex = 11;
            // 
            // PanelProducto
            // 
            PanelProducto.Controls.Add(lblStock);
            PanelProducto.Controls.Add(lblPrecio);
            PanelProducto.Controls.Add(ProductModel);
            PanelProducto.Controls.Add(ProductMarca);
            PanelProducto.Dock = DockStyle.Fill;
            PanelProducto.Location = new Point(669, 2);
            PanelProducto.Margin = new Padding(3, 2, 3, 2);
            PanelProducto.Name = "PanelProducto";
            PanelProducto.Size = new Size(339, 224);
            PanelProducto.TabIndex = 3;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStock.Location = new Point(0, 122);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(80, 29);
            lblStock.TabIndex = 4;
            lblStock.Text = "Stock";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(0, 95);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(88, 29);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "Precio";
            // 
            // ProductModel
            // 
            ProductModel.AutoSize = true;
            ProductModel.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductModel.Location = new Point(0, 55);
            ProductModel.Name = "ProductModel";
            ProductModel.Size = new Size(234, 29);
            ProductModel.TabIndex = 2;
            ProductModel.Text = "Modelo de el Tenis";
            // 
            // ProductMarca
            // 
            ProductMarca.AutoSize = true;
            ProductMarca.Font = new Font("Tahoma", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductMarca.Location = new Point(0, 21);
            ProductMarca.Name = "ProductMarca";
            ProductMarca.Size = new Size(277, 36);
            ProductMarca.TabIndex = 1;
            ProductMarca.Text = "Marca de el Tenis";
            // 
            // PictureLeft
            // 
            PictureLeft.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PictureLeft.Cursor = Cursors.Hand;
            PictureLeft.Image = IntroductionView.Properties.Resources.atras;
            PictureLeft.Location = new Point(219, 433);
            PictureLeft.Margin = new Padding(3, 2, 3, 2);
            PictureLeft.Name = "PictureLeft";
            PictureLeft.Size = new Size(131, 20);
            PictureLeft.SizeMode = PictureBoxSizeMode.Zoom;
            PictureLeft.TabIndex = 4;
            PictureLeft.TabStop = false;
            PictureLeft.Click += PictureLeft_Click;
            // 
            // PictuteRight
            // 
            PictuteRight.Cursor = Cursors.Hand;
            PictuteRight.Image = IntroductionView.Properties.Resources.Adelante;
            PictuteRight.Location = new Point(356, 433);
            PictuteRight.Margin = new Padding(3, 2, 3, 2);
            PictuteRight.Name = "PictuteRight";
            PictuteRight.Size = new Size(131, 20);
            PictuteRight.SizeMode = PictureBoxSizeMode.Zoom;
            PictuteRight.TabIndex = 5;
            PictuteRight.TabStop = false;
            PictuteRight.Click += PictuteRight_Click;
            // 
            // MuestraProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutProducts);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MuestraProductos";
            Size = new Size(1011, 508);
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
