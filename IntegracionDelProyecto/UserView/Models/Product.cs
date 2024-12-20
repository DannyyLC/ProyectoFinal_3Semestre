﻿using System;

namespace ProyectoProgramacion.Models
{
    public class Product
    {
        // ----- * * * PROPIEDADES * * * -----
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public List<string> Images { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int Novedad {  get; set; }
        public double Descuento { get; set; }

        // ----- * * * CONSTRUCTOR * * * -----
        public Product(int id = 0, string brand = "", string model = "", string description = "", List<string> images = null, decimal price = 0, int stock = 0, int novedad = 0, double descuento = 0)
        {
            Id = id;
            Brand = brand;
            Model = model;
            Description = description;
            Images = images;
            Price = price;
            Stock = stock;
            Novedad = novedad;  
            Descuento = descuento;
        }
    }
}
