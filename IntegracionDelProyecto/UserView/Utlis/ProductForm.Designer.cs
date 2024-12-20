﻿namespace ProyectoProgramacion.Utlis
{
    partial class ProductForm
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
            ProductPicture = new PictureBox();
            MarcaLabel = new Label();
            ModeloLabel = new Label();
            PrecioLabel = new Label();
            LowPanel = new Panel();
            StockLabel = new Label();
            lblDescuento = new Label();
            ((System.ComponentModel.ISupportInitialize)ProductPicture).BeginInit();
            LowPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ProductPicture
            // 
            ProductPicture.BackColor = Color.FromArgb(234, 238, 239);
            ProductPicture.Dock = DockStyle.Fill;
            ProductPicture.Location = new Point(0, 0);
            ProductPicture.Name = "ProductPicture";
            ProductPicture.Size = new Size(450, 600);
            ProductPicture.TabIndex = 0;
            ProductPicture.TabStop = false;
            ProductPicture.Click += ProductPicture_Click;
            // 
            // MarcaLabel
            // 
            MarcaLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            MarcaLabel.AutoSize = true;
            MarcaLabel.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MarcaLabel.Location = new Point(10, 17);
            MarcaLabel.Name = "MarcaLabel";
            MarcaLabel.Size = new Size(56, 22);
            MarcaLabel.TabIndex = 1;
            MarcaLabel.Text = "Marca";
            // 
            // ModeloLabel
            // 
            ModeloLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ModeloLabel.AutoSize = true;
            ModeloLabel.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ModeloLabel.Location = new Point(10, 41);
            ModeloLabel.Name = "ModeloLabel";
            ModeloLabel.Size = new Size(67, 22);
            ModeloLabel.TabIndex = 2;
            ModeloLabel.Text = "Modelo";
            // 
            // PrecioLabel
            // 
            PrecioLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            PrecioLabel.AutoSize = true;
            PrecioLabel.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PrecioLabel.Location = new Point(10, 64);
            PrecioLabel.Name = "PrecioLabel";
            PrecioLabel.Size = new Size(73, 24);
            PrecioLabel.TabIndex = 3;
            PrecioLabel.Text = "Precio";
            // 
            // LowPanel
            // 
            LowPanel.Controls.Add(lblDescuento);
            LowPanel.Controls.Add(StockLabel);
            LowPanel.Controls.Add(PrecioLabel);
            LowPanel.Controls.Add(MarcaLabel);
            LowPanel.Controls.Add(ModeloLabel);
            LowPanel.Dock = DockStyle.Bottom;
            LowPanel.Location = new Point(0, 502);
            LowPanel.Name = "LowPanel";
            LowPanel.Size = new Size(450, 98);
            LowPanel.TabIndex = 4;
            LowPanel.Click += LowPanel_Click;
            // 
            // StockLabel
            // 
            StockLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            StockLabel.AutoSize = true;
            StockLabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StockLabel.Location = new Point(262, 64);
            StockLabel.Name = "StockLabel";
            StockLabel.Size = new Size(58, 24);
            StockLabel.TabIndex = 4;
            StockLabel.Text = "Stock";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescuento.ForeColor = Color.Green;
            lblDescuento.Location = new Point(262, 17);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(164, 34);
            lblDescuento.TabIndex = 5;
            lblDescuento.Text = "Descuento";
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(LowPanel);
            Controls.Add(ProductPicture);
            Cursor = Cursors.Hand;
            MaximumSize = new Size(450, 600);
            MinimumSize = new Size(450, 600);
            Name = "ProductForm";
            Size = new Size(450, 600);
            ((System.ComponentModel.ISupportInitialize)ProductPicture).EndInit();
            LowPanel.ResumeLayout(false);
            LowPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ProductPicture;
        private Label MarcaLabel;
        private Label ModeloLabel;
        private Label PrecioLabel;
        private Panel LowPanel;
        private Label StockLabel;
        private Label lblDescuento;
    }
}
