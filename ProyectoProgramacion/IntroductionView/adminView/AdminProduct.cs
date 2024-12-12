using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adminView
{
    
    public class AdminProduct
    {
        private int id;
        private string nombre;
        private string descripcion;
        private string imagen;
        private string marca;
        private int precio;
        private int stock;

        public AdminProduct(int id, string nombre, string descripcion, string imagen, string marca, int precio, int stock)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Imagen = imagen;
            this.Marca = marca;
            this.Precio = precio;
            this.Stock = stock;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Imagen { get => imagen; set => imagen = value; }
        public string Marca { get => marca; set => marca = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
    }
}
