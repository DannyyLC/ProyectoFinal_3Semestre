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
            PanelPago.Location = new Point(1, -3);
            PanelPago.Name = "PanelPago";
            PanelPago.Size = new Size(801, 453);
            PanelPago.TabIndex = 0;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(629, 395);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(58, 25);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total: ";
            // 
            // lblFechaHora
            // 
            lblFechaHora.AutoSize = true;
            lblFechaHora.Location = new Point(26, 403);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(124, 25);
            lblFechaHora.TabIndex = 4;
            lblFechaHora.Text = "Fecha y Hora: ";
            // 
            // btnDescargar
            // 
            btnDescargar.Location = new Point(267, 395);
            btnDescargar.Name = "btnDescargar";
            btnDescargar.Size = new Size(211, 33);
            btnDescargar.TabIndex = 3;
            btnDescargar.Text = "Descargar Ticket";
            btnDescargar.UseVisualStyleBackColor = true;
            btnDescargar.Click += btnDescargar_Click_1;
            // 
            // lblAgradecimiento
            // 
            lblAgradecimiento.AutoSize = true;
            lblAgradecimiento.Font = new Font("Segoe UI", 15F);
            lblAgradecimiento.Location = new Point(206, 57);
            lblAgradecimiento.Name = "lblAgradecimiento";
            lblAgradecimiento.Size = new Size(332, 41);
            lblAgradecimiento.TabIndex = 2;
            lblAgradecimiento.Text = "Gracias por su compra!!";
            // 
            // dGVPago
            // 
            dGVPago.BackgroundColor = Color.White;
            dGVPago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVPago.Location = new Point(26, 150);
            dGVPago.Name = "dGVPago";
            dGVPago.RowHeadersWidth = 62;
            dGVPago.Size = new Size(713, 231);
            dGVPago.TabIndex = 1;
            dGVPago.CellContentClick += dGVPago_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(589, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 75);
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
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PanelPago);
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