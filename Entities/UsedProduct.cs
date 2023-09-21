using System;



namespace PriceTag.Entities {
    internal class UsedProduct : Product {

        public DateTime ManufactureDate { get; set; }

        public UsedProduct() { }
        public UsedProduct(string name, double price, DateTime date) : base(name, price) {

            ManufactureDate = date;

        }

        public override string PriceTag() {
            return base.PriceTag() + " (MANUFACTURE DATE: " + ManufactureDate.ToString("dd/MM/yyyy") + ")";
        }
    }
}