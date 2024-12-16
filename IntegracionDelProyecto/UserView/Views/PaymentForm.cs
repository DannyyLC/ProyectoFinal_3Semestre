using ProyectoProgramacion.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgramacion.Views
{
    public partial class PaymentForm : Form
    {
        public List<ProductCart> cartProducts;
        private decimal total;

        public PaymentForm(List<ProductCart> cartProducts, decimal total)
        {
            InitializeComponent();

            this.cartProducts = cartProducts;
            this.total = total;

            dGVPago.ColumnCount = 6;
            dGVPago.Columns[0].Name = "Marca";
            dGVPago.Columns[1].Name = "Modelo";
            dGVPago.Columns[2].Name = "Precio Unitario";
            dGVPago.Columns[3].Name = "Cantidad";
            dGVPago.Columns[4].Name = "Impuestos";
            dGVPago.Columns[5].Name = "Subtotal";

            dGVPago.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Bold);


            foreach (var product in cartProducts)
            {
                decimal impuestos = product.Precio * 0.06m;
                decimal subtotal = product.Precio * product.Cantidad;
                dGVPago.Rows.Add(product.Marca, product.Modelo, $"${product.Precio:F2}", product.Cantidad, $"${impuestos}", $"${subtotal:F2}");

            }

            lblTotal.Text = $"{total:F2}";

            lblFechaHora.Text = $"Fecha y hora del pedido: \n{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}";

        }
        private void btnDescargar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Iniciando generacion de factura");
            ProductCart.GenerarFactura(cartProducts, total);
        }

        //fecha y hora
        private void timerPago_Tick_1(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }


        private void PaymentForm_Load(object sender, EventArgs e)
        {
            timerPago.Start();
        }


        //Data Grid View
        private void dGVPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDescargar_Click_1(object sender, EventArgs e)
        {
            ProductCart.GenerarFactura(cartProducts, total);
        }
    }
}
