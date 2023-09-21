using System;
using System.Globalization;

namespace PriceTag.Entities {
    internal class ImportedProduct : Product {

        public double ProductFee { get; set; }

        public ImportedProduct() { }
        public ImportedProduct(string name, double price, double fee) : base(name, price) {

            ProductFee = fee;

        }

        public override string PriceTag() {
            return Name +
                " - " + 
                TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " (Fee: " 
                + ProductFee.ToString("F2", CultureInfo.InvariantCulture) 
                + ")";

        }
        public double TotalPrice() {

            return ProductFee + Price;

        }
    }
}
