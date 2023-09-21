using System;
using System.Collections.Generic;
using System.Globalization;

namespace PriceTag.Entities {
    internal class Product {


        public string Name { get; set; }
        public double Price { get; set; }


        public Product() { }
        public Product(string name, double price) {

            Name = name;
            Price = price;

        }

        public virtual string PriceTag() {

            return "Product Name: " +
                    Name
                    + " - Price: "
                    + Price.ToString(CultureInfo.InvariantCulture);

        }


    }
}