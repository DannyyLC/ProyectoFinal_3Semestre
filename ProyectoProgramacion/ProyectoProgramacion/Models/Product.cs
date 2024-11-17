using System;

namespace ProyectoProgramacion.Models
{
    public class Product
    {
        // Propiedades
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        // Constructor
        public Product(int id = 0, string name = "", decimal price = 0, string description = "", string image = "")
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;
            Image = image;
        }
    }
}
