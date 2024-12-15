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
            PanelPago.Location = new Point(1, -2);
            PanelPago.Margin = new Padding(2, 2, 2, 2);
            PanelPago.Name = "PanelPago";
            PanelPago.Size = new Size(561, 272);
            PanelPago.TabIndex = 0;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(412, 185);
            lblTotal.Margin = new Padding(2, 0, 2, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(38, 15);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total: ";
            // 
            // lblFechaHora
            // 
            lblFechaHora.AutoSize = true;
            lblFechaHora.Location = new Point(18, 242);
            lblFechaHora.Margin = new Padding(2, 0, 2, 0);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(82, 15);
            lblFechaHora.TabIndex = 4;
            lblFechaHora.Text = "Fecha y Hora: ";
            // 
            // btnDescargar
            // 
            btnDescargar.Location = new Point(194, 213);
            btnDescargar.Margin = new Padding(2, 2, 2, 2);
            btnDescargar.Name = "btnDescargar";
            btnDescargar.Size = new Size(148, 20);
            btnDescargar.TabIndex = 3;
            btnDescargar.Text = "Descargar Ticket";
            btnDescargar.UseVisualStyleBackColor = true;
            btnDescargar.Click += btnDescargar_Click_1;
            // 
            // lblAgradecimiento
            // 
            lblAgradecimiento.AutoSize = true;
            lblAgradecimiento.Font = new Font("Segoe UI", 15F);
            lblAgradecimiento.Location = new Point(144, 34);
            lblAgradecimiento.Margin = new Padding(2, 0, 2, 0);
            lblAgradecimiento.Name = "lblAgradecimiento";
            lblAgradecimiento.Size = new Size(219, 28);
            lblAgradecimiento.TabIndex = 2;
            lblAgradecimiento.Text = "Gracias por su compra!!";
            // 
            // dGVPago
            // 
            dGVPago.BackgroundColor = Color.White;
            dGVPago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVPago.Location = new Point(61, 90);
            dGVPago.Margin = new Padding(2, 2, 2, 2);
            dGVPago.Name = "dGVPago";
            dGVPago.RowHeadersWidth = 62;
            dGVPago.Size = new Size(420, 80);
            dGVPago.TabIndex = 1;
            dGVPago.CellContentClick += dGVPago_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(412, 24);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 45);
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
            ClientSize = new Size(560, 270);
            Controls.Add(PanelPago);
            Margin = new Padding(2, 2, 2, 2);
            Name = "PaymentForm";
            Text = "Form1";
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