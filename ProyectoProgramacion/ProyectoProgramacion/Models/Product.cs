using System;

namespace ProyectoProgramacion.Models
{
    public class Product
    {
        // Propiedades
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Brand { get; set; }
        public string Colors { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        // Constructor con Parametros
        public Product(int id = 0, string name = "", string description = "", string image = "", string brand = "", string colors = "", decimal price = 0, int stock = 0 )
        {
            Id = id;
            Name = name;
            Description = description;
            Image = image;
            Brand = brand;
            Colors = colors;
            Price = price;
            Stock = stock;
        }
    }
}
