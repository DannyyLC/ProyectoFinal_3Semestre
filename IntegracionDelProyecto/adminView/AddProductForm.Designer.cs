namespace adminView
{
    partial class AddProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            textBoxStock = new TextBox();
            labelStock = new Label();
            buttonGuardar = new Button();
            pictureBoxTitulo = new PictureBox();
            labelTitulo = new Label();
            labelID = new Label();
            labelNombre = new Label();
            labelDescripcion = new Label();
            labelImagen = new Label();
            labelMarca = new Label();
            labelPrecio = new Label();
            textBoxID = new TextBox();
            textBoxNombre = new TextBox();
            textBoxDescripcion = new TextBox();
            textBoxMarca = new TextBox();
            textBoxPrecio = new TextBox();
            buttonCargarImagen = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTitulo).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Controls.Add(textBoxStock, 1, 8);
            tableLayoutPanel1.Controls.Add(labelStock, 0, 8);
            tableLayoutPanel1.Controls.Add(buttonGuardar, 0, 9);
            tableLayoutPanel1.Controls.Add(pictureBoxTitulo, 0, 0);
            tableLayoutPanel1.Controls.Add(labelTitulo, 0, 1);
            tableLayoutPanel1.Controls.Add(labelID, 0, 2);
            tableLayoutPanel1.Controls.Add(labelNombre, 0, 3);
            tableLayoutPanel1.Controls.Add(labelDescripcion, 0, 4);
            tableLayoutPanel1.Controls.Add(labelImagen, 0, 5);
            tableLayoutPanel1.Controls.Add(labelMarca, 0, 6);
            tableLayoutPanel1.Controls.Add(labelPrecio, 0, 7);
            tableLayoutPanel1.Controls.Add(textBoxID, 1, 2);
            tableLayoutPanel1.Controls.Add(textBoxNombre, 1, 3);
            tableLayoutPanel1.Controls.Add(textBoxDescripcion, 1, 4);
            tableLayoutPanel1.Controls.Add(textBoxMarca, 1, 6);
            tableLayoutPanel1.Controls.Add(textBoxPrecio, 1, 7);
            tableLayoutPanel1.Controls.Add(buttonCargarImagen, 1, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.9047623F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.523809F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.523809F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.523809F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.523809F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.523809F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.523809F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.523809F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.523809F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.9047623F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(434, 631);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // textBoxStock
            // 
            textBoxStock.Anchor = AnchorStyles.Left;
            textBoxStock.Font = new Font("Tahoma", 14.25F);
            textBoxStock.Location = new Point(133, 510);
            textBoxStock.Name = "textBoxStock";
            textBoxStock.Size = new Size(289, 30);
            textBoxStock.TabIndex = 25;
            // 
            // labelStock
            // 
            labelStock.Anchor = AnchorStyles.Right;
            labelStock.AutoSize = true;
            labelStock.Font = new Font("Tahoma", 14.25F);
            labelStock.Location = new Point(22, 513);
            labelStock.Name = "labelStock";
            labelStock.Padding = new Padding(0, 0, 50, 0);
            labelStock.Size = new Size(105, 23);
            labelStock.TabIndex = 24;
            labelStock.Text = "Stock";
            // 
            // buttonGuardar
            // 
            buttonGuardar.Anchor = AnchorStyles.None;
            tableLayoutPanel1.SetColumnSpan(buttonGuardar, 2);
            buttonGuardar.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonGuardar.Location = new Point(160, 575);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(114, 36);
            buttonGuardar.TabIndex = 20;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click_1;
            // 
            // pictureBoxTitulo
            // 
            pictureBoxTitulo.Anchor = AnchorStyles.Top;
            tableLayoutPanel1.SetColumnSpan(pictureBoxTitulo, 2);
            pictureBoxTitulo.Image = IntroductionView.Properties.Resources.Kicks__Final__2024_11_23_20_56_34;
            pictureBoxTitulo.Location = new Point(131, 3);
            pictureBoxTitulo.Name = "pictureBoxTitulo";
            pictureBoxTitulo.Size = new Size(171, 50);
            pictureBoxTitulo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTitulo.TabIndex = 0;
            pictureBoxTitulo.TabStop = false;
            // 
            // labelTitulo
            // 
            labelTitulo.Anchor = AnchorStyles.None;
            labelTitulo.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(labelTitulo, 2);
            labelTitulo.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(128, 92);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(178, 25);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "Nuevo producto";
            // 
            // labelID
            // 
            labelID.Anchor = AnchorStyles.Right;
            labelID.AutoSize = true;
            labelID.Font = new Font("Tahoma", 14.25F);
            labelID.Location = new Point(25, 153);
            labelID.Name = "labelID";
            labelID.Padding = new Padding(0, 0, 72, 0);
            labelID.Size = new Size(102, 23);
            labelID.TabIndex = 2;
            labelID.Text = "ID";
            // 
            // labelNombre
            // 
            labelNombre.Anchor = AnchorStyles.Right;
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Tahoma", 14.25F);
            labelNombre.Location = new Point(29, 213);
            labelNombre.Name = "labelNombre";
            labelNombre.Padding = new Padding(0, 0, 28, 0);
            labelNombre.Size = new Size(98, 23);
            labelNombre.TabIndex = 3;
            labelNombre.Text = "Modelo";
            // 
            // labelDescripcion
            // 
            labelDescripcion.Anchor = AnchorStyles.Right;
            labelDescripcion.AutoSize = true;
            labelDescripcion.Font = new Font("Tahoma", 14.25F);
            labelDescripcion.Location = new Point(21, 273);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(106, 23);
            labelDescripcion.TabIndex = 4;
            labelDescripcion.Text = "Descripción";
            // 
            // labelImagen
            // 
            labelImagen.Anchor = AnchorStyles.Right;
            labelImagen.AutoSize = true;
            labelImagen.Font = new Font("Tahoma", 14.25F);
            labelImagen.Location = new Point(23, 333);
            labelImagen.Name = "labelImagen";
            labelImagen.Padding = new Padding(0, 0, 29, 0);
            labelImagen.Size = new Size(104, 23);
            labelImagen.TabIndex = 5;
            labelImagen.Text = "Imagen";
            // 
            // labelMarca
            // 
            labelMarca.Anchor = AnchorStyles.Right;
            labelMarca.AutoSize = true;
            labelMarca.Font = new Font("Tahoma", 14.25F);
            labelMarca.Location = new Point(20, 393);
            labelMarca.Name = "labelMarca";
            labelMarca.Padding = new Padding(0, 0, 46, 0);
            labelMarca.Size = new Size(107, 23);
            labelMarca.TabIndex = 6;
            labelMarca.Text = "Marca";
            // 
            // labelPrecio
            // 
            labelPrecio.Anchor = AnchorStyles.Right;
            labelPrecio.AutoSize = true;
            labelPrecio.Font = new Font("Tahoma", 14.25F);
            labelPrecio.Location = new Point(21, 453);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Padding = new Padding(0, 0, 46, 0);
            labelPrecio.Size = new Size(106, 23);
            labelPrecio.TabIndex = 8;
            labelPrecio.Text = "Precio";
            // 
            // textBoxID
            // 
            textBoxID.Anchor = AnchorStyles.Left;
            textBoxID.Font = new Font("Tahoma", 14.25F);
            textBoxID.Location = new Point(133, 150);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(289, 30);
            textBoxID.TabIndex = 10;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Anchor = AnchorStyles.Left;
            textBoxNombre.Font = new Font("Tahoma", 14.25F);
            textBoxNombre.Location = new Point(133, 210);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(289, 30);
            textBoxNombre.TabIndex = 11;
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Anchor = AnchorStyles.Left;
            textBoxDescripcion.Font = new Font("Tahoma", 14.25F);
            textBoxDescripcion.Location = new Point(133, 270);
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(289, 30);
            textBoxDescripcion.TabIndex = 12;
            // 
            // textBoxMarca
            // 
            textBoxMarca.Anchor = AnchorStyles.Left;
            textBoxMarca.Font = new Font("Tahoma", 14.25F);
            textBoxMarca.Location = new Point(133, 390);
            textBoxMarca.Name = "textBoxMarca";
            textBoxMarca.Size = new Size(289, 30);
            textBoxMarca.TabIndex = 14;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Anchor = AnchorStyles.Left;
            textBoxPrecio.Font = new Font("Tahoma", 14.25F);
            textBoxPrecio.Location = new Point(133, 450);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.Size = new Size(289, 30);
            textBoxPrecio.TabIndex = 16;
            // 
            // buttonCargarImagen
            // 
            buttonCargarImagen.Anchor = AnchorStyles.None;
            buttonCargarImagen.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCargarImagen.Location = new Point(137, 328);
            buttonCargarImagen.Name = "buttonCargarImagen";
            buttonCargarImagen.Size = new Size(289, 33);
            buttonCargarImagen.TabIndex = 19;
            buttonCargarImagen.Text = "Agregar imagen";
            buttonCargarImagen.UseVisualStyleBackColor = true;
            buttonCargarImagen.Click += buttonCargarImagen_Click;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 631);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(450, 670);
            MinimumSize = new Size(450, 670);
            Name = "AddProductForm";
            Text = "Agregar Producto";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTitulo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBoxTitulo;
        private Label labelTitulo;
        private Label labelID;
        private Label labelNombre;
        private Label labelDescripcion;
        private Label labelImagen;
        private Label labelMarca;
        private TextBox textBoxID;
        private TextBox textBoxNombre;
        private TextBox textBoxDescripcion;
        private TextBox textBoxMarca;
        private Button buttonCargarImagen;
        private Button buttonGuardar;
        private TextBox textBoxStock;
        private Label labelStock;
        private Label labelPrecio;
        private TextBox textBoxPrecio;
    }
}