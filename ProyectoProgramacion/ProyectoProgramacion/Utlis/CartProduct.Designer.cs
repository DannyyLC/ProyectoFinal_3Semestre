namespace ProyectoProgramacion.Views
{
    partial class CartProduct
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
            tableLayoutPanel = new TableLayoutPanel();
            ProductPicture = new PictureBox();
            MarcaLabel = new Label();
            PrecioLabel = new Label();
            ModeloLabel = new Label();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductPicture).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.BackColor = Color.Transparent;
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Controls.Add(ProductPicture, 0, 0);
            tableLayoutPanel.Controls.Add(MarcaLabel, 1, 0);
            tableLayoutPanel.Controls.Add(PrecioLabel, 1, 2);
            tableLayoutPanel.Controls.Add(ModeloLabel, 1, 1);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 34F));
            tableLayoutPanel.Size = new Size(900, 275);
            tableLayoutPanel.TabIndex = 0;
            // 
            // ProductPicture
            // 
            ProductPicture.BackColor = Color.Transparent;
            ProductPicture.Dock = DockStyle.Fill;
            ProductPicture.Location = new Point(3, 3);
            ProductPicture.Name = "ProductPicture";
            tableLayoutPanel.SetRowSpan(ProductPicture, 3);
            ProductPicture.Size = new Size(444, 269);
            ProductPicture.TabIndex = 0;
            ProductPicture.TabStop = false;
            // 
            // MarcaLabel
            // 
            MarcaLabel.AutoSize = true;
            MarcaLabel.Font = new Font("Tahoma", 18F, FontStyle.Bold);
            MarcaLabel.Location = new Point(453, 0);
            MarcaLabel.Name = "MarcaLabel";
            MarcaLabel.Size = new Size(107, 36);
            MarcaLabel.TabIndex = 1;
            MarcaLabel.Text = "Marca";
            // 
            // PrecioLabel
            // 
            PrecioLabel.AutoSize = true;
            PrecioLabel.Font = new Font("Tahoma", 18F, FontStyle.Bold);
            PrecioLabel.Location = new Point(453, 180);
            PrecioLabel.Name = "PrecioLabel";
            PrecioLabel.Size = new Size(110, 36);
            PrecioLabel.TabIndex = 3;
            PrecioLabel.Text = "Precio";
            // 
            // ModeloLabel
            // 
            ModeloLabel.AutoSize = true;
            ModeloLabel.Font = new Font("Tahoma", 18F, FontStyle.Bold);
            ModeloLabel.Location = new Point(453, 90);
            ModeloLabel.Name = "ModeloLabel";
            ModeloLabel.Size = new Size(126, 36);
            ModeloLabel.TabIndex = 2;
            ModeloLabel.Text = "Modelo";
            // 
            // CartProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(tableLayoutPanel);
            MaximumSize = new Size(900, 275);
            MinimumSize = new Size(500, 175);
            Name = "CartProduct";
            Size = new Size(900, 275);
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProductPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private PictureBox ProductPicture;
        private Label MarcaLabel;
        private Label ModeloLabel;
        private Label PrecioLabel;
    }
}
