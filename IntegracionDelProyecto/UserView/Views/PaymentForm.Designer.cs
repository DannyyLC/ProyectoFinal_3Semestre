namespace ProyectoProgramacion.Views
{
    partial class PaymentForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            PanelPago = new Panel();
            lblTotal = new Label();
            lblFechaHora = new Label();
            btnDescargar = new Button();
            lblAgradecimiento = new Label();
            dGVPago = new DataGridView();
            pictureBox1 = new PictureBox();
            timerPago = new System.Windows.Forms.Timer(components);
            PanelPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGVPago).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PanelPago
            // 
            PanelPago.BackColor = Color.White;
            PanelPago.Controls.Add(lblTotal);
            PanelPago.Controls.Add(lblFechaHora);
            PanelPago.Controls.Add(btnDescargar);
            PanelPago.Controls.Add(lblAgradecimiento);
            PanelPago.Controls.Add(dGVPago);
            PanelPago.Controls.Add(pictureBox1);
            PanelPago.Dock = DockStyle.Fill;
            PanelPago.Location = new Point(0, 0);
            PanelPago.Margin = new Padding(2);
            PanelPago.Name = "PanelPago";
            PanelPago.Size = new Size(768, 385);
            PanelPago.TabIndex = 0;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 14.25F);
            lblTotal.Location = new Point(598, 313);
            lblTotal.Margin = new Padding(2, 0, 2, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(61, 25);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total: ";
            // 
            // lblFechaHora
            // 
            lblFechaHora.AutoSize = true;
            lblFechaHora.Font = new Font("Segoe UI", 14.25F);
            lblFechaHora.Location = new Point(22, 313);
            lblFechaHora.Margin = new Padding(2, 0, 2, 0);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(130, 25);
            lblFechaHora.TabIndex = 4;
            lblFechaHora.Text = "Fecha y Hora: ";
            // 
            // btnDescargar
            // 
            btnDescargar.Font = new Font("Segoe UI", 14.25F);
            btnDescargar.Location = new Point(310, 307);
            btnDescargar.Margin = new Padding(2);
            btnDescargar.Name = "btnDescargar";
            btnDescargar.Size = new Size(179, 36);
            btnDescargar.TabIndex = 3;
            btnDescargar.Text = "Descargar Ticket";
            btnDescargar.UseVisualStyleBackColor = true;
            btnDescargar.Click += btnDescargar_Click_1;
            // 
            // lblAgradecimiento
            // 
            lblAgradecimiento.AutoSize = true;
            lblAgradecimiento.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAgradecimiento.Location = new Point(215, 38);
            lblAgradecimiento.Margin = new Padding(2, 0, 2, 0);
            lblAgradecimiento.Name = "lblAgradecimiento";
            lblAgradecimiento.Size = new Size(375, 45);
            lblAgradecimiento.TabIndex = 2;
            lblAgradecimiento.Text = "¡Gracias por su compra!";
            // 
            // dGVPago
            // 
            dGVPago.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGVPago.BackgroundColor = Color.White;
            dGVPago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVPago.Location = new Point(22, 122);
            dGVPago.Margin = new Padding(2);
            dGVPago.Name = "dGVPago";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dGVPago.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dGVPago.RowHeadersWidth = 62;
            dataGridViewCellStyle2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dGVPago.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dGVPago.Size = new Size(726, 160);
            dGVPago.TabIndex = 1;
            dGVPago.CellContentClick += dGVPago_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(583, 8);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // timerPago
            // 
            timerPago.Enabled = true;
            timerPago.Interval = 1000;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 385);
            Controls.Add(PanelPago);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "PaymentForm";
            Text = "Resumen de compra";
            Load += PaymentForm_Load;
            PanelPago.ResumeLayout(false);
            PanelPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGVPago).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelPago;
        private PictureBox pictureBox1;
        private Button btnDescargar;
        private Label lblAgradecimiento;
        private DataGridView dGVPago;
        private Label lblFechaHora;
        private System.Windows.Forms.Timer timerPago;
        private Label lblTotal;
    }
}