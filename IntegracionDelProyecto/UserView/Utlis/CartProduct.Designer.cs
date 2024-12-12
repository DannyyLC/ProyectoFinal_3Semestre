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
            label1 = new Label();
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
            tableLayoutPanel.Controls.Add(label1, 1, 3);
            tableLayoutPanel.Controls.Add(ProductPicture, 0, 0);
            tableLayoutPanel.Controls.Add(MarcaLabel, 1, 0);
            tableLayoutPanel.Controls.Add(PrecioLabel, 1, 2);
            tableLayoutPanel.Controls.Add(ModeloLabel, 1, 1);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 4;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel.Size = new Size(788, 206);
            tableLayoutPanel.TabIndex = 0;
            // 
            // ProductPicture
            // 
            ProductPicture.BackColor = Color.Transparent;
            ProductPicture.Dock = DockStyle.Fill;
            ProductPicture.Location = new Point(3, 2);
            ProductPicture.Margin = new Padding(3, 2, 3, 2);
            ProductPicture.Name = "ProductPicture";
            tableLayoutPanel.SetRowSpan(ProductPicture, 4);
            ProductPicture.Size = new Size(388, 202);
            ProductPicture.TabIndex = 0;
            ProductPicture.TabStop = false;
            // 
            // MarcaLabel
            // 
            MarcaLabel.AutoSize = true;
            MarcaLabel.Font = new Font("Tahoma", 18F, FontStyle.Bold);
            MarcaLabel.Location = new Point(397, 0);
            MarcaLabel.Name = "MarcaLabel";
            MarcaLabel.Size = new Size(85, 29);
            MarcaLabel.TabIndex = 1;
            MarcaLabel.Text = "Marca";
            // 
            // PrecioLabel
            // 
            PrecioLabel.AutoSize = true;
            PrecioLabel.Font = new Font("Tahoma", 18F, FontStyle.Bold);
            PrecioLabel.Location = new Point(397, 102);
            PrecioLabel.Name = "PrecioLabel";
            PrecioLabel.Size = new Size(88, 29);
            PrecioLabel.TabIndex = 3;
            PrecioLabel.Text = "Precio";
            // 
            // ModeloLabel
            // 
            ModeloLabel.AutoSize = true;
            ModeloLabel.Font = new Font("Tahoma", 18F, FontStyle.Bold);
            ModeloLabel.Location = new Point(397, 51);
            ModeloLabel.Name = "ModeloLabel";
            ModeloLabel.Size = new Size(100, 29);
            ModeloLabel.TabIndex = 2;
            ModeloLabel.Text = "Modelo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold);
            label1.Location = new Point(397, 153);
            label1.Name = "label1";
            label1.Size = new Size(88, 29);
            label1.TabIndex = 4;
            label1.Text = "Precio";
            // 
            // CartProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(tableLayoutPanel);
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(788, 206);
            MinimumSize = new Size(438, 131);
            Name = "CartProduct";
            Size = new Size(788, 206);
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
        private Label label1;
    }
}
