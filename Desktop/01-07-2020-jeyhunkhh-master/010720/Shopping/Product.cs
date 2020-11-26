using System;
using System.Collections.Generic;
using System.Text;

namespace _010720.Shopping
{
    class Product
    {
        public string Name { get; set; }
        public Category Category { get; set; }
        public double Price { get; set; }
        public Photo Photo { get; set; }

        public Product(string name,Category category)
        {
            this.Name = name;
            this.Category = category;
            this.Photo = new Photo();
        }
    }
}
