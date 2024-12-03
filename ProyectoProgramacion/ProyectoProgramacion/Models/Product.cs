using System;

namespace ProyectoProgramacion.Models
{
    public class Product
    {
        // Propiedades
        public int Id { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        // Constructor con Parametros
        public Product(int id = 0, string model = "", string description = "", string image = "", string brand = "", decimal price = 0, int stock = 0 )
        {
            Id = id;
            Model = model;
            Description = description;
            Image = image;
            Brand = brand;
            Price = price;
            Stock = stock;
        }
    }
}
