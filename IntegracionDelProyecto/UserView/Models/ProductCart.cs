﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ProyectoProgramacion.Models
{
    public class ProductCart
    {
        // ----- * * * PROPIEDADES * * * -----
        public int Userid { get; set; }
        public int ProductId { get; set; }
        public decimal Precio { get; set; }
        public string Imagen { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Cantidad { get; set; }
        public int Stock { get; set; }

        // ----- * * * CONSTRUCTOR * * * -----
        public ProductCart(string image = "", string marca = "", string modelo = "", decimal precio = 0, int userid = 0, int idproduct = 0, int cantidad = 1, int stock = 100)
        {
            this.Imagen = image;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Precio = precio;
            this.Userid = userid;
            this.ProductId = idproduct;
            this.Cantidad = cantidad;
            this.Stock = stock;
        }

        // ----- * * * METODO PARA GENERAR LA FACTURA * * * -----
        public static void GenerarFactura(List<ProductCart> carts, decimal total)
        {
            string projectFolder = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
            string filePath = Path.Combine(projectFolder, "Ticket de Compra.pdf");
            string imagePath = Path.Combine(projectFolder, "Resources","logo.jpg");

            iTextSharp.text.Document document = new iTextSharp.text.Document(PageSize.A4, 10, 10, 10, 10);


            try
            {

                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                document.Open();

                //agregar la imagen
                if (File.Exists(imagePath))
                {
                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(imagePath);
                    logo.ScaleToFit(100f, 100f);
                    logo.Alignment = iTextSharp.text.Image.ALIGN_BOTTOM;

                    document.Add(logo);
                }
                else
                {
                    MessageBox.Show("La imagen no se encontro: " + imagePath);
                }

                //agregar el encabezado del pdf
                Paragraph encabezado = new Paragraph("Ticket de Compra", FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD));
                encabezado.Alignment = Element.ALIGN_CENTER;
                document.Add(encabezado);

                document.Add(new Paragraph($"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm:ss}", FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD)));
                document.Add(new Paragraph(" "));

                //Tabla de Productos
                PdfPTable tabla = new PdfPTable(5);
                tabla.WidthPercentage = 100;
                tabla.AddCell(new PdfPCell(new Phrase("Marca", FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD))));
                tabla.AddCell(new PdfPCell(new Phrase("Modelo", FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD))));
                tabla.AddCell(new PdfPCell(new Phrase("Cantidad", FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD))));
                tabla.AddCell(new PdfPCell(new Phrase("Precio", FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD))));
                tabla.AddCell(new PdfPCell(new Phrase("Subtotal", FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD))));

                decimal subtotal = 0;

                foreach (var product in carts)
                {
                    tabla.AddCell(new PdfPCell(new Phrase(product.Marca, FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD))));
                    tabla.AddCell(new PdfPCell(new Phrase(product.Modelo, FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD))));
                    tabla.AddCell(new PdfPCell(new Phrase(product.Cantidad.ToString(), FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD))));
                    tabla.AddCell(new PdfPCell(new Phrase($"${product.Precio:F2}", FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD))));

                    decimal productSubtotal = product.Precio * product.Cantidad;
                    subtotal += productSubtotal;
                    tabla.AddCell(new PdfPCell(new Phrase($"${productSubtotal:F2}", FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD))));

                }

                document.Add(tabla);

                decimal impuestos = subtotal * 0.06m;
                total=subtotal+impuestos;

                document.Add(new Paragraph(" "));
                document.Add(new Paragraph($"Impuestos (%6): ${impuestos:F2}", FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD)));
                document.Add(new Paragraph($"Total: ${total:F2}", FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD)));
                document.Add(new Paragraph("Gracias por su compra!", FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD)));
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error al generar el ticket: {e.Message}");

            }

            finally
            {
                document.Close();
            }

            //abrir el archivo
            MessageBox.Show($"Ticket generado con exito:{filePath}");
        }
    }
}
