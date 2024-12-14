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
            Cantidadlbl = new Label();
            ProductPicture = new PictureBox();
            MarcaLabel = new Label();
            PrecioLabel = new Label();
            ModeloLabel = new Label();
            PictureMore = new PictureBox();
            PictureLess = new PictureBox();
            Stocklbl = new Label();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureMore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureLess).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.BackColor = Color.Transparent;
            tableLayoutPanel.ColumnCount = 3;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.39622F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.50056F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.10322F));
            tableLayoutPanel.Controls.Add(Cantidadlbl, 1, 3);
            tableLayoutPanel.Controls.Add(ProductPicture, 0, 0);
            tableLayoutPanel.Controls.Add(MarcaLabel, 1, 0);
            tableLayoutPanel.Controls.Add(PrecioLabel, 1, 2);
            tableLayoutPanel.Controls.Add(ModeloLabel, 1, 1);
            tableLayoutPanel.Controls.Add(PictureMore, 2, 1);
            tableLayoutPanel.Controls.Add(PictureLess, 2, 2);
            tableLayoutPanel.Controls.Add(Stocklbl, 1, 4);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 5;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 19.272728F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20.727272F));
            tableLayoutPanel.Size = new Size(901, 275);
            tableLayoutPanel.TabIndex = 0;
            // 
            // Cantidadlbl
            // 
            Cantidadlbl.AutoSize = true;
            Cantidadlbl.Font = new Font("Tahoma", 18F, FontStyle.Bold);
            Cantidadlbl.Location = new Point(393, 165);
            Cantidadlbl.Name = "Cantidadlbl";
            Cantidadlbl.Size = new Size(149, 36);
            Cantidadlbl.TabIndex = 4;
            Cantidadlbl.Text = "Cantidad";
            // 
            // ProductPicture
            // 
            ProductPicture.BackColor = Color.FromArgb(234, 238, 239);
            ProductPicture.Dock = DockStyle.Fill;
            ProductPicture.Location = new Point(3, 3);
            ProductPicture.Name = "ProductPicture";
            tableLayoutPanel.SetRowSpan(ProductPicture, 5);
            ProductPicture.Size = new Size(384, 269);
            ProductPicture.TabIndex = 0;
            ProductPicture.TabStop = false;
            // 
            // MarcaLabel
            // 
            MarcaLabel.AutoSize = true;
            MarcaLabel.Font = new Font("Tahoma", 18F, FontStyle.Bold);
            MarcaLabel.Location = new Point(393, 0);
            MarcaLabel.Name = "MarcaLabel";
            MarcaLabel.Size = new Size(107, 36);
            MarcaLabel.TabIndex = 1;
            MarcaLabel.Text = "Marca";
            // 
            // PrecioLabel
            // 
            PrecioLabel.AutoSize = true;
            PrecioLabel.Font = new Font("Tahoma", 18F, FontStyle.Bold);
            PrecioLabel.Location = new Point(393, 110);
            PrecioLabel.Name = "PrecioLabel";
            PrecioLabel.Size = new Size(110, 36);
            PrecioLabel.TabIndex = 3;
            PrecioLabel.Text = "Precio";
            // 
            // ModeloLabel
            // 
            ModeloLabel.AutoSize = true;
            ModeloLabel.Font = new Font("Tahoma", 18F, FontStyle.Bold);
            ModeloLabel.Location = new Point(393, 55);
            ModeloLabel.Name = "ModeloLabel";
            ModeloLabel.Size = new Size(126, 36);
            ModeloLabel.TabIndex = 2;
            ModeloLabel.Text = "Modelo";
            // 
            // PictureMore
            // 
            PictureMore.Cursor = Cursors.Hand;
            PictureMore.Dock = DockStyle.Fill;
            PictureMore.Image = IntroductionView.Properties.Resources.mas;
            PictureMore.Location = new Point(839, 58);
            PictureMore.Name = "PictureMore";
            PictureMore.Size = new Size(59, 49);
            PictureMore.SizeMode = PictureBoxSizeMode.Zoom;
            PictureMore.TabIndex = 5;
            PictureMore.TabStop = false;
            PictureMore.Click += PictureMore_Click;
            // 
            // PictureLess
            // 
            PictureLess.Cursor = Cursors.Hand;
            PictureLess.Dock = DockStyle.Fill;
            PictureLess.Image = IntroductionView.Properties.Resources.signo_menos;
            PictureLess.Location = new Point(839, 113);
            PictureLess.Name = "PictureLess";
            PictureLess.Size = new Size(59, 49);
            PictureLess.SizeMode = PictureBoxSizeMode.Zoom;
            PictureLess.TabIndex = 6;
            PictureLess.TabStop = false;
            PictureLess.Click += PictureLess_Click;
            // 
            // Stocklbl
            // 
            Stocklbl.AutoSize = true;
            Stocklbl.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Stocklbl.Location = new Point(393, 218);
            Stocklbl.Name = "Stocklbl";
            Stocklbl.Size = new Size(99, 36);
            Stocklbl.TabIndex = 7;
            Stocklbl.Text = "Stock";
            // 
            // CartProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(tableLayoutPanel);
            MaximumSize = new Size(901, 275);
            MinimumSize = new Size(501, 175);
            Name = "CartProduct";
            Size = new Size(901, 275);
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProductPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureMore).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureLess).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private PictureBox ProductPicture;
        private Label MarcaLabel;
        private Label ModeloLabel;
        private Label PrecioLabel;
        private Label Cantidadlbl;
        private PictureBox PictureMore;
        private PictureBox PictureLess;
        private Label Stocklbl;
    }
}
