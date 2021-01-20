using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; } //Hangi kategoriye dahil bir ürün olduğu
        public string ProductName { get; set; } // Ürün ismi
        public double UnitPrice { get; set; } //Ürünün birim fiyatı
        public int UnitsInStock { get; set; }//ürünün stok adeti



    }
}
