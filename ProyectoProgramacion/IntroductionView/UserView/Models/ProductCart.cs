using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramacion.Models
{
    internal class ProductCart
    {
        // ----- * * * PROPIEDADES * * * -----
        public int Userid { get; set; }
        public int ProductId { get; set; }
        public decimal Precio { get; set; }
        public string Imagen { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        // ----- * * * CONSTRUCTOR * * * -----
        public ProductCart(string image = "", string marca = "", string modelo = "", decimal precio = 0, int userid = 0, int idproduct = 0)
        {
            this.Imagen = image;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Precio = precio;
            this.Userid = userid;
            this.ProductId = idproduct;
        }
    }
}
